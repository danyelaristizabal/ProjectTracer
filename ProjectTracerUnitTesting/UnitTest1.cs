using System;
using Xunit;
using ProjectTracer.Controllers;
using ProjectTracer.Repository; 
using ProjectTracer;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using ProjectTracer.Repository;
using ProjectTracer.Models;

namespace ProjectTracerUnitTesting
{
    public class AddProjectControllerTests
    {
        [Fact]
        public void TestGetProject()
        {
            //Arrange
            var unit = AdminProjectsController.GetProjectsItemList(new UnityOfWork( new ProjectTracerEntities()));
            //Act

            //Assert 

        }
    }
}
