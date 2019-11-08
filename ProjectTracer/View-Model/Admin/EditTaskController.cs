using ProjectTracer.Repository;
using System.Linq;

namespace ProjectTracer.Controllers
{
    public static class EditTaskController
    {
        public static Task GetTaskById(UnityOfWork unit, string project_Id, int task_Id  )
        {
           return unit.Task
                .GetAll()
                .Where(searchedTasks => searchedTasks.Project_Id == project_Id)
                .Where(searchedTask => searchedTask.Task_Id == task_Id)
                .FirstOrDefault();
        }
        public static void  UpdateTask(UnityOfWork unit, Task task)
        {
            Task mytask = unit.Task.
                GetAll()
                .Where(searchedTasks => searchedTasks.Project_Id == task.Project_Id)
                .FirstOrDefault(t => t.Task_Id == task.Task_Id);

            mytask.Task_Id = task.Task_Id;
            mytask.Description = task.Description;
            mytask.DeadLine = task.DeadLine;  

            unit.Complete();
        }
    }
}
