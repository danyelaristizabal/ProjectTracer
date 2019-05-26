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
    public static class DevelopersTasksController
    {
        internal static List<ListViewItem> GetProjectsItemList(UnityOfWork unit, string developer_Id)
        {
            var teams = unit.Teams
                        .GetAll()
                        .Where(T => T.Developers
                                     .Contains(unit.Developers.GetAll().FirstOrDefault(d => d.Developer_Id == developer_Id)));

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

        internal static List<ListViewItem> GetProjectsByInput(UnityOfWork unit, string Input, string developer_Id)
        {
            var teams = unit.Teams
                        .GetAll()
                        .Where(
                                T => T.Developers
                                .Contains(unit.Developers.GetAll().FirstOrDefault(d => d.Developer_Id == developer_Id))
                               );

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

        internal static bool TakeTask(UnityOfWork unit, Tasks selectedTask, Developers myDeveloper)
        {
            if (selectedTask.DeveloperOnTask == null)
            {
                var task = unit.Tasks.GetAll().FirstOrDefault(T => T.Task_Id == selectedTask.Task_Id);
                    task.DeveloperOnTask = myDeveloper.Developer_Id;
                unit.Complete();
                return true; 
            }
            
            return false;
        }



        internal static void FinishTask(UnityOfWork unit, Tasks selectedTask)
        {
            var task = unit.Tasks.GetAll().FirstOrDefault(T => T.Task_Id == selectedTask.Task_Id);
            task.Done = true;
            unit.Complete(); 

        }

        internal static bool ReleaseTask(UnityOfWork unit, Tasks selectedTask, Developers myDeveloper)
        {
            var task = unit.Tasks.GetAll().FirstOrDefault(T => T.Task_Id == selectedTask.Task_Id);
            task.DeveloperOnTask = null;
            unit.Complete();
            return (unit.Tasks.GetAll().FirstOrDefault(T => T.Task_Id == selectedTask.Task_Id).DeveloperOnTask == null);
        }
    }
}
