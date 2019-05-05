using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTracer.Forms.ClientView
{
    public partial class ClientTasksView : Form
    {
        public ClientTasksView()
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
            var projectsForm = new ClientProjectsView();
            projectsForm.Show();
            this.Close();
        }


        private void DevelopersBtn_Click(object sender, EventArgs e)
        {
            var developersForm = new ClientDevelopersView();
            developersForm.Show();
            this.Close();
        }
    }
}
