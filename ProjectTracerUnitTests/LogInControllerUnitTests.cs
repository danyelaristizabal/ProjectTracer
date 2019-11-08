using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectTracer.Repository;
using ProjectTracer.Controllers;
using ProjectTracer.Models;
using ProjectTracer;
using System;
using System.Linq;
using System.Windows.Forms;


namespace ProjectTracerUnitTests
{
    [TestClass]
    public class LogInControllerUnitTests
    {
        [TestMethod]
        public void GetLogInTest()
        {
            //Arrange
            var userType = "Administrator";

            var Admin = new Administrator();

            var expectedResult = new LogInView(Admin);// Expected result is the loginview for an Admin

            //Act
            var result = EntryController.GetLogIn(userType); // testing the method that replace the login view with admin login view
            
            //Assert 
            Assert.AreEqual(expectedResult.MyUser.GetType().Name, result.MyUser.GetType().Name);  // checking if both are the same type of loginView
        } 
    }
}
