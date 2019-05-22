using ProjectTracer.Controllers;
using ProjectTracer.Repository;
using System;
using System.Windows.Forms;

namespace ProjectTracer.Forms
{
    public partial class DevelopersView : Form
    {
        private Developers SelectedDeveloper { get; set; }
        private Teams SelectedTeam { get; set; }
        public UnityOfWork Unit { get; set; }
        public DevelopersView()
        {
            InitializeComponent();
            Unit = new UnityOfWork(new ProjectTracerEntities());
            SelectedTeam = new Teams();
            SelectedDeveloper = new Developers();
            LoadTeams();
            LoadDevelopers();
        }

        private void LoadTeams()
        {
            try
            {
                TeamsListView.Items.Clear();
                AdminDevelopersController.GetTeamsItemList(Unit).ForEach(item => TeamsListView.Items.Add(item));
            }
            catch (Exception e)
            {
                MessageBox.Show("Error loading Teams:"+ e.ToString() );
            }
        }

        private void LoadDevelopers()
        {
            try
            {
                DevelopersListView.Items.Clear();
                AdminDevelopersController.GetDevelopersItemList(Unit).ForEach(item => DevelopersListView.Items.Add(item));
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading Developers, please select a Team");
            }
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

        private void FindByProjectBtn_Click(object sender, EventArgs e)
        {
            TeamsListView.Items.Clear();
            DevelopersListView.Items.Clear();
            string txt = FindByProjectTxtB.Text;
            try
            {
                AdminDevelopersController.FindDevelopersByProject(Unit, txt).ForEach(item => DevelopersListView.Items.Add(item));
                AdminDevelopersController.FindTeamsByProject(Unit, txt).ForEach(item => TeamsListView.Items.Add(item));

            }
            catch (Exception)
            {
                MessageBox.Show("Error finding teams");
            }
        }

        private void FindByTeamBtn_Click(object sender, EventArgs e)
        {
            DevelopersListView.Items.Clear();
            try
            {
                int teamid = int.Parse(FindByTeamNumberTxtB.Text); 
                AdminDevelopersController.FindDevelopersByTeam(Unit, teamid).ForEach(item => DevelopersListView.Items.Add(item));
            }
            catch (Exception)
            {

                MessageBox.Show("Error finding dev");
            }
        }

        private void FindByIdBtn_Click(object sender, EventArgs e)
        {
            DevelopersListView.Items.Clear();
            try
            {
                AdminDevelopersController.FindDeveloperById(Unit, FindByIdTxtB.Text).ForEach(item => DevelopersListView.Items.Add(item));
            }
            catch (Exception)
            {

                MessageBox.Show("Error finding dev");
            }
        }

        private void AddDevToTeam_Click(object sender, EventArgs e)
        {
            try
            {
                AdminDevelopersController.AddDevToTeam(Unit,SelectedDeveloper.Developer_Id, SelectedTeam.Team_ID); 

            }
            catch (Exception)
            {
                MessageBox.Show("Error adding Dev to team"); 
            }
        }

        private void DeleteDevFromTeam_Click(object sender, EventArgs e)
        {
            try
            {
                AdminDevelopersController.RemoveDevFromTeam(Unit, SelectedDeveloper.Developer_Id, SelectedTeam.Team_ID);
            }
            catch (Exception)
            {

                MessageBox.Show("Error Deleting Dev from team");

            }
        }
        private void FindByTeamNumberTxtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void DevelopersListView_ItemActivate(object sender, EventArgs e)
        {

            ListViewItem Item = new ListViewItem();
            try
            {
                Item = DevelopersListView.GetItemAt(MousePosition.X - 277, MousePosition.Y - 236);
                SelectedDeveloper = new Developers()
                {
                    Developer_Id = Item.SubItems[0].Text,
                };
                MessageBox.Show("Selected Developer: " + SelectedDeveloper.Developer_Id);
                TeamsListView.Items.Clear();
                
                AdminDevelopersController.FindTeamsByDeveloper(Unit, SelectedDeveloper.Developer_Id).ForEach(item => TeamsListView.Items.Add(item));

            }
            catch (Exception)
            {
                MessageBox.Show("Error getting selected item from database, please try again later ");
            }
        }

        private void TeamsListView_ItemActivate(object sender, EventArgs e)
        {

            ListViewItem Item = new ListViewItem();
            try
            {
                Item = TeamsListView.GetItemAt(MousePosition.X - 705, MousePosition.Y - 236);

                SelectedTeam = new Teams()
                {
                    Team_ID = int.Parse(Item.SubItems[0].Text),
                };
                MessageBox.Show("Selected Team: " + SelectedTeam.Team_ID);
                DevelopersListView.Items.Clear();
                AdminDevelopersController.FindDevelopersByTeam(Unit, SelectedTeam.Team_ID).ForEach(item => DevelopersListView.Items.Add(item));

            }
            catch (Exception)
            {

                MessageBox.Show("Error getting selected item from database, please try again later ");
            }
        }

        private void ShowALL_Click(object sender, EventArgs e)
        {
            LoadTeams();
            LoadDevelopers(); 
        }

        private void RemoveDevBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AdminDevelopersController.RemoveDev(Unit, SelectedDeveloper);
                LoadDevelopers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to remove this project {ex}");
            }
        }
        private void CreateTeamBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AdminDevelopersController.AddTeam(Unit,  "Senior1");
                LoadTeams();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable add this Team {ex}" );
            }
        }
        private void DevelopersListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            ListViewItem Item = new ListViewItem();
            try
            {
                Item = DevelopersListView.GetItemAt(MousePosition.X - 277, MousePosition.Y - 236);

                if (Item.Selected != false & Item.SubItems[0].Text  != SelectedDeveloper.Developer_Id)
                {
                    SelectedDeveloper = new Developers()
                    {
                        Developer_Id = Item.SubItems[0].Text,
                    };
                    MessageBox.Show("Selected Developer: " + SelectedDeveloper.Developer_Id);
                    TeamsListView.Items.Clear();

                    AdminDevelopersController.FindTeamsByDeveloper(Unit, SelectedDeveloper.Developer_Id).ForEach(item => TeamsListView.Items.Add(item));
                }
                else { return;  }
              
            }
            catch (Exception)
            {
                MessageBox.Show("Error getting selected item from database, please try again later ");
            }
        }

        private void DevelopersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
