using System;
using System.Windows.Forms;
using ProjectTracer.Controllers;
using ProjectTracer.Repository;

namespace ProjectTracer.Forms
{
    public partial class ClientsView : Form
    {
        public Client SelectedClient { get; set; }
        public Project SelectedProject { get; set; }
        public UnityOfWork Unit  { get;  set; }
        public ClientsView()
        {
            InitializeComponent();

            Unit = new UnityOfWork(new ProjectTracerEntities());

            SelectedClient = new Client() { };

            SelectedProject = new Project() { }; 

            LoadClients();

            LoadProjects();

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

        private void ShowALL_Click(object sender, EventArgs e)
        {
            LoadClients();
            LoadProjects();
        }

        private void LoadProjects()
        {
            try
            {
                AdminProjectsView.Items.Clear();

                AdminProjectsController.GetProjectsItemListIgnoreDeadLineAndClient(Unit).ForEach(item => AdminProjectsView.Items.Add(item));
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading the projects, please try again later");
            }

        }

        private void LoadClients()
        {
            try
            {
                ClientsViewList.Items.Clear();

                AdminClientsViewController.GetClientsList(Unit).ForEach(item => ClientsViewList.Items.Add(item));
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading the projects, please try again later");
            }

        }

        private void ClientsViewList_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem Item = new ListViewItem();
            try
            {
                Item = ClientsViewList.GetItemAt(MousePosition.X - 320, MousePosition.Y - 254);
                SelectedClient = new Client()
                {
                    Id = Item.SubItems[0].Text,
                };
                MessageBox.Show("Selected Client: " + SelectedClient.Id);

                AdminProjectsView.Items.Clear();

                AdminClientsViewController.FindProjectsByClient(Unit, SelectedClient.Id).ForEach(item => AdminProjectsView.Items.Add(item));

            }
            catch (Exception)
            {
                MessageBox.Show("Error getting selected item from database, please try again later ");
            }

        }

        private void AdminProjectsView_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem Item = new ListViewItem();
            try
            {
                Item = AdminProjectsView.GetItemAt(MousePosition.X - 320, MousePosition.Y - 489);

                SelectedProject = new Project()
                {
                    Project_ID = Item.SubItems[0].Text,
                };

                MessageBox.Show("Selected Project: " + SelectedProject.Project_ID);

                ClientsViewList.Items.Clear();

                AdminClientsViewController.FindClientsByProject(Unit, SelectedProject.Project_ID).ForEach(item => ClientsViewList.Items.Add(item));

            }
            catch (Exception)
            {

                MessageBox.Show("Error getting selected item from database, please try again later ");
            }

        }

     
    }
}
