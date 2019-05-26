using ProjectTracer.Controllers;
using ProjectTracer.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjectTracer.Forms.DeveloperView
{
    public partial class DeveloperTasksView : Form
    {
        public Developers MyDeveloper { get; set; }
        public Projects SelectedProject { get; set; }
        public UnityOfWork Unit { get; set; }
        public Tasks SelectedTask { get; set; }
        public DeveloperTasksView(Developers myDeveloper)
        {
            InitializeComponent();
            MyDeveloper = myDeveloper;
            Unit = new UnityOfWork(new ProjectTracerEntities());
            try
            {
                SelectedProject = Unit.Teams
                   .GetAll()
                   .Where(t => t.Developers.Contains(Unit.Developers.GetAll().FirstOrDefault(d => d.Developer_Id == myDeveloper.Developer_Id)))
                   .FirstOrDefault()
                   .Projects
                   .FirstOrDefault();

            }
            catch (Exception)
            {
                MessageBox.Show("No tasks to do, go grab some snack and rest"); 
            }
            LoadProjects();
        }
        private void LoadProjects()
        {
            try
            {

                ProjectsViewList.Items.Clear();
                DevelopersTasksController.GetProjectsItemList(Unit, MyDeveloper.Developer_Id).ForEach(item => ProjectsViewList.Items.Add(item));
            }
            catch (Exception E)
            {
                MessageBox.Show("Error loading the projects, please try again later: " + E.ToString());
            }
        }
        private void LoadTasks()
        {
            try
            {
                TasksViewList.Items.Clear();
                DevelopersTasksController.GetTasksItemList(Unit, SelectedProject.Project_ID).ForEach(item => TasksViewList.Items.Add(item));
            }
            catch (Exception E)
            {
                MessageBox.Show("Error loading tasks, please select a project" + E.ToString());
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
            var projectsForm = new DeveloperProjectsView(MyDeveloper);
            projectsForm.Show();
            this.Close();
        }

        private void ProjectName_Click(object sender, EventArgs e)
        {
            ProjectsViewList.Items.Clear();
            try
            {
                DevelopersTasksController.GetProjectsByInput(Unit, InputTextBox.Text, MyDeveloper.Developer_Id).ForEach(item => ProjectsViewList.Items.Add(item));
            }
            catch (Exception)
            {

                MessageBox.Show("Error loading projects from Database");
            }
        }

        private void TakeTaskBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DevelopersTasksController.TakeTask(Unit, SelectedTask, MyDeveloper))
                {
                    MessageBox.Show("Task taked succesfully");
                }
                else
                {
                    MessageBox.Show("Task have been already taken, choose another one");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error taken task, please try later");
            }
        }

        private void ReleaseTaskBttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DevelopersTasksController.ReleaseTask(Unit, SelectedTask, MyDeveloper))
                {
                    MessageBox.Show("Released taked succesfully");
                }
                else
                {
                    MessageBox.Show("Task wasnt released, please try later");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error taken task, please try later");
            }

        }

        private void FinishTask_Click(object sender, EventArgs e)
        {
            try
            {
                DevelopersTasksController.FinishTask(Unit, SelectedTask); 
            }
            catch (Exception)
            {
                MessageBox.Show("Error taken task, please try later");
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
                Item = TasksViewList.GetItemAt(MousePosition.X - 707, MousePosition.Y - 178);
                SelectedTask = Unit.Tasks.GetAll().FirstOrDefault(T => T.Task_Id == int.Parse(Item.SubItems[0].Text));

                MessageBox.Show("Selected Task: " + SelectedTask.DeveloperOnTask);
            }
            catch (Exception r)
            {
                MessageBox.Show("Error getting selected item from database, please try again later "+ r.ToString());
            }
        }
    }
}
