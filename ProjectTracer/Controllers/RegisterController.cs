using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTracer.Models;
using ProjectTracer.Repository;

namespace ProjectTracer.Controllers
{
    static class RegisterController
    {
        public static bool RegisterInServer(IUser user)
        {
            SqlConnection sq = new SqlConnection($@"data source=DESKTOP-KGC5T7J;initial catalog=ProjectTracer;integrated security=True");
            SqlCommand scmd = new SqlCommand($"CREATE LOGIN {user.Name} WITH PASSWORD = '{Encrypt.EncryptString(user.Password, "Pass")}'", sq);
            scmd.Parameters.Clear();
            sq.Open();
            try
            {
                scmd.ExecuteScalar();
                sq.Close();
                var UnitOFWork = new UnityOfWork(new ProjectTracerEntities());
                switch (user.GetType().Name)
                {
                    case "Client":
                         UnitOFWork.Clients.Add(new Clients() {Client_Id = user.Name,Password = Encrypt.EncryptString(user.Password, "Pass") });
                        UnitOFWork.Complete();
                        break; 
                    case "Developer":
                        UnitOFWork.Developers.Add(new Developers() { Developer_Id = user.Name, Password = Encrypt.EncryptString(user.Password, "Pass") });
                        UnitOFWork.Complete();
                        break; 
                    case "Senior":
                        UnitOFWork.Seniors.Add(new Seniors() { Senior_Id = user.Name, Password = Encrypt.EncryptString(user.Password, "Pass") });
                        UnitOFWork.Complete();
                        break; 
                    case "Admin":
                         UnitOFWork.Administrators.Add(new Administrators() { Administrator = user.Name, Password = Encrypt.EncryptString(user.Password, "Pass") });
                        UnitOFWork.Complete();
                        break;
                    default:
                        break; 
                }
                return true;
            }
            catch (Exception E)
            {
                MessageBox.Show("Error in SERVER:" + E);
                sq.Close();
                return false;
            }
        }
        public static bool RegisterInDatabase(IUser user)
        {
            SqlConnection sq = new SqlConnection($@"data source=DESKTOP-KGC5T7J;initial catalog=ProjectTracer;integrated security=True ");
            SqlCommand scmd = new SqlCommand(
                $"use ProjectTracer;  IF NOT EXISTS(SELECT * FROM sys.database_principals WHERE name = N'{user.Name}')  BEGIN CREATE USER[{user.Name}] FOR LOGIN[{user.Name}] EXEC sp_addrolemember N'{user.GetType().Name}', N'{user.Name}' END;", sq);
            sq.Open();
            try
            {
                scmd.ExecuteScalar();
                sq.Close();
                var unitOfWork = new UnityOfWork(new ProjectTracerEntities()); 
                return true;
            }
            catch (Exception E)
            {
                MessageBox.Show("Error in Database:" + E);
                sq.Close();
                return false;
            }
        }
    }
}