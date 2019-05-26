using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTracer.Models;
using ProjectTracer.Repository;

namespace ProjectTracer.Controllers
{
    public static class SeniorProjectsController
    {
        internal static List<ListViewItem> GetProjectsItemList(UnityOfWork unit, string Senior_Id )
        {
            var teams = unit.Teams
                      .GetAll()
                      .Where(T => T.Seniors
                                   .Contains(unit.Seniors.GetAll().FirstOrDefault(s => s.Senior_Id == Senior_Id)));

            List<Projects> ListOfProjects = new List<Projects>();

            List<ListViewItem> ProjectsItemList = new List<ListViewItem>();

            foreach (var team in teams)
            {
                foreach (var project in team.Projects)
                {
                    ListViewItem item = new ListViewItem(project.Project_ID.ToString());
                    item.SubItems.Add(project.Description.ToString());
                    item.SubItems.Add(project.DeadLine.ToString());
                    ProjectsItemList.Add(item);
                }
            }
            return ProjectsItemList;
        }

        internal static List<ListViewItem> GetProjectsByInput(UnityOfWork unit, string Input, string senior_Id)
        {
            var teams = unit.Teams
                      .GetAll()
                      .Where(T => T.Seniors
                                   .Contains(unit.Seniors.GetAll().FirstOrDefault(s => s.Senior_Id == senior_Id)));

            List<Projects> projects = new List<Projects>();

            foreach (var team in teams)
            {
                foreach (var project in team.Projects)
                {
                    if (!projects.Contains(project))
                    {
                        projects.Add(project);
                    }
                }
            }

            List<ListViewItem> ProjectsItemList = new List<ListViewItem>();

            var SearchedProject = new Projects()
            {
                Project_ID = Input
            };

            foreach (var project in projects)
            {
                int Distance = LevenshteinDistance.Compute(SearchedProject.Project_ID, project.Project_ID);
                if (Distance <= 4)
                {
                    ListViewItem item = new ListViewItem(project.Project_ID.ToString());
                    item.SubItems.Add(project.Description.ToString());
                    item.SubItems.Add(project.DeadLine.ToString());
                    ProjectsItemList.Add(item);
                }
            }
            return ProjectsItemList;
        }
    }
}
