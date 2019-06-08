using System;
using System.Data.SqlClient;
using ProjectTracer.Models;
using ProjectTracer.Forms;
using ProjectTracer.Forms.ClientView;
using ProjectTracer.Forms.DeveloperView;
using ProjectTracer.Forms.SeniorView;
using ProjectTracer.Repository;
using System.Windows.Forms;
using System.Linq;

namespace ProjectTracer.Controllers
{
    public static class LogInControler
    {
        public static bool CheckUser(IUser user)
        {
            SqlConnection sq = new SqlConnection($@"data source=DESKTOP-KGC5T7J;initial catalog=ProjectTracer; User Id={user.Name};
          Password={Encrypt.EncryptString(user.Password,"Pass")};");
            try
            {
                sq.Open();
                sq.Close();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show($"Incorrect User Name or Password");
                sq.Close();
                return false;
            }
        }
        public static bool CheckUserInUserTable(IUser user)
        {
            var UnitOFWork = new UnityOfWork(new ProjectTracerEntities());
            switch (user.GetType().Name)
            {
                case "Client":
                    return UnitOFWork.Clients.CheckExistance(user.Name, Encrypt.EncryptString(user.Password,"Pass")); 
                case "Developer":
                    return UnitOFWork.Developers.CheckExistance(user.Name, Encrypt.EncryptString(user.Password,"Pass"));
                case "Senior":
                    return UnitOFWork.Seniors.CheckExistance(user.Name, Encrypt.EncryptString(user.Password,"Pass"));
                case "Admin":
                    return UnitOFWork.Administrators.CheckExistance(user.Name, Encrypt.EncryptString(user.Password,"Pass"));
                default:
                    return false;  
            }
        }
        internal static bool Autentificate(IUser myUser)
        {
            return (CheckUser(myUser) & CheckUserInUserTable(myUser)); 
        }
        public static Form ChooseStartPage(IUser user)
        {
            UnityOfWork unit = new UnityOfWork(new ProjectTracerEntities());
            var StartPage = new Form();
            switch (user.GetType().Name)
            {
                case "Client":
                    StartPage = new ClientProjectsView(unit.Clients.GetAll().FirstOrDefault(c => c.Client_Id == user.Name));
                    break;
                case "Developer":
                    StartPage = new DeveloperProjectsView(unit.Developers.GetAll().FirstOrDefault(d => d.Developer_Id == user.Name));
                    break;
                case "Senior":
                    StartPage = new SeniorProjectsView(unit.Seniors.GetAll().FirstOrDefault(s => s.Senior_Id == user.Name));
                    break;
                case "Admin":
                    StartPage = new ProjectsView();
                    break;
                default:
                    break;
            }
            return StartPage;
        }
    }
}
