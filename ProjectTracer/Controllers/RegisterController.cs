using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTracer.Models; 

namespace ProjectTracer.Controllers
{
    static class RegisterController
    {
        public static bool RegisterInServer(IUser user)
        {
            SqlConnection sq = new SqlConnection($@"data source=DESKTOP-KGC5T7J;initial catalog=ProjectTracer;integrated security=True");
            SqlCommand scmd = new SqlCommand($"CREATE LOGIN {user.Name} WITH PASSWORD = '{user.Password}'", sq);
            scmd.Parameters.Clear();
            sq.Open();
            try
            {
                scmd.ExecuteScalar();
                sq.Close();
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
