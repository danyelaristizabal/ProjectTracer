using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
        private void RegisterView_Load(object sender, EventArgs e)
        {
            UserLbl.Text = User.GetType().Name;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            User.Name = NameTxtBox.Text;
            User.Password = PasswordTxtBox.Text;

            if (RegisterController.RegisterInServer(User) &
             RegisterController.RegisterInDatabase(User))
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
