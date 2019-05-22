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
        public static Form GetLogIn(String User, Form Base )
        {
            var LogIn = new Form(); 
            switch (User)
            {
                case "Client":
                    var myClient = new Client();
                     LogIn = new LogInView(myClient, Base);
                    break;
                case "Developer": 
                    var myDeveloper = new Developer();
                     LogIn = new LogInView(myDeveloper, Base);
                    break;
                case "Senior":
                    var mySenior = new Senior();
                     LogIn = new LogInView(mySenior, Base);
                    break;
                case "Admin":
                    var myAdmin = new Admin();
                     LogIn = new LogInView(myAdmin, Base);
                    break;
                default:
                    break;
            }
            return LogIn;  
        }
    }
}
