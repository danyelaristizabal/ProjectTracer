using System;
using System.Windows.Forms;
using ProjectTracer.Repository; 
using ProjectTracer.Controllers;
using ProjectTracer.Forms.AdminView;
using ProjectTracer.Models;

namespace ProjectTracer.Forms
{
    public partial class ProjectsView : Form
    {
        private Project SelectedProject { get; set; }
        private UnityOfWork Unit { get; set;  } 
        public ProjectsView()
        {
            SelectedProject = new Project();
            Unit = new UnityOfWork(new ProjectTracerEntities()); 
            InitializeComponent();
        }
        private void ProjectsView_Load(object sender, EventArgs e)
        {
            LoadProjects(); 
        }
        private void LoadProjects()
        {
            try
            {
                AdminProjectsView.Items.Clear();

                AdminProjectsController.GetProjectsItemList(Unit).ForEach(item => AdminProjectsView.Items.Add(item));
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading the projects, please try again later");
            }
            
        }
        
        private void AdminProjectsView_ItemActivate(object sender, EventArgs e)
        {
            if (AdminProjectsView.GetItemAt(MousePosition.X - 288, MousePosition.Y -214) != null)
            {
                ListViewItem Item = new ListViewItem(); 
                try
                {
                     Item = AdminProjectsView.GetItemAt(MousePosition.X - 288, MousePosition.Y - 194);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error getting selected item from database, please try again later ");
                }

                SelectedProject = new Project() {

                Project_ID = Item.SubItems[0].Text,

                Description = Item.SubItems[1].Text,

                DeadLine = DateTime.Parse(Item.SubItems[2].Text),

                Result = Item.SubItems[3].Text,


                };
                MessageBox.Show("Selected project: " + SelectedProject.Project_ID);
            }
            else
            {
                MessageBox.Show("Please, Select a project by double clicking on it");
            }
        }

        private void GenerateInvitationCodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Id = SelectedProject.Project_ID;

                Code.Text = Encrypt.EncryptString(Id, "Pass");
                Clipboard.SetText(Code.Text);
                MessageBox.Show("Coppied to clipboard ");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to generate invitation code"); 
            }
             
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var AddProjectForm = new AddProject();

            AddProjectForm.BoolRegisteredChanged += new EventHandler<BoolEvent>(AddProjectForm_BoolRegisteredChanged);

            AddProjectForm.ShowDialog();

            AddProjectForm.BoolRegisteredChanged -= AddProjectForm_BoolRegisteredChanged;

            AddProjectForm.Dispose();

            AddProjectForm = null;
        }
        private void AddProjectForm_BoolRegisteredChanged(object sender, BoolEvent e)
        {
            if (e.MyBool) LoadProjects(); 
        }
        private void FindById_Click(object sender, EventArgs e)
        {
            AdminProjectsView.Items.Clear();
            AdminProjectsController.GetProjectsByInput(Unit,FindByIdTxtB.Text).ForEach(item => AdminProjectsView.Items.Add(item));
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
                System.Windows.Forms.Application.Exit();
            else
                System.Environment.Exit(1);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AdminProjectsController.RemoveProject(Unit, SelectedProject);
                LoadProjects();
            }
            catch (Exception)
            {
                MessageBox.Show($"Unable to remove project:" );
            } 
        }
    }
}
