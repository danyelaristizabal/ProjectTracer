﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjectTracer.Models;
using ProjectTracer.Forms;
using ProjectTracer.Forms.ClientView;
using ProjectTracer.Forms.DeveloperView;
using ProjectTracer.Forms.SeniorView;
using System.Windows.Forms;

namespace ProjectTracer.Controllers
{
    public static class LogInControler
    {
        public static bool CheckUser(IUser user)
        {
            SqlConnection sq = new SqlConnection($@"data source=DESKTOP-KGC5T7J;initial catalog=ProjectTracer; User Id={user.Name};
          Password={user.Password};");

            try
            {
                sq.Open();
                sq.Close();
                return true;
            }
            catch (Exception E)
            {
                MessageBox.Show($"Incorrect User Name or Password, Error:{E}");
                sq.Close();
                return false;
            }
        }
        public static Form ChooseStartPage(IUser user)
        {
            var StartPage = new Form();
            switch (user.GetType().Name)
            {
                case "Client":
                    StartPage = new ClientProjectsView();
                    break;
                case "Developer":
                    StartPage = new DeveloperProjectsView();
                    break;
                case "Senior":
                    StartPage = new SeniorProjectsView();
                    break;
                case "Admin":
                    StartPage = new ProjectsView();
                    break;
                default:
                    break;
            }
            return StartPage;
        }
    }
}