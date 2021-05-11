using Excursion.Controllers;
using Excursion.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Excursion.Tests.ControllerTests
{
    public class AdminConrollerTests
    {
        public ApplicationContext c;

        [Test]
        public void AdminController_ActionName_RedirectToAction()
        {
            // Arrange
            AdminController controller = new AdminController(c);

            // Act
            var result = controller.RedirectToAction("MapRedactor");

            // Assert
            Assert.That(result.ActionName, Is.EqualTo("MapRedactor"));
        }

        [Test]
        public void AdminController_GetType()
        {
            // Arrange
            string expected = "AdminController";

            // Act
            AdminController controller = new AdminController(c);

            //Assert
            Assert.AreEqual(expected, controller.GetType().Name);
        }

        [Test]
        public void AdminController_ActionNameIndex_RedirectToAction()
        {
            // Arrange
            AdminController controller = new AdminController(c);

            // Act
            var result = controller.RedirectToAction("Index");

            // Assert
            Assert.That(result.ActionName, Is.EqualTo("Index"));
        }
    }
}
