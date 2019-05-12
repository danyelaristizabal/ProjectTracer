using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace ProjectTracer.Controllers
{
    public static class AdminProjectsController
    {
        public static List<List<string>> GetProjects()
        {
            var context = new ProjectTracerEntities();

            var x = context.Projects;

            List<Projects> ListOfProjects = x.ToList();

            var projectsTables = new List<List<string>>();

            foreach (Projects project in ListOfProjects)
            {
                projectsTables.Add(new List<string>() {
                 project.Description.ToString(), 
                project.DeadLine.ToString(),project.Result.ToString(),
                project.Client.ToString(),project.Project_ID.ToString(),
                }); 
            }
            return projectsTables;  
        }
    }
}
