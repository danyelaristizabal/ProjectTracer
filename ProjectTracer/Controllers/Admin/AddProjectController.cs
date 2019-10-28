using System;
using System.Windows.Forms;
using ProjectTracer.Repository;

namespace ProjectTracer.Controllers
{
    public static class AddProjectController
    {
        public static bool AddProject(string id, string descripton, string deadline  )
        {
            var ParsedDeadLine = new DateTime(); 
            try
            {
                 ParsedDeadLine = DateTime.Parse(deadline); 
            }
            catch(Exception)
            {
                MessageBox.Show("Not correct deadline");
                return false; 
            }
            var unit = new UnityOfWork(new ProjectTracerEntities());
            unit.Project.Add(new Project()
            {
                Project_ID = id,
                Description = descripton,
                DeadLine =ParsedDeadLine ,
                Result = "notregistered",
            });
            try
            {
                unit.Complete();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show($"Error ocurred saving changes, please try later");
                return false;
            }
        }
    }
}
