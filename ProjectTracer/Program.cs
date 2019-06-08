using System;
using System.Windows.Forms;
using ProjectTracer.Forms;
using ProjectTracer.Forms.ClientView;

namespace ProjectTracer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var MyEntry = new EntryView();
            //var MyEntry = new ClientDevelopersView();

            MyEntry.Show();
            Application.Run();
        }
    }
}
