using ProjectTracer.Controllers;
using ProjectTracer.Models;
using ProjectTracer.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTracer.Forms.AdminView
{
    public partial class EditTask : Form
    {
        public event EventHandler<BoolEvent> BoolRegisteredChangedE;
        public string Project_Id { get; set; }
        public int Task_Id { get; set; }
        public Task MyTask { get; set; }
        public UnityOfWork  unit { get; set; }

        private bool myBoolE;
        public bool MyBoolE
        {
            get { return myBoolE; }
            set
            {
                if (myBoolE != value)
                {
                    myBoolE = value;
                    OnBoolRegisteredChangedE(new BoolEvent(myBoolE));
                }
            }
        }
        protected virtual void OnBoolRegisteredChangedE(BoolEvent a)
        {
            EventHandler<BoolEvent> ah = BoolRegisteredChangedE;
            if (ah != null)
                ah(this, a);
        }
        public EditTask(string project_Id, int task_Id)
        {
            InitializeComponent();
            
            Project_Id = project_Id;
            
            unit = new UnityOfWork(new ProjectTracerEntities());
            try
            {
                MyTask = EditTaskController.GetTaskById(unit, Project_Id, task_Id);
                DescriptionTxtB.Text = MyTask.Description;

                string DateString = MyTask.DeadLine.Date.ToString();

                DeadLineTxtB.Text = DateString;  

            }
            catch (Exception)
            {
                MessageBox.Show("Error getting the task");
            }
           
            myBoolE = new bool();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var date = new DateTime(); 
            try
            {
             date = DateTime.Parse(DeadLineTxtB.Text.ToString()); 
            }
            catch (Exception)
            {

                MessageBox.Show("Incorrect DataTime Format");
            }
            var newMyTask = new Task()
            {
                Task_Id = MyTask.Task_Id, 
                Project_Id = MyTask.Project_Id,
                Description = DescriptionTxtB.Text,
                DeadLine = DateTime.Parse(DeadLineTxtB.Text)
            };
            
            try
            {
                EditTaskController.UpdateTask(unit, newMyTask);
            }
            catch (Exception)
            {
                MessageBox.Show($"Error ocurred saving changes");
            }
            MyBoolE = true;
            this.Close();
        }

    
        private void Minimizr_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Closr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Minimizr_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
