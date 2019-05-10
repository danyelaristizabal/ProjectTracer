using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTracer.Controllers;
using ProjectTracer.Forms.AdminView;
using ProjectTracer.Models;
using static System.Windows.Forms.ListView;

namespace ProjectTracer.Forms
{
    public partial class ProjectsView : Form
    {
        private static List<Projects> ListOfProjects { get; set; }


        private Projects SelectedProject { get; set; }

        public ProjectsView()
        {
            SelectedProject = new Projects();
            InitializeComponent();
        }
        private void ProjectsView_Load(object sender, EventArgs e)
        {
            LoadProjects(); 
        }
        private void LoadProjects()
        {
            AdminProjectsView.Items.Clear(); 
            var context = new ProjectTracerEntities();
            List<Projects> ListOfProjects = context.Projects.ToList();
            foreach (var project in ListOfProjects)
            {
                ListViewItem item = new ListViewItem(project.Project_ID.ToString());
                item.SubItems.Add(project.Description.ToString());
                item.SubItems.Add(project.Team.ToString());
                item.SubItems.Add(project.DeadLine.ToString());
                item.SubItems.Add(project.Result.ToString());
                item.SubItems.Add(project.Client.ToString());
                AdminProjectsView.Items.Add(item);
            }
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var context = new ProjectTracerEntities();
            context.Projects.Attach(SelectedProject);
            context.Projects.Remove(SelectedProject);
            try
            {
                context.SaveChanges();
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString()); 
            }
             
            LoadProjects(); 
        }

        private void AdminProjectsView_ItemActivate(object sender, EventArgs e)
        {
            if (AdminProjectsView.GetItemAt(MousePosition.X - 288, MousePosition.Y -214) != null)
            {
                ListViewItem Item = AdminProjectsView.GetItemAt(MousePosition.X - 288, MousePosition.Y - 194);
                try
                {
                    SelectedProject = new Projects() {
                        Project_ID = Item.SubItems[0].Text,
                        Description = Item.SubItems[1].Text,
                        Team = Int32.Parse(Item.SubItems[2].Text),
                        DeadLine = DateTime.Parse(Item.SubItems[3].Text),
                        Result = Item.SubItems[4].Text,
                        Client = Item.SubItems[5].Text
                    };
                    
                    MessageBox.Show("Item Id:" + SelectedProject.Project_ID);
                }
                catch (Exception E)
                {
                    MessageBox.Show($"Error: {E} ");
                }
            }
            else {
                MessageBox.Show($"NUll");
            }
        }

        private void GenerateInvitationCodeBtn_Click(object sender, EventArgs e)
        {
            string Id = SelectedProject.Project_ID;
            string Pass = "a"; 
            Code.Text = Encrypt.EncryptString(Id, Pass);
            MessageBox.Show(Encrypt.DecryptString(Code.Text, Pass)); 
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var AddProjectForm = new AddProject();
            // Subscribe to event
            AddProjectForm.BoolRegisteredChanged += new EventHandler<BoolEvent>(AddProjectForm_BoolRegisteredChanged);
            AddProjectForm.ShowDialog();
            // Unsubscribe from event
            AddProjectForm.BoolRegisteredChanged -= AddProjectForm_BoolRegisteredChanged;
            AddProjectForm.Dispose();
            AddProjectForm = null;
        }
        private void AddProjectForm_BoolRegisteredChanged(object sender, BoolEvent e)
        {
            if (e.MyBool)
            {
                LoadProjects(); 
            }
        }

        private void FindById_Click(object sender, EventArgs e)
        {
            var context = new ProjectTracerEntities();
            var projects = context.Projects.ToList();
            var SearchedProject =  new Projects()
            {
                Project_ID = FindByIdTxtB.Text
            };

            AdminProjectsView.Items.Clear();
            foreach (var project in projects)
            {
                int Distance = LevenshteinDistance.Compute(SearchedProject.Project_ID, project.Project_ID); 
                if ( Distance <= 4  ) 
                {
                    ListViewItem item = new ListViewItem(project.Project_ID.ToString());
                    item.SubItems.Add(project.Description.ToString());
                    item.SubItems.Add(project.Team.ToString());
                    item.SubItems.Add(project.DeadLine.ToString());
                    item.SubItems.Add(project.Result.ToString());
                    item.SubItems.Add(project.Client.ToString());
                    AdminProjectsView.Items.Add(item);
                }
            }


        }
    }
}
