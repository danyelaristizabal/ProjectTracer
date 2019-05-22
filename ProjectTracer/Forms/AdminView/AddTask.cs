using ProjectTracer.Controllers;
using ProjectTracer.Models;
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
    public partial class AddTask : Form
    {
        public event EventHandler<BoolEvent> BoolRegisteredChanged;
        public string Project_Id { get; set; }

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

        public AddTask(string project_Id)
        {
            Project_Id = project_Id; 
            InitializeComponent();
            myBool = new bool();
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddTaskController.AddTask(NameTxtB.Text, DescriptionTxtB.Text, DeadLineTxtB.Text, Project_Id);
            }
            catch (Exception)
            {
                MessageBox.Show("Error ocurred saving changes, please try later");
            }
            MyBool = true;
            this.Close();
        }

        private void Closr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizr_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
