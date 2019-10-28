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
        public static bool CheckUserInUserTable(IUser user)
        {
            var UnitOFWork = new UnityOfWork(new ProjectTracerEntities());

            switch (user.GetType().Name)
            {
                case "Client":
                    return UnitOFWork.Client.CheckExistance(user.Id, Encrypt.EncryptString(user.Password,"Pass")); 
                case "Developer":
                    return UnitOFWork.Developer.CheckExistance(user.Id, Encrypt.EncryptString(user.Password,"Pass"));
                case "Senior":
                    return UnitOFWork.Senior.CheckExistance(user.Id, Encrypt.EncryptString(user.Password,"Pass"));
                case "Admin":
                    return UnitOFWork.Administrator.CheckExistance(user.Id, Encrypt.EncryptString(user.Password,"Pass"));
                default:
                    return false;  
            }
        }
        public static Form ChooseStartPage(IUser user)
        {
            UnityOfWork unit = new UnityOfWork(new ProjectTracerEntities());
            var StartPage = new Form();
            switch (user.GetType().Name)
            {
                case "Client":
                    StartPage = new ClientProjectsView(unit.Client.GetAll().FirstOrDefault(c => c.Id == user.Id));
                    break;
                case "Developer":
                    StartPage = new DeveloperProjectsView(unit.Developer.GetAll().FirstOrDefault(d => d.Id == user.Id));
                    break;
                case "Senior":
                    StartPage = new SeniorProjectsView(unit.Senior.GetAll().FirstOrDefault(s => s.Id == user.Id));
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
