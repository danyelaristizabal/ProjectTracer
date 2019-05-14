using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using ProjectTracer.Repository; 

namespace ProjectTracer.Controllers
{
    public static class AdminProjectsController
    {
        public static List<ListViewItem> GetProjectsItemList()
        {
            var unit = new UnityOfWork(new ProjectTracerEntities());
            
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

        public static bool RemoveProject(Projects project)
        {
            var unit = new UnityOfWork(new ProjectTracerEntities());
            try
            {
                unit.Projects.Remove(project);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }


    }
}
