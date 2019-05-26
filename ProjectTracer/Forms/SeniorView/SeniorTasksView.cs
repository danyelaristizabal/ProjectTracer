using System;
using System.Windows.Forms;

namespace ProjectTracer.Forms.SeniorView
{
    public partial class SeniorTasksView : Form
    {
        public Seniors  MySenior { get; set; }
        public SeniorTasksView(Seniors mySenior )
        {
            InitializeComponent();
            MySenior = mySenior; 
        }
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Close_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }
        private void ProjectsBtn_Click(object sender, EventArgs e)
        {
            var projectsForm = new SeniorProjectsView(MySenior);
            projectsForm.Show();
            this.Close();
        }
        private void DevelopersBtn_Click(object sender, EventArgs e)
        {
            var developersForm = new SeniorDevelopersView(MySenior);
            developersForm.Show();
            this.Close();
        }
    }
}
