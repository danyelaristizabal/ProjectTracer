using System;
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
            var MyEntry = new ProjectsView();
            MyEntry.Show(); 
            Application.Run();
        }
    }
}
