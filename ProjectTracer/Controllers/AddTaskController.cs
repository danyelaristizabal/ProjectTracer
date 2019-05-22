using ProjectTracer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTracer.Controllers
{
    public static class AddTaskController
    {
        public static bool AddTask(string id, string descripton, string deadline, string project_Id)
        {
            if(project_Id == null)
            {
                MessageBox.Show("Not selected project");
                return false; 
            }
            var parseDeadLine = new DateTime();
            var parseId = new int();
            try
            {
                parseDeadLine = DateTime.Parse(deadline);
                parseId = int.Parse(id);
            }
            catch (Exception e)
            {
                MessageBox.Show("Not correct format deadline on Id");
                return false;
            }
            var unit = new UnityOfWork(new ProjectTracerEntities());
            unit.Tasks.Add(new Tasks()
            {
                Task_Id = parseId,
                Description = descripton,
                DeadLine = parseDeadLine,
                Project_Id = project_Id
            });
            try
            {
                unit.Complete();
                return true;
            }
            catch (Exception E)
            {
                MessageBox.Show($"Error ocurred saving changes, please try later");
                return false;
            }
        }
    }
}
