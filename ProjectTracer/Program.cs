using System;
using System.Windows.Forms;
using ProjectTracer.Forms;
namespace ProjectTracer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var MyEntry = new EntryView(new InitialBaseView());
            MyEntry.Show();
            Application.Run();
        }
    }
}
