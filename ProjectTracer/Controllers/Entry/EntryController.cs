using System;
using ProjectTracer.Models;
using System.Windows.Forms;

namespace ProjectTracer.Controllers
{
    static class EntryController
    {
        public static Form GetLogIn(String User)
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

                    var myAdmin = new Administrator();

                     LogIn = new LogInView(myAdmin);

                    break;

                default:

                    break;
            }

            return LogIn;  
        }
    }
}
