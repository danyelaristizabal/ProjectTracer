﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTracer.Forms.SeniorView
{
    public partial class SeniorDevelopersView : Form
    {
        public SeniorDevelopersView()
        {
            InitializeComponent();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
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
        private void ProjectsBtn_Click(object sender, EventArgs e)
        {
            var projectsForm = new SeniorProjectsView();
            projectsForm.Show();
            this.Close();
        }

        private void TasksBtn_Click(object sender, EventArgs e)
        {
            var tasksForm = new SeniorTasksView();
            tasksForm.Show();
            this.Close();
        }
    }
}