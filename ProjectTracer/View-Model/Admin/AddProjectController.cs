using System;
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

                return false; 

            }

            var unit = new UnityOfWork(new ProjectTracerEntities());

            unit.Project.Add(new Project()
            {
                Project_ID = id,
                Description = descripton,
                DeadLine = ParsedDeadLine ,
                Result = "notregistered",
            });

            try
            {
                unit.Complete();
                unit.Dispose();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool FindProject(Project expectedResult)
        {
            try
            {
                var unit = new ProjectTracerEntities();
                
                unit.SaveChanges(); 
                unit.Dispose();

                return false ;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return true; 
            }
           
           
        }

        public static bool asktrue()
        {
            return true;
        }
    }
}
