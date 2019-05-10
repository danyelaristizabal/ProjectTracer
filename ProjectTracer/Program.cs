using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTracer.Forms;
using ProjectTracer.Forms;

namespace ProjectTracer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var MyEntry = new ProjectsView();
            MyEntry.Show(); 
            Application.Run();

            //var context = new EntitiesProjectTracer();
            //var project = new Projects()
            //{
            //    Project_ID = "mypmlkusalkmksy888",
            //    Description = "hi",
            //    DeadLine = DateTime.Now,
            //    Result = "FirstCommit"
            //};
            //context.Projects.Add(project);
            //context.SaveChanges();
        }
    }
}
