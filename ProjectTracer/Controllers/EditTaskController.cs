using ProjectTracer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTracer.Controllers
{
    public static class EditTaskController
    {
        public static Tasks GetTaskById(UnityOfWork unit, string project_Id, int task_Id  )
        {
           return unit.Tasks.GetAll().Where(searchedTasks => searchedTasks.Project_Id == project_Id).Where(searchedTask => searchedTask.Task_Id == task_Id).FirstOrDefault();
        }
        public static void  UpdateTask(UnityOfWork unit, Tasks task)
        {
            Tasks mytask = GetTaskById(unit, task.Project_Id, task.Task_Id);
            unit.Tasks.Remove(mytask);
            unit.Tasks.Add(task);
            unit.Complete();
        }
    }
}
