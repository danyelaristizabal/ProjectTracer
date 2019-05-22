using ProjectTracer.Models;
using ProjectTracer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTracer.Controllers
{
    public static class AdminTasksController
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
                ProjectsItemList.Add(item);
            }
            return ProjectsItemList;
        }

        public static List<ListViewItem> GetTasksItemList(UnityOfWork unit, string project_Id)
        {
            List<ListViewItem> ProjectsItemList = new List<ListViewItem>();
            if (project_Id == string.Empty)
            {
                return  ProjectsItemList; 
            }
            List<Tasks> ListOfTasks = unit.Tasks.GetAll().Where(searchedtask => searchedtask.Project_Id == project_Id).ToList();

            

            foreach (var task in ListOfTasks)
            {
                ListViewItem item = new ListViewItem(task.Task_Id.ToString());
                item.SubItems.Add(task.Description.ToString());
                item.SubItems.Add(task.DeadLine.ToString());
                ProjectsItemList.Add(item);
            }
            return ProjectsItemList;
        }
        public static void RemoveTask(UnityOfWork unit, Tasks Tasks)
        {
            var taskToDelete = unit.Tasks.GetAll().Where(SearchedTask => SearchedTask.Task_Id == Tasks.Task_Id).FirstOrDefault();

            unit.Tasks.Remove(taskToDelete);

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
                    ProjectsItemList.Add(item);
                }
            }
            return ProjectsItemList;
        }
    }
}
