using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTracer.Models;
using ProjectTracer.Controllers;
using ProjectTracer.Repository;

namespace ProjectTracer.Controllers
{
    static class RegisterController
    {
        public static bool RegisterInServer(IUser user)
        {
            SqlConnection sq = new SqlConnection($@"data source=DESKTOP-7IPPT3O\MYSERVERSQL;initial catalog=ProjectTracer;integrated security=True");

            SqlCommand scmd = new SqlCommand($"CREATE LOGIN {user.Name} WITH PASSWORD = '{Encrypt.EncryptString(user.Password, "Pass")}'", sq);

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

                                        new Clients() {

                                            Client_Id = user.Name, Password = Encrypt.EncryptString(user.Password, "Pass")
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
                                            .FirstOrDefault(t => t.Team_ID == teamId )
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
                MessageBox.Show("Error in sever:" );
                sq.Close();
                return false;
            }
        }
        internal static bool Registrate(IUser user)
        {
            return (RegisterInServer(user) &
              RegisterInDatabase(user));
        }    
        public static bool RegisterInDatabase(IUser user)
        {
            SqlConnection sq = new SqlConnection($@"data source=DESKTOP-7IPPT3O\MYSERVERSQL;initial catalog=ProjectTracer;integrated security=True ");
            SqlCommand scmd = new SqlCommand(
                $"use ProjectTracer;  IF NOT EXISTS(SELECT * FROM sys.database_principals WHERE name = N'{user.Name}')  BEGIN CREATE USER[{user.Name}] FOR LOGIN[{user.Name}] EXEC sp_addrolemember N'{user.GetType().Name}', N'{user.Name}' END;", sq);
            
            try
            {
                sq.Open();
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
        internal static bool Registrateproc(IUser user)
        {
            return( Registratator.RegisterInDatabaseProc( user) &&
                Registratator.RegisterInServerProc( user));
        }
       
    }
}