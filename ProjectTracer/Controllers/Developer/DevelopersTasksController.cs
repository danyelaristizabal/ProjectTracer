﻿using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProjectTracer.Models;
using ProjectTracer.Repository;

namespace ProjectTracer.Controllers
{
    public static class DevelopersTasksController
    {
        internal static List<ListViewItem> GetProjectsItemList(UnityOfWork unit, string developer_Id)
        {
            var teams = unit.Team
                        .GetAll()
                        .Where(T => T.Developer
                                     .Contains(unit.Developer.GetAll().FirstOrDefault(d => d.Id == developer_Id)));

            List<Project> ListOfProjects = new List<Project>();

            List<ListViewItem> ProjectsItemList = new List<ListViewItem>();

            foreach (var team in teams)
            {
                foreach (var project in team.Project)
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
            List<Task> ListOfTasks = unit.Task
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
            var teams = unit.Team
                        .GetAll()
                        .Where(
                                T => T.Developer
                                .Contains(unit.Developer.GetAll().FirstOrDefault(d => d.Id == developer_Id))
                               );

            List<Project> projects = new List<Project>(); 

            foreach (var team in teams)
            {
                foreach (var project in team.Project)
                {
                    if (!projects.Contains(project))
                    {
                        projects.Add(project);
                    }
                }
            }

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
                    ProjectsItemList.Add(item);
                }
            }
            return ProjectsItemList;
        }

        internal static bool TakeTask(UnityOfWork unit, Task selectedTask, Developer myDeveloper)
        {
            if (selectedTask.DeveloperOnTask == null)
            {
                var task = unit.Task.GetAll().FirstOrDefault(T => T.Task_Id == selectedTask.Task_Id);
                    task.DeveloperOnTask = myDeveloper.Id;
                unit.Complete();
                return true; 
            }
            
            return false;
        }



        internal static void FinishTask(UnityOfWork unit, Task selectedTask)
        {
            var task = unit.Task.GetAll().FirstOrDefault(T => T.Task_Id == selectedTask.Task_Id);
            task.Done = true;
            unit.Complete(); 

        }

        internal static bool ReleaseTask(UnityOfWork unit, Task selectedTask, Developer myDeveloper)
        {
            var task = unit.Task.GetAll().FirstOrDefault(T => T.Task_Id == selectedTask.Task_Id);
            task.DeveloperOnTask = null;
            unit.Complete();
            return (unit.Task.GetAll().FirstOrDefault(T => T.Task_Id == selectedTask.Task_Id).DeveloperOnTask == null);
        }
    }
}
