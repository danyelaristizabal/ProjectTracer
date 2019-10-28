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

            SqlCommand scmd = new SqlCommand($"CREATE LOGIN {user.Id} WITH PASSWORD = '{Encrypt.EncryptString(user.Password, "Pass")}'", sq);

            scmd.Parameters.Clear();

            sq.Open();

            try
            {
               
                var UnitOFWork = new UnityOfWork(new ProjectTracerEntities());

                var projects = UnitOFWork.Project.GetAll().ToList();

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
                                    UnitOFWork.Client.Add(

                                        new Client() {

                                            Id = user.Id, Password = Encrypt.EncryptString(user.Password, "Pass")
                                        }
                                        );
                                    UnitOFWork.Complete();

                                    //Relate client with the new project

                                    UnitOFWork.Client
                                        .GetAll()
                                        .FirstOrDefault(c => c.Id == user.Id)
                                        .Project
                                        .Add(
                                             UnitOFWork.Project
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

                            UnitOFWork.Client.Add(new Client() { Id = user.Id, Password = Encrypt.EncryptString(user.Password, "Pass") });

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
                                    UnitOFWork.Developer
                                        .Add(
                                                new Developer()
                                                {
                                                    Id = user.Id,
                                                    Password = Encrypt.EncryptString(user.Password, "Pass")
                                                }
                                            );
                                    UnitOFWork.Complete();
                                    //No teams in this project? ok, then we create one
                                    var teamId = UnitOFWork.Team.GetAll().Count() + 1;
                                    if (UnitOFWork.Project
                                    .GetAll()
                                    .FirstOrDefault(p => p.Project_ID == project.Project_ID)
                                    .Team.Count == 0)
                                    {
                                        // Add one team to teams 
                                        UnitOFWork.Team
                                            .Add(new Team() { Team_ID = teamId });

                                        UnitOFWork.Complete(); 
                                        //Relate this team to our project 

                                        UnitOFWork.Team
                                            .GetAll()
                                            .FirstOrDefault(t => t.Team_ID == teamId)
                                            .Project
                                            .Add(UnitOFWork.Project.GetAll().FirstOrDefault(t => t.Project_ID == project.Project_ID));
                                        UnitOFWork.Complete();

                                        //Add our Team to our Developer
                                        UnitOFWork.Developer.GetAll().FirstOrDefault(d => d.Id == user.Id)
                                            .Team
                                            .Add(
                                            UnitOFWork.Team
                                            .GetAll()
                                            .FirstOrDefault(t => t.Team_ID == teamId )
                                            );
                                        UnitOFWork.Complete();
                                    }
                                    else
                                    {
                                        //In case that there is already teams working on the project we add the developer to the first
                                        UnitOFWork.Project
                                           .GetAll()
                                           .FirstOrDefault(p => p.Project_ID == project.Project_ID)
                                           .Team
                                           .FirstOrDefault()
                                           .Developer
                                           .Add(UnitOFWork.Developer.GetAll().FirstOrDefault(d => d.Id == user.Id));
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
                            UnitOFWork.Developer.Add(new Developer() { Id = user.Id, Password = Encrypt.EncryptString(user.Password, "Pass") });

                            UnitOFWork.Complete();
                        }
                            
                        break; 
                    case "Senior":
                        scmd.ExecuteScalar();

                        sq.Close();
                        UnitOFWork.Senior.Add(new Senior() { Id = user.Id, Password = Encrypt.EncryptString(user.Password, "Pass") });
                        
                            UnitOFWork.Complete();
                        break; 
                    case "Admin":
                        scmd.ExecuteScalar();

                        sq.Close();
                        UnitOFWork.Administrator.Add(new Administrator() { Id = user.Id, Password = Encrypt.EncryptString(user.Password, "Pass") });
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
                $"use ProjectTracer;  IF NOT EXISTS(SELECT * FROM sys.database_principals WHERE name = N'{user.Id}')  BEGIN CREATE USER[{user.Id}] FOR LOGIN[{user.Id}] EXEC sp_addrolemember N'{user.GetType().Name}', N'{user.Id}' END;", sq);
            
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