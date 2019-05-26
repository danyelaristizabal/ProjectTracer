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

namespace ProjectTracer.Forms.DeveloperView
{

    public partial class DeveloperProjectsView : Form
    {
        public UnityOfWork Unit { get; set; }
        public Developers MyDeveloper { get; set; }
        public DeveloperProjectsView(Developers myDeveloper)
        {
            InitializeComponent();
            MyDeveloper = myDeveloper;
            Unit = new UnityOfWork(new ProjectTracerEntities()); 
            LoadProjects(); 
        }
        private void LoadProjects()
        {
            try
            {

                ProjectsView.Items.Clear();
                DevelopersTasksController.GetProjectsItemList(Unit, MyDeveloper.Developer_Id).ForEach(item => ProjectsView.Items.Add(item));
            }
            catch (Exception E)
            {
                MessageBox.Show("Error loading the projects, please try again later: " + E.ToString());
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
            var tasksForm = new DeveloperTasksView(MyDeveloper);
            tasksForm.Show();
            this.Close();
        }

        private void FindById_Click(object sender, EventArgs e)
        {
            ProjectsView.Items.Clear();
            try
            {
                DevelopersTasksController.GetProjectsByInput(Unit, FindByIdTxtB.Text, MyDeveloper.Developer_Id).ForEach(item => ProjectsView.Items.Add(item));
            }
            catch (Exception)
            {

                MessageBox.Show("Error loading projects from Database");
            }
        }

        private void ProjectsBtn_Click(object sender, EventArgs e)
        {

        }
    }
}