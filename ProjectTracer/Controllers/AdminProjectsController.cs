using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using ProjectTracer.Repository;
using ProjectTracer.Models; 

namespace ProjectTracer.Controllers
{
    public static class AdminProjectsController
    {
        public static List<ListViewItem> GetProjectsItemList(UnityOfWork unit)
        {
            List<Projects> ListOfProjects = unit.Projects.GetAll().ToList();

            List<ListViewItem> ProjectsItemList = new List<ListViewItem>(); 

            foreach (var project in ListOfProjects)
            {
                ListViewItem item = new ListViewItem(project.Project_ID.ToString());
                item.SubItems.Add(project.Description.ToString());
                item.SubItems.Add(project.DeadLine.ToString());
                item.SubItems.Add(project.Result.ToString());
                item.SubItems.Add(project.Client.ToString());
                ProjectsItemList.Add(item);
            }
            return ProjectsItemList;
        }

       public  static void RemoveProject(UnityOfWork unit,Projects project)
        {
            var ProjectToDelete = unit.Projects.GetAll().Where(searchedProject => searchedProject.Project_ID == project.Project_ID).FirstOrDefault();

            unit.Projects.Remove(ProjectToDelete);

            unit.Complete(); 
        }

        public static List<ListViewItem> GetProjectsByInput(UnityOfWork unit, string Input)
        {
            var projects = unit.Projects.GetAll();
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
                    item.SubItems.Add(project.Result.ToString());
                    item.SubItems.Add(project.Client.ToString());
                    ProjectsItemList.Add(item); 
                }
            }
            return ProjectsItemList;
        }

    }
}
