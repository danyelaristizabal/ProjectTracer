using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTracer.Models;
using ProjectTracer.Forms;
using ProjectTracer.Controllers;

namespace ProjectTracer
{
    public partial class LogInView : Form
    {
        public IUser myUser { get; set; }
        public LogInView(IUser User)
        {
            InitializeComponent();
            myUser = User; 
           
        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            UserLbl.Text = myUser.GetType().Name;
        }

        private void UserTxtB_TextChanged(object sender, EventArgs e)
        {

        }
        private void PasswordTxtB_TextChanged(object sender, EventArgs e)
        {

        }
        private void LogInBtn_Click(object sender, EventArgs e)
        {
            myUser.Name = UserTxtB.Text;
            myUser.Password = PasswordTxtB.Text; 
            if (LogInControler.CheckUser(myUser))
            {
                MessageBox.Show("Correct User and password");
                var baseForm = new BaseView();
                baseForm.Show(); 
                var StartPage = LogInControler.ChooseStartPage(myUser);
                StartPage.Show();
                this.Close(); 
            } 
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            var myRegistration = new RegisterView(myUser);
            myRegistration.Show();
            this.Close(); 
        }
        private void UserLbl_Click(object sender, EventArgs e)
        {

        }
        private void Minimizr_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Closr_Click(object sender, EventArgs e)
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
    }
}
