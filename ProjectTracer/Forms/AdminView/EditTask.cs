using ProjectTracer.Controllers;
using ProjectTracer.Models;
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

namespace ProjectTracer.Forms.AdminView
{
    public partial class EditTask : Form
    {
        public event EventHandler<BoolEvent> BoolRegisteredChanged;
        public string Project_Id { get; set; }
        public int Task_Id { get; set; }

        public Tasks MyTask { get; set; }
        public UnityOfWork  unit { get; set; }

        private bool myBool;
        public bool MyBool
        {
            get { return myBool; }
            set
            {
                if (myBool != value)
                {
                    myBool = value;
                    OnBoolRegisteredChanged(new BoolEvent(myBool));
                }
            }
        }

        protected virtual void OnBoolRegisteredChanged(BoolEvent e)
        {
            EventHandler<BoolEvent> eh = BoolRegisteredChanged;
            if (eh != null)
                eh(this, e);
        }

        public EditTask(string project_Id, int task_Id)
        {
            
            InitializeComponent();
            
            Project_Id = project_Id;
            
            unit = new UnityOfWork(new ProjectTracerEntities());
            try
            {
                MyTask = EditTaskController.GetTaskById(unit, Project_Id, task_Id);
                NameTxtB.Text = MyTask.Task_Id.ToString();
                DescriptionTxtB.Text = MyTask.Description;
                DeadLineTxtB.Text = MyTask.DeadLine.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error getting the task");

            }
           
            myBool = new bool();
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
             date = DateTime.Parse(DeadLineTxtB.Text); 
            }
            catch (Exception)
            {

                MessageBox.Show("Please add a correct");
            }
            var newMyTask = new Tasks()
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
            catch (Exception E)
            {
                MessageBox.Show($"Error ocurred saving changes:{E}");
            }
            MyBool = true;
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
