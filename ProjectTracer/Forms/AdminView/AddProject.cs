using System;
using System.Windows.Forms;
using ProjectTracer.Models;
using ProjectTracer.Controllers;


namespace ProjectTracer.Forms.AdminView
{
    public partial class AddProject : Form
    {
        public event EventHandler<BoolEvent> BoolRegisteredChanged;

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
            if(eh != null)
            eh(this, e);
        }
         public AddProject()
        {

            InitializeComponent();
            myBool = new bool(); 
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Closr_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddProjectController.AddProject(NameTxtB.Text, DescriptionTxtB.Text, DeadLineTxtB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error ocurred saving changes, please try later");
            }
            MyBool = true;
            this.Close(); 
        }

        private void Minimizr_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AddProject_Load(object sender, EventArgs e)
        {

        }
    }
}
