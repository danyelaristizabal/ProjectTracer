using ProjectTracer.Repository;
using System;
using System.Windows.Forms;

namespace ProjectTracer.Controllers
{
    public static class AddTaskController
    {
        public static bool AddTask( string descripton, string deadline, string project_Id)
        {
            if(project_Id == null)
            {
                MessageBox.Show("Not selected project");
                return false; 
            }
            var parseDeadLine = new DateTime();
            try
            {
                parseDeadLine = DateTime.Parse(deadline);
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect DeadLine");
                return false;
            }
            var unit = new UnityOfWork(new ProjectTracerEntities());
            unit.Task.Add(new Task()
            {
                Description = descripton,
                DeadLine = parseDeadLine,
                Project_Id = project_Id
            });
            try
            {
                unit.Complete();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error ocurred saving changes, please try later");
                return false;
            }
        }
    }
}
