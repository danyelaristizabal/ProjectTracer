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
using ProjectTracer.Controllers;
namespace ProjectTracer
{
    public partial class EntryView : Form
    {
        public EntryView()
        {
            InitializeComponent();
        }
        private void ClientBtn_Click(object sender, EventArgs e)
        {
              var myLogin = EntryController.GetLogIn("Client");
              myLogin.Show(); 
              this.Close();
        }
        private void Developer_Click(object sender, EventArgs e)
        {
            var myLogin = EntryController.GetLogIn("Developer");
            myLogin.Show(); 
            this.Close();
        }
        private void SeniorDevBtn_Click(object sender, EventArgs e)
        {
            var myLogin = EntryController.GetLogIn("Senior");
            myLogin.Show();
            this.Close();
        }
        private void AdminBtn_Click(object sender, EventArgs e)
        {
            var myLogin = EntryController.GetLogIn("Admin");
            myLogin.Show();
            this.Close();
        }
        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
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

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
