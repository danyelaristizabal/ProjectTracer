using System;
using System.Windows.Forms;

namespace ProjectTracer.Forms.DeveloperView
{
    public partial class DeveloperTasksView : Form
    {
        public DeveloperTasksView()
        {
            InitializeComponent();
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
            var projectsForm = new DeveloperProjectsView();
            projectsForm.Show();
            this.Close();
        }

    }
}
