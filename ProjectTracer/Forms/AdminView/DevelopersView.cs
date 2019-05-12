using System;
using System.Windows.Forms;

namespace ProjectTracer.Forms
{
    public partial class DevelopersView : Form
    {
        public DevelopersView()
        {
            InitializeComponent();
        }

        private void ProjectsBtn_Click(object sender, EventArgs e)
        {
            var projectsForm = new ProjectsView();
            projectsForm.Show();
            this.Close();
        }

        private void TasksBtn_Click(object sender, EventArgs e)
        {
            var tasksForm = new TasksView();
            tasksForm.Show();
            this.Close();
        }

        private void DevelopersBtn_Click(object sender, EventArgs e)
        {
            var developersForm = new DevelopersView();
            developersForm.Show();
            this.Close();
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            var clientsForm = new ClientsView();
            clientsForm.Show();
            this.Close();
        }

        private void Clients_Click_1(object sender, EventArgs e)
        {
            var clientsForm = new ClientsView();
            clientsForm.Show();
            this.Close();
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

        
    }
}
