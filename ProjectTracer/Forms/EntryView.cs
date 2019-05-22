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
        public Form Base { get; set; }
        public EntryView(Form _Base )
        {
            Base = _Base; 
            InitializeComponent();
        }
        private void ClientBtn_Click(object sender, EventArgs e)
        {
              var myLogin = EntryController.GetLogIn("Client", Base);
              myLogin.Show(); 
              this.Close();
        }
        private void Developer_Click(object sender, EventArgs e)
        {
            var myLogin = EntryController.GetLogIn("Developer", Base);
            myLogin.Show(); 
            this.Close();
        }
        private void SeniorDevBtn_Click(object sender, EventArgs e)
        {
            var myLogin = EntryController.GetLogIn("Senior", Base);
            myLogin.Show();
            this.Close();
        }
        private void AdminBtn_Click(object sender, EventArgs e)
        {
            var myLogin = EntryController.GetLogIn("Admin", Base);
            myLogin.Show();
            this.Close();
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
