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
                if (project.Clients.Count > 0) item.SubItems.Add(project.Clients.FirstOrDefault().Client_Id); 
                ProjectsItemList.Add(item);
            }
            return ProjectsItemList;
        }

        public static void RemoveProject(UnityOfWork unit,Projects project)
        {
            var ProjectToDelete = unit.context
                .Projects
                .Include("Documents")
                .Include("Tasks")
                .FirstOrDefault(searchedProject => searchedProject.Project_ID == project.Project_ID);

            //var tasks = unit.context.Tasks
            //    .Where(t => t.Project_Id == ProjectToDelete.Project_ID)
            //    .ToList();

            //var documents = unit.context.Documents
            //    .Where(d => d.Project_Id == ProjectToDelete.Project_ID)
            //    .ToList();

            //unit.context.Teams
            //    .Where(t => t.Projects.Contains(ProjectToDelete))
            //    .ToList()
            //    .ForEach(t => t.Projects.Remove(ProjectToDelete));

            //unit.context.Clients
            //    .Where(c => c.Projects
            //    .Contains(ProjectToDelete))
            //    .ToList()
            //    .ForEach(c => c.Projects.Remove(ProjectToDelete));

            //unit.Documents.RemoveRange(documents);
            //unit.Tasks.RemoveRange(tasks);

            //unit.Complete();

            unit.context.Projects.Remove(ProjectToDelete);

            unit.context.SaveChanges(); 
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
                    if(project.Clients.Count > 0) item.SubItems.Add(project.Clients.FirstOrDefault().Client_Id);
                    ProjectsItemList.Add(item); 
                }
            }
            return ProjectsItemList;
        }

    }
}
