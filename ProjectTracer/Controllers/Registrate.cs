﻿using ProjectTracer.Models;
using ProjectTracer.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTracer.Controllers
{
    public static class Registratator
    {
        public static bool RegisterInDatabaseProc(IUser user)
        {
            SqlConnection sq = new SqlConnection($@"data source=DESKTOP-KGC5T7J;initial catalog=ProjectTracer;integrated security=True ");
            SqlCommand scmd = new SqlCommand($"EXEC dbo.RegisterInDatabase @UserName = '{user.Name}', @RoleName = '{user.GetType().Name}'", sq);
            sq.Open();
            try
            {
                scmd.ExecuteScalar();
                sq.Close();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database:");
                sq.Close();
                return false;
            }
        }
        public static bool RegisterInServerProc(IUser user)
        {
            SqlConnection sq = new SqlConnection($@"data source=DESKTOP-KGC5T7J;initial catalog=ProjectTracer;integrated security=True");

            SqlCommand scmd = new SqlCommand($"EXEC dbo.RegisterInServer @UserName = '{user.Name}', @RoleName = '{user.GetType().Name}'", sq);

            scmd.Parameters.Clear();

            sq.Open();

            try
            {

                var UnitOFWork = new UnityOfWork(new ProjectTracerEntities());

                var projects = UnitOFWork.Projects.GetAll().ToList();

                switch (user.GetType().Name)
                {
                    case "Client":

                        if (user.InvitationCode != string.Empty)
                        {
                            var decryptedId = Encrypt.DecryptString(user.InvitationCode, "Pass");

                            foreach (var project in projects)
                            {
                                if (project.Project_ID == decryptedId)
                                {
                                    scmd.ExecuteScalar();

                                    sq.Close();

                                    // Add the new client
                                    UnitOFWork.Clients.Add(

                                        new Clients()
                                        {

                                            Client_Id = user.Name,
                                            Password = Encrypt.EncryptString(user.Password, "Pass")
                                        }
                                        );
                                    UnitOFWork.Complete();

                                    //Relate client with the new project

                                    UnitOFWork.Clients
                                        .GetAll()
                                        .FirstOrDefault(c => c.Client_Id == user.Name)
                                        .Projects
                                        .Add(
                                             UnitOFWork.Projects
                                            .GetAll()
                                            .FirstOrDefault(P => P.Project_ID == decryptedId)
                                        );

                                    UnitOFWork.Complete();

                                    return true;
                                }
                            }

                            MessageBox.Show("Incorrect Registration Code");
                            return false;

                        }
                        else
                        {
                            scmd.ExecuteScalar();

                            sq.Close();

                            UnitOFWork.Clients.Add(new Clients() { Client_Id = user.Name, Password = Encrypt.EncryptString(user.Password, "Pass") });

                            UnitOFWork.Complete();
                        }
                        break;
                    case "Developer":
                        if (user.InvitationCode != string.Empty)
                        {
                            var decryptedId = Encrypt.DecryptString(user.InvitationCode, "Pass");

                            foreach (var project in projects)
                            {
                                if (project.Project_ID == decryptedId)
                                {
                                    scmd.ExecuteScalar();

                                    sq.Close();
                                    // Add the new dev 
                                    UnitOFWork.Developers
                                        .Add(
                                                new Developers()
                                                {
                                                    Developer_Id = user.Name,
                                                    Password = Encrypt.EncryptString(user.Password, "Pass")
                                                }
                                            );
                                    UnitOFWork.Complete();
                                    //No teams in this project? ok, then we create one
                                    var teamId = UnitOFWork.Teams.GetAll().Count() + 1;
                                    if (UnitOFWork.Projects
                                    .GetAll()
                                    .FirstOrDefault(p => p.Project_ID == project.Project_ID)
                                    .Teams.Count == 0)
                                    {
                                        // Add one team to teams 
                                        UnitOFWork.Teams
                                            .Add(new Teams() { Team_ID = teamId });

                                        UnitOFWork.Complete();
                                        //Relate this team to our project 

                                        UnitOFWork.Teams
                                            .GetAll()
                                            .FirstOrDefault(t => t.Team_ID == teamId)
                                            .Projects
                                            .Add(UnitOFWork.Projects.GetAll().FirstOrDefault(t => t.Project_ID == project.Project_ID));
                                        UnitOFWork.Complete();

                                        //Add our Team to our Developer
                                        UnitOFWork.Developers.GetAll().FirstOrDefault(d => d.Developer_Id == user.Name)
                                            .Teams
                                            .Add(
                                            UnitOFWork.Teams
                                            .GetAll()
                                            .FirstOrDefault(t => t.Team_ID == teamId)
                                            );
                                        UnitOFWork.Complete();
                                    }
                                    else
                                    {
                                        //In case that there is already teams working on the project we add the developer to the first
                                        UnitOFWork.Projects
                                           .GetAll()
                                           .FirstOrDefault(p => p.Project_ID == project.Project_ID)
                                           .Teams
                                           .FirstOrDefault()
                                           .Developers
                                           .Add(UnitOFWork.Developers.GetAll().FirstOrDefault(d => d.Developer_Id == user.Name));
                                        UnitOFWork.Complete();
                                    }

                                    UnitOFWork.Complete();
                                    MessageBox.Show("Developer registrated");
                                    return true;
                                }
                            }

                            MessageBox.Show("Incorrect Registration Code");
                            return false;

                        }
                        else
                        {
                            scmd.ExecuteScalar();

                            sq.Close();
                            UnitOFWork.Developers.Add(new Developers() { Developer_Id = user.Name, Password = Encrypt.EncryptString(user.Password, "Pass") });

                            UnitOFWork.Complete();
                        }

                        break;
                    case "Senior":
                        scmd.ExecuteScalar();

                        sq.Close();
                        UnitOFWork.Seniors.Add(new Seniors() { Senior_Id = user.Name, Password = Encrypt.EncryptString(user.Password, "Pass") });

                        UnitOFWork.Complete();
                        break;
                    case "Admin":
                        scmd.ExecuteScalar();

                        sq.Close();
                        UnitOFWork.Administrators.Add(new Administrators() { Administrator = user.Name, Password = Encrypt.EncryptString(user.Password, "Pass") });
                        UnitOFWork.Complete();
                        break;
                    default:
                        break;
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in sever:");
                sq.Close();
                return false;
            }
        }
    }
}
