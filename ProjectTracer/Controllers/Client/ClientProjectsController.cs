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
    public static class ClientProjectsController
    {
        internal static List<ListViewItem> GetProjectsItemList(UnityOfWork unit, string client_Id )
        {
            List<Projects> ListOfProjects = unit.Projects
                .GetAll()
                .Where(p => p.Clients.Contains(
                    unit.Clients.GetAll().FirstOrDefault(c => c.Client_Id == client_Id))
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
            var projects = unit.Projects
                .GetAll()
                .Where(p => p.Clients.Contains(
                    unit.Clients.GetAll().FirstOrDefault(c => c.Client_Id == client_Id))
                    );

            List<ListViewItem> ProjectsItemList = new List<ListViewItem>();

            var SearchedProject = new Projects()
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
                    if (project.Clients.Count > 0) item.SubItems.Add(project.Clients.FirstOrDefault().Client_Id);
                    ProjectsItemList.Add(item);
                }
            }
            return ProjectsItemList;
        }
    }
}
