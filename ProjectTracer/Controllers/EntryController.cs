using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracer.Forms;
using ProjectTracer.Models;
using System.Windows.Forms;

namespace ProjectTracer.Controllers
{
    static class EntryController
    {
        public static Form GetLogIn(String User )
        {
            var LogIn = new Form(); 
            switch (User)
            {
                case "Client":
                    var myClient = new Client();
                     LogIn = new LogInView(myClient);
                    break;
                case "Developer": 
                    var myDeveloper = new Developer();
                     LogIn = new LogInView(myDeveloper);
                    break;
                case "Senior":
                    var mySenior = new Senior();
                     LogIn = new LogInView(mySenior);
                    break;
                case "Admin":
                    var myAdmin = new Admin();
                     LogIn = new LogInView(myAdmin);
                    break;
                default:
                    break;
            }
            return LogIn;  
        }

        public static string GetTypeOfUser(String User)
        {
            switch (User)
            {
                case "Client":
                    return "Client";
                case "Developer":
                    return "Developer";
                case "Senior":
                    return "Senior";
                case "Admin":
                    return "Admin";
                default:
                    break;
            }
            return"";
        }


    }
}
