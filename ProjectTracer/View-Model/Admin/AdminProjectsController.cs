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
            List<Project> ListOfProjects = unit.Project.GetAll().ToList();

            List<ListViewItem> ProjectsItemList = new List<ListViewItem>(); 

            foreach (var project in ListOfProjects)
            {
                ListViewItem item = new ListViewItem(project.Project_ID.ToString());

                item.SubItems.Add(project.Description.ToString());

                item.SubItems.Add(project.DeadLine.ToString());

                item.SubItems.Add(project.Result.ToString());

                if (project.Client.Count > 0) item.SubItems.Add(project.Client.FirstOrDefault().Id); 

                ProjectsItemList.Add(item);
            }
            return ProjectsItemList;
        }
        public static List<ListViewItem> GetProjectsItemListIgnoreDeadLineAndClient(UnityOfWork unit)
        {
            List<Project> ListOfProjects = unit.Project.GetAll().ToList();

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

        public static void RemoveProject(UnityOfWork unit,Project project)
        {
            var ProjectToDelete = unit.context
                .Project
                .Include("Document")
                .Include("Task")
                .FirstOrDefault(searchedProject => searchedProject.Project_ID == project.Project_ID);

            var documents = unit.Document.GetAll()
                .Where(d => d.Project_Id == ProjectToDelete.Project_ID)
                .ToList();

            unit.Document.RemoveRange(documents);
            unit.Complete();

            var tasks = unit.context.Task
                .Where(t => t.Project_Id == ProjectToDelete.Project_ID)
                .ToList();

            unit.Task.RemoveRange(tasks);
            unit.Complete();

            unit.Team
                .GetAll()
                .Where(t => t.Project.Contains(ProjectToDelete))
                .ToList()
                .ForEach(t => t.Project.Remove(ProjectToDelete));

            unit.Complete();

            unit.Client
                .GetAll()
                .Where(c => c.Project
                .Contains(ProjectToDelete))
                .ToList()
                .ForEach(c => c.Project.Remove(ProjectToDelete));

            unit.Complete();

            unit.Project.Remove(ProjectToDelete);

            unit.Complete();
            MessageBox.Show("Project Deleted");
        }


        public static List<ListViewItem> GetProjectsByInput(UnityOfWork unit, string Input)
        {
            var projects = unit.Project.GetAll();
            List<ListViewItem> ProjectsItemList = new List<ListViewItem>();

            var SearchedProject = new Project()
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

                    if(project.Client.Count > 0) item.SubItems.Add(project.Client.FirstOrDefault().Id);

                    ProjectsItemList.Add(item); 
                }
            }
            return ProjectsItemList;
        }

    }
}
