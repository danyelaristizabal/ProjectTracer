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
    public static class ClientTasksController
    {
        internal static List<ListViewItem> GetProjectsItemList(UnityOfWork unit, string client_Id)
        {
            List<Projects> ListOfProjects = unit.Projects
                                            .GetAll()
                                            .Where(P => P.Clients
                                                         .Contains(unit.Clients.GetAll().FirstOrDefault(c => c.Client_Id == client_Id))
                                                  )
                                            .ToList();
                    
            List<ListViewItem> ProjectsItemList = new List<ListViewItem>();

            foreach (var project in ListOfProjects)
            {
                ListViewItem item = new ListViewItem(project.Project_ID.ToString());
                item.SubItems.Add(project.Description.ToString());
                item.SubItems.Add(project.DeadLine.ToString());
                ProjectsItemList.Add(item);
            }
            return ProjectsItemList;
        }

        internal static List<ListViewItem> GetTasksItemList(UnityOfWork unit, string project_ID)
        {
            List<ListViewItem> ProjectsItemList = new List<ListViewItem>();
            if (project_ID == string.Empty)
            {
                return ProjectsItemList;
            }
            List<Tasks> ListOfTasks = unit.Tasks
                .GetAll()
                .Where(searchedtask => searchedtask.Project_Id == project_ID)
                .ToList();

            foreach (var task in ListOfTasks)
            {
                ListViewItem item = new ListViewItem(task.Task_Id.ToString());
                item.SubItems.Add(task.Description.ToString());
                item.SubItems.Add(task.DeadLine.ToString());
                ProjectsItemList.Add(item);
            }
            return ProjectsItemList;
        }

        internal static List<ListViewItem> GetProjectsByInput(UnityOfWork unit, string Input, string client_Id)
        {
            var projects = unit.Projects
                .GetAll()
                .Where(P => P.Clients.Contains(unit.Clients.GetAll().FirstOrDefault(c => c.Client_Id == client_Id)));

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
