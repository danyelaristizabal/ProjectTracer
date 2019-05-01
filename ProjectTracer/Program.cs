using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            var context = new EntitiesProjectTracer();
            var post = new Projects()
            {
                Project_ID = "Prodify",
                Description = "hi",
                DeadLine = DateTime.Now,
                Result = "FirstCommit"
            };
            context.Projects.Add(post);
            context.SaveChanges(); 
            Application.Run(new EntryView());
           

        }
    }
}
