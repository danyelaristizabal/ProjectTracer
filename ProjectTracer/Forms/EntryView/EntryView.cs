using System;
using System.Windows.Forms;
using ProjectTracer.Controllers;
namespace ProjectTracer
{
    public partial class EntryView : Form
    {
        public EntryView( )
        {
            InitializeComponent();

        }
        private void ClientBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var myLogin = EntryController.GetLogIn("Client");

                myLogin.Show();

                this.Hide();

            }
            catch (Exception)
            {
                MessageBox.Show("Log in Error, please try later");
            }
        }
        private void Developer_Click(object sender, EventArgs e)
        {
            try
            {
                var myLogin = EntryController.GetLogIn("Developer");

                myLogin.Show();

                this.Hide();

            }
            catch (Exception)
            {
                MessageBox.Show("Log in Error, please try later"); 
            }
           
        }
        private void SeniorDevBtn_Click(object sender, EventArgs e)
        {

            try
            {
                var myLogin = EntryController.GetLogIn("Senior");

                myLogin.Show();

                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Log in Error, please try later");
            }
          
        }
        private void AdminBtn_Click(object sender, EventArgs e)
        {
          
            try
            {
                var myLogin = EntryController.GetLogIn("Admin");

                myLogin.Show();

                this.Hide();
            }
            catch (Exception)
            {

                MessageBox.Show("Log in Error, please try later");
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
