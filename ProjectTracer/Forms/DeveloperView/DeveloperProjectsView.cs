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
        public DeveloperProjectsView()
        {
            InitializeComponent();
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
            var tasksForm = new DeveloperTasksView();
            tasksForm.Show();
            this.Close();
        }

        private void ProjectsBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeveloperProjectsView_Load(object sender, EventArgs e)
        {
            
        }

        private void ProjectsMaterialList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Load_Click(object sender, EventArgs e)
        {
            var context = new EntitiesProjectTracer();
            var x = context.Projects;
            List<Projects> z = x.ToList();
            ProjectsMaterialList.Items.Clear();
            foreach (Projects a in z)
            {
                ListViewItem item = new ListViewItem(a.Project_ID.ToString());
                item.SubItems.Add(a.Description.ToString());
                item.SubItems.Add(a.DeadLine.ToString());
                item.SubItems.Add(a.Result.ToString());
                ProjectsMaterialList.Items.Add(item);
            }

            ProjectsMaterialList.Refresh();
        }
    }
}
