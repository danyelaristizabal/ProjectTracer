using ProjectTracer.Controllers;
using ProjectTracer.Repository;
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
    public partial class AddTeam : Form
    {
        public UnityOfWork Unit { get; set; }

        public AddTeam()
        {
            InitializeComponent();
            Unit = new UnityOfWork(new ProjectTracerEntities());
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            var devId = DeveloperTxtB.Text;
            var SeniorId = SeniorTxtB.Text;
            try
            {
                AdminAddTeamController.RegistrateTeam(devId, SeniorId, Unit);
            }
            catch (Exception)
            {
                MessageBox.Show($"Error Saving, please try again later"); 
            }

            this.Close(); 
        }
    }
}
