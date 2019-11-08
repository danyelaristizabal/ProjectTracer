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

namespace ProjectTracer.Forms.SeniorView
{
    public partial class SeniorDevelopersView : Form
    {
        public Senior MySenior { get; set; }

        private Team SelectedTeam { get; set; }
        private Developer SelectedDeveloper { get; set; }
        public UnityOfWork Unit { get; set; }
        public object SenioDevelopersController { get; private set; }

        public SeniorDevelopersView(Senior mySenior )
        {
            InitializeComponent();
            MySenior = mySenior;
            Unit = new UnityOfWork(new ProjectTracerEntities());
            SelectedTeam = new Team();
            SelectedDeveloper = new Developer();
            LoadTeams();
            LoadDevelopers();
        }
       
        private void LoadTeams()
        {
            try
            {
                TeamsListView.Items.Clear();
                SeniorDevelopersController.GetTeamsItemList(Unit, MySenior.Id).ForEach(item => TeamsListView.Items.Add(item));
            }
            catch (Exception )
            {
                MessageBox.Show("Error loading Teams:");
            }
        }

        private void LoadDevelopers()
        {
            try
            {
                DevelopersListView.Items.Clear();
                SeniorDevelopersController.GetDevelopersItemList(Unit, MySenior.Id).ForEach(item => DevelopersListView.Items.Add(item));
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading Developers, please select a Team");
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
            var projectsForm = new SeniorProjectsView(MySenior);
            projectsForm.Show();
            this.Close();
        }

        private void TasksBtn_Click(object sender, EventArgs e)
        {
            var tasksForm = new SeniorTasksView(MySenior);
            tasksForm.Show();
            this.Close();
        }

        private void ShowALL_Click(object sender, EventArgs e)
        {

        }

        private void DevelopersListView_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem Item = new ListViewItem();
            try
            {
                Item = DevelopersListView.GetItemAt(MousePosition.X - 277, MousePosition.Y - 236);

                
                    SelectedDeveloper = new Developer()
                    {
                        Id = Item.SubItems[0].Text,
                    };
                    MessageBox.Show("Selected Developer: " + SelectedDeveloper.Id);
                    TeamsListView.Items.Clear();

                    AdminDevelopersController.FindTeamsByDeveloper(Unit, SelectedDeveloper.Id).ForEach(item => TeamsListView.Items.Add(item));
                

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
                Item = TeamsListView.GetItemAt(MousePosition.X - 705, MousePosition.Y - 212);

                SelectedTeam = new Team()
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

        private void FindByIdBtn_Click(object sender, EventArgs e)
        {

            DevelopersListView.Items.Clear();
            try
            {
                SeniorDevelopersController.FindDeveloperById(Unit, FindByIdTxtB.Text, MySenior.Id).ForEach(item => DevelopersListView.Items.Add(item));
            }
            catch (Exception)
            {

                MessageBox.Show("Error finding dev");
            }
        }

        private void FindByTeamBtn_Click(object sender, EventArgs e)
        {
            DevelopersListView.Items.Clear();
            try
            {
                int teamid = int.Parse(FindByTeamNumberTxtB.Text);
                SeniorDevelopersController.FindDevelopersByTeam(Unit, teamid, MySenior.Id).ForEach(item => DevelopersListView.Items.Add(item));
            }
            catch (Exception)
            {

                MessageBox.Show("Error finding dev");
            }
        }

        private void RemoveDevBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AdminDevelopersController.RemoveDev(Unit, SelectedDeveloper);
                LoadDevelopers();
            }
            catch (Exception)
            {
                MessageBox.Show($"Unable to remove this Dev ");
            }
        }

        private void DeleteDevFromTeam_Click(object sender, EventArgs e)
        {
            try
            {
                AdminDevelopersController.RemoveDevFromTeam(Unit, SelectedDeveloper.Id, SelectedTeam.Team_ID);
            }
            catch (Exception)
            {

                MessageBox.Show("Error Deleting Dev from team");

            }
        }
    }
}
