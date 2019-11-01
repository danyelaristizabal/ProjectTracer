using System;
using Xunit;
using ProjectTracer.Controllers;
using ProjectTracer; 
namespace ProjectTracerUnitTesting
{
    public class AddProjectControllerTests
    {
        [Fact]
        public void AddProjectTest()
        {
            //Arrangee
            var expectedResult = new Project()
            {
                Project_ID = "Redbull",
                Description = "",
                DeadLine = new DateTime(2011, 11, 11)
            };

            //Act

            //Assert 
            Assert.True(AddProjectController.FindProject(expectedResult));

        }
    }
}
