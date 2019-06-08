using System;
using System.Windows.Forms;
using ProjectTracer.Models;
using ProjectTracer.Forms;
using ProjectTracer.Controllers;

namespace ProjectTracer
{
    public partial class LogInView : Form
    {
        public IUser MyUser { get; set; }
        public Form MyBase { get; set; }
        public LogInView(IUser User)
        {
            
            InitializeComponent();
            MyUser = User;
        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            UserLbl.Text = MyUser.GetType().Name;
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            MyUser.Name = UserTxtB.Text;
            MyUser.Password = PasswordTxtB.Text;
            try
            {
                if (LogInControler.Autentificate(MyUser))
                {
                    var StartPage = LogInControler.ChooseStartPage(MyUser);
                    StartPage.Show();
                    this.Close();
                    base.Close(); 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect User or password");
            }
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            var myRegistration = new RegisterView(MyUser);
            myRegistration.Show();
            base.Close(); 
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
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }
    }
}
