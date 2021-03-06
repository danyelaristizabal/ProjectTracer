﻿using ProjectTracer.Controllers;
using ProjectTracer.Forms.AdminView;
using ProjectTracer.Models;
using ProjectTracer.Repository;
using System;
using System.Windows.Forms;

namespace ProjectTracer.Forms.SeniorView
{
    public partial class SeniorTasksView : Form
    {
        private Project SelectedProject { get; set; }
        private Task SelectedTask { get; set; }
        public UnityOfWork Unit { get; set; }
        public Senior  MySenior { get; set; }
        public SeniorTasksView(Senior mySenior )
        {
            InitializeComponent();
            MySenior = mySenior;
            Unit = new UnityOfWork(new ProjectTracerEntities());
            SelectedProject = new Project();
            SelectedTask = new Task();
            LoadTasks();
            LoadProjects();
        }

        private void LoadProjects()
        {
            try
            {
                ProjectsViewList.Items.Clear();
                SeniorTasksController.GetProjectsItemList(Unit, MySenior.Id).ForEach(item => ProjectsViewList.Items.Add(item));
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
                SeniorTasksController.GetTasksItemList(Unit, SelectedProject.Project_ID).ForEach(item => TasksViewList.Items.Add(item));
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
            var projectsForm = new SeniorProjectsView(MySenior);
            projectsForm.Show();
            this.Close();
        }
        private void DevelopersBtn_Click(object sender, EventArgs e)
        {
            var developersForm = new SeniorDevelopersView(MySenior);
            developersForm.Show();
            this.Close();
        }

        private void ProjectName_Click(object sender, EventArgs e)
        {
            ProjectsViewList.Items.Clear();
            TasksViewList.Items.Clear();
            try
            {
                SeniorTasksController.GetProjectsByInput(Unit, InputTextBox.Text, MySenior.Id).ForEach(item => ProjectsViewList.Items.Add(item));
            }
            catch (Exception)
            {

                MessageBox.Show("Error loading projects from Database");
            }
        }

        private void DeleteTaskBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AdminTasksController.RemoveTask(Unit, SelectedTask);
                LoadProjects();
                LoadTasks();
            }
            catch (Exception)
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

        private void EditTaskBtn_Click(object sender, EventArgs e)
        {
            try
            {
                EditTask EditTaskForm;
                if (SelectedProject.Project_ID != null)
                    EditTaskForm = new EditTask(SelectedProject.Project_ID, SelectedTask.Task_Id);
                else
                {
                    MessageBox.Show("Select a task to edit first, and then click in the edit button");
                    return;
                }

                EditTaskForm.BoolRegisteredChangedE += new EventHandler<BoolEvent>(EditTaskForm_BoolRegisteredChangedE);

                EditTaskForm.ShowDialog();

                EditTaskForm.BoolRegisteredChangedE -= EditTaskForm_BoolRegisteredChangedE;

                EditTaskForm.Dispose();

                EditTaskForm = null;

            }
            catch (Exception)
            {
                MessageBox.Show("Failed to edit, try later");
            }
        }

        private void AddTaskForm_BoolRegisteredChanged(object sender, BoolEvent e)
        {
            if (e.MyBool)
            {
                LoadTasks();
                LoadProjects();
            }
        }

        private void EditTaskForm_BoolRegisteredChangedE(object sender, BoolEvent e)
        {
            if (e.MyBool)
            {
                LoadTasks();
                LoadProjects();
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            var tasksForm = new SeniorTasksView(MySenior);
            tasksForm.Show();
            this.Close();
        }

        private void ProjectsViewList_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem Item = new ListViewItem();
            try
            {
                Item = ProjectsViewList.GetItemAt(MousePosition.X - 288, MousePosition.Y - 194);
                SelectedProject = new Project()
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
                SelectedTask = new Task()
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
    }
}
