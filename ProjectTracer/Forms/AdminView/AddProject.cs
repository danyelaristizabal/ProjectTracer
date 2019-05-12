using System;
using System.Windows.Forms;
using ProjectTracer.Models; 

namespace ProjectTracer.Forms.AdminView
{
    public partial class AddProject : Form
    {
        public event EventHandler<BoolEvent> BoolRegisteredChanged;
        private bool myBool;

        
        public bool MyBool
        {
            get { return myBool; }
            /* Setting this property will raise the event if the value is different.
             * As this property has a public getter you can access it and raise the
             * event from any reference to this class. in this example it is set from
             * the textBox.TextChanged handler above. The setter can be marked as
             * as private if required. */
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
            // Create a copy of the event to work with
            EventHandler<BoolEvent> eh = BoolRegisteredChanged;
            /* If there are no subscribers, eh will be null so we need to check
             * to avoid a NullReferenceException. */
            if (eh != null)
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
            var context = new ProjectTracerEntities();
            context.Projects.Add(new Projects()
            {
                Project_ID = NameTxtB.Text,
                Description = DescriptionTxtB.Text,
                DeadLine = DateTime.Parse(DeadLineTxtB.Text),
                Result = "Not Registered yet",
                Client = "Not Registered yet"
            });
            try
            {
                context.SaveChanges();

            }
            catch (Exception E)
            {
                MessageBox.Show($"{E}"); 
            }
            
            MyBool = true;
            this.Close(); 
        }

        private void Minimizr_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
