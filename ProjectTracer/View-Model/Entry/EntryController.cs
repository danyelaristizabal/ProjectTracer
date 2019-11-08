using System;
using ProjectTracer.Models;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ProjectTracerUnitTests")]
namespace ProjectTracer.Controllers
{
    static class EntryController
    {
        public static LogInView GetLogIn(String User)
        {
            var logIn = new LogInView(new Client()); 

            switch (User)
            {

                case "Client":

                    var myClient = new Client();

                     logIn = new LogInView(myClient);

                    break;

                case "Developer": 

                    var myDeveloper = new Developer();

                     logIn = new LogInView(myDeveloper);

                    break;

                case "Senior":

                    var mySenior = new Senior();

                     logIn = new LogInView(mySenior);

                    break;

                case "Administrator":

                    var myAdmin = new Administrator();

                     logIn = new LogInView(myAdmin);

                    break;

                default:
                    throw new  NullReferenceException(); 
            }

            return logIn;  
        }
    }
}
