using System;
using System.Windows.Forms;
using ProjectTracer.Models;
using ProjectTracer.Controllers;

namespace ProjectTracer.Forms
{
    public partial class RegisterView : Form
    {
        public IUser User { get; set; }
        public RegisterView(IUser myUser) 
        {
            InitializeComponent();
            User = myUser;

            if (User.GetType().Name == "Senior" || User.GetType().Name == "Admin")
            {
                RegistrtionCodeTxtB.Visible = false;
                InvitationCodelbl.Visible = false;
                richTextBox4.Visible = false;
            }
        }
        private void RegisterView_Load(object sender, EventArgs e)
        {
            UserLbl.Text = User.GetType().Name;
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            User.Name = NameTxtBox.Text;
            User.Password = PasswordTxtBox.Text;
            User.InvitationCode = RegistrtionCodeTxtB.Text; 
            
            
            if (RegisterController.Registrate(User))
            {
                var startForm = LogInControler.ChooseStartPage(User);
                startForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error, please try again");
            } 
        }
        private void Minimizr_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Closr_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }
    }
}
