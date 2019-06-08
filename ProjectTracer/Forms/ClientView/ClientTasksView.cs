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
    public partial class ClientTasksView : Form
    {
        public Clients MyClient { get; set; }
        public Projects SelectedProject { get; set; }
        public UnityOfWork Unit { get; set; }
        public Tasks SelectedTask  { get; set; }

        public ClientTasksView(Clients myClient)
        {
            InitializeComponent();

            Unit = new UnityOfWork(new ProjectTracerEntities()); 
            SelectedTask = new Tasks(); 
            MyClient = myClient;
            try
            {
                SelectedProject = Unit.Projects
                .GetAll()
                .FirstOrDefault(p => p.Clients
                                       .Contains(Unit.Clients
                                                      .GetAll()
                                                      .FirstOrDefault(c => c.Client_Id == myClient.Client_Id)));
                LoadProjects();
                LoadTasks();
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading data "); 
            }
            
        }
        private void LoadProjects()
        {
            try
            {

                ProjectsViewList.Items.Clear();
                ClientTasksController.GetProjectsItemList(Unit, MyClient.Client_Id).ForEach(item => ProjectsViewList.Items.Add(item));
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading the projects, please try again later: ");
            }
        }
        private void LoadTasks()
        {
            try
            {
                TasksViewList.Items.Clear();
                ClientTasksController.GetTasksItemList(Unit, SelectedProject.Project_ID).ForEach(item => TasksViewList.Items.Add(item));
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading tasks, please select a project");
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


        private void DevelopersBtn_Click(object sender, EventArgs e)
        {
            var developersForm = new ClientDevelopersView(MyClient);
            developersForm.Show();
            this.Close();
        }

        private void ProjectName_Click(object sender, EventArgs e)
        {
            ProjectsViewList.Items.Clear();
            try
            {
                ClientTasksController.GetProjectsByInput(Unit, InputTextBox.Text, MyClient.Client_Id).ForEach(item => ProjectsViewList.Items.Add(item));
            }
            catch (Exception)
            {

                MessageBox.Show("Error loading projects from Database");
            }
        }

        private void ProjectsViewList_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem Item = new ListViewItem();
            try
            {
                Item = ProjectsViewList.GetItemAt(MousePosition.X - 288, MousePosition.Y - 194);
                SelectedProject = new Projects()
                {
                    Project_ID = Item.SubItems[0].Text,

                    Description = Item.SubItems[1].Text,

                    DeadLine = DateTime.Parse(Item.SubItems[2].Text),
                };
                MessageBox.Show("Selected project: " + SelectedProject.Project_ID);
                LoadTasks();
            }
            catch (Exception)
            {

                MessageBox.Show("Error getting selected item from database, please try again later ");
            }
        }

        private void TasksViewList_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem Item = new ListViewItem();
            try
            {
                Item = TasksViewList.GetItemAt(MousePosition.X - 707, MousePosition.Y - 194);
                SelectedTask = new Tasks()
                {
                    Task_Id = int.Parse(Item.SubItems[0].Text),

                    Description = Item.SubItems[1].Text,

                    DeadLine = DateTime.Parse(Item.SubItems[2].Text),
                };
                MessageBox.Show("Selected Task: " + SelectedTask.Task_Id);
            }
            catch (Exception)
            {
                MessageBox.Show("Error getting selected item from database, please try again later ");
            }
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
