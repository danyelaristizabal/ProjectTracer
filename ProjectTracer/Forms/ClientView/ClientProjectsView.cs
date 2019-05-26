using ProjectTracer.Controllers;
using ProjectTracer.Repository;
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
    public partial class ClientProjectsView : Form
    {
        private Clients MyClient { get; set; }
        private UnityOfWork Unit { get; set; }
        public ClientProjectsView(Clients myClient)
        {
            MyClient = myClient; 
            Unit = new UnityOfWork(new ProjectTracerEntities()); 
            InitializeComponent();
            LoadProjects();
        }

        private void LoadProjects()
        {
            try
            {
                ProjectsView.Items.Clear();

                ClientProjectsController.GetProjectsItemList(Unit, MyClient.Client_Id).ForEach(item => ProjectsView.Items.Add(item));
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading the projects, please try again later");
            }

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
        private void TasksBtn_Click(object sender, EventArgs e)
        {
            var tasksForm = new ClientTasksView(MyClient);
            tasksForm.Show();
            this.Close();
        }

        private void DevelopersBtn_Click(object sender, EventArgs e)
        {
            var developersForm = new ClientDevelopersView(MyClient);
            developersForm.Show();
            this.Close();
        }

        private void FindById_Click(object sender, EventArgs e)
        {
            ProjectsView.Items.Clear();
            ClientProjectsController.GetProjectsByInput(Unit, FindByIdTxtB.Text, MyClient.Client_Id).ForEach(item => ProjectsView.Items.Add(item));
        }
    }
}
