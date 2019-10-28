using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProjectTracer.Models;
using ProjectTracer.Repository;

namespace ProjectTracer.Controllers
{
    public static class ClientProjectsController
    {
        internal static List<ListViewItem> GetProjectsItemList(UnityOfWork unit, string client_Id )
        {
            List<Project> ListOfProjects = unit.Project
                .GetAll()
                .Where(p => p.Client.Contains(
                    unit.Client.GetAll().FirstOrDefault(c => c.Id == client_Id))
                    ).ToList();

            List<ListViewItem> ProjectsItemList = new List<ListViewItem>();

            foreach (var project in ListOfProjects)
            {
                ListViewItem item = new ListViewItem(project.Project_ID.ToString());
                item.SubItems.Add(project.Description.ToString());
                item.SubItems.Add(project.DeadLine.ToString());
                item.SubItems.Add(project.Result.ToString());
                ProjectsItemList.Add(item);
            }
            return ProjectsItemList;
        }

        internal static List<ListViewItem> GetProjectsByInput(UnityOfWork unit, string text, string client_Id)
        {
            var projects = unit.Project
                .GetAll()
                .Where(p => p.Client.Contains(
                    unit.Client.GetAll().FirstOrDefault(c => c.Id == client_Id))
                    );

            List<ListViewItem> ProjectsItemList = new List<ListViewItem>();

            var SearchedProject = new Project()
            {
                Project_ID = text
            };

            foreach (var project in projects)
            {
                int Distance = LevenshteinDistance.Compute(SearchedProject.Project_ID, project.Project_ID);
                if (Distance <= 4)
                {
                    ListViewItem item = new ListViewItem(project.Project_ID.ToString());
                    item.SubItems.Add(project.Description.ToString());
                    item.SubItems.Add(project.DeadLine.ToString());
                    item.SubItems.Add(project.Result.ToString());
                    if (project.Client.Count > 0) item.SubItems.Add(project.Client.FirstOrDefault().Id);
                    ProjectsItemList.Add(item);
                }
            }
            return ProjectsItemList;
        }
    }
}
