using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTracer.Repository;
using ProjectTracer.Controllers;
using ProjectTracer.Forms;
using ProjectTracer.Forms.AdminView;
using ProjectTracer.Models;

namespace ProjectTracer.Forms
{
    public partial class TasksView : Form
    {
        private Projects SelectedProject { get; set; }
        private Tasks SelectedTask { get; set; }
        public UnityOfWork Unit { get; set; }
        public TasksView()
        {
            InitializeComponent();
            Unit = new UnityOfWork(new ProjectTracerEntities());
            SelectedProject = new Projects();
            SelectedTask = new Tasks(); 
            LoadTasks();
            LoadProjects(); 
        }

        private void LoadProjects()
        {
            try
            {
                ProjectsViewList.Items.Clear();
                AdminTasksController.GetProjectsItemList(Unit).ForEach(item => ProjectsViewList.Items.Add(item));
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading the projects, please try again later");
            }
        }
        private void LoadTasks()
        {
            try
            {
                TasksViewList.Items.Clear();
                AdminTasksController.GetTasksItemList(Unit, SelectedProject.Project_ID).ForEach(item => TasksViewList.Items.Add(item));
            }
            catch (Exception)
            {
                MessageBox.Show("Erro loading tasks, please select a project");
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

        private void ProjectName_Click(object sender, EventArgs e)
        {

            ProjectsViewList.Items.Clear();
            try
            {
                AdminTasksController.GetProjectsByInput(Unit, InputTextBox.Text).ForEach(item => ProjectsViewList.Items.Add(item));
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

        private void DeleteTaskBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AdminTasksController.RemoveTask(Unit, SelectedTask);
                LoadProjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to remove this project");
            }
        }

        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var AddProjectForm = new AddTask(SelectedProject.Project_ID);

                AddProjectForm.BoolRegisteredChanged += new EventHandler<BoolEvent>(AddTaskForm_BoolRegisteredChanged);

                AddProjectForm.ShowDialog();

                AddProjectForm.BoolRegisteredChanged -= AddTaskForm_BoolRegisteredChanged;

                AddProjectForm.Dispose();

                AddProjectForm = null;

            }
            catch (Exception)
            {
                MessageBox.Show("Failed to add project"); 
            }
        }
        private void AddTaskForm_BoolRegisteredChanged(object sender, BoolEvent e)
        {
            if (e.MyBool) LoadTasks();
        }
        private void EditTaskBtn_Click(object sender, EventArgs e)
        {
            try
            {
                EditTask AddProjectForm;
                if (SelectedProject.Project_ID != null)
                    AddProjectForm = new EditTask(SelectedProject.Project_ID, SelectedTask.Task_Id);
                else
                {
                    MessageBox.Show("Select a task to edit first, and then click in the edit button");
                    return;
                }

                AddProjectForm.BoolRegisteredChanged += new EventHandler<BoolEvent>(AddTaskForm_BoolRegisteredChanged);

                AddProjectForm.ShowDialog();

                AddProjectForm.BoolRegisteredChanged -= AddTaskForm_BoolRegisteredChanged;

                AddProjectForm.Dispose();

                AddProjectForm = null;

            }
            catch (Exception)
            {
                MessageBox.Show("Failed to edit, try later"); 
            }
        }
    }
}
