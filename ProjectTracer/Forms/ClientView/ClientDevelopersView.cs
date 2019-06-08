using ProjectTracer.Controllers;
using ProjectTracer.Repository;
using System;
using System.Windows.Forms;

namespace ProjectTracer.Forms.ClientView
{
    public partial class ClientDevelopersView : Form
    {
        public Clients  MyClient { get; set; }
        public UnityOfWork Unit { get; set; }
        public Teams SelectedTeam { get; set; }
        public Developers SelectedDeveloper { get; set;  }
        public ClientDevelopersView(Clients myClient )
        {
             Unit = new UnityOfWork(new ProjectTracerEntities()); 
             MyClient = myClient;
            InitializeComponent();
            LoadTeams();
        }
        private void LoadTeams()
        {
            try
            {
                TeamsListView.Items.Clear();
                ClientDevelopersController.GetTeamsItemList(Unit, MyClient.Client_Id).ForEach(item => TeamsListView.Items.Add(item));
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading Teams:");
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

        private void ProjectsBtn_Click(object sender, EventArgs e)
        {
            var projectsForm = new ClientProjectsView(MyClient);
            projectsForm.Show();
            this.Close();
        }

        private void TasksBtn_Click(object sender, EventArgs e)
        {
            var tasksForm = new ClientTasksView(MyClient);
            tasksForm.Show();
            this.Close();
        }

        private void TeamsListView_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem Item = new ListViewItem();
            try
            {
                Item = TeamsListView.GetItemAt(MousePosition.X - 280, MousePosition.Y - 232);

                SelectedTeam = new Teams()
                {
                    Team_ID = int.Parse(Item.SubItems[0].Text),
                };
                MessageBox.Show("Selected Team: " + SelectedTeam.Team_ID);
                DevelopersListView.Items.Clear();
                ClientDevelopersController.FindDevelopersByTeam(Unit, SelectedTeam.Team_ID).ForEach(item => DevelopersListView.Items.Add(item));

            }
            catch (Exception)
            {

                MessageBox.Show("Error getting selected item from database, please try again later ");
            }

        }

        private void ShowALL_Click(object sender, EventArgs e)
        {
            LoadTeams();
            DevelopersListView.Items.Clear();
        }
    }
}
