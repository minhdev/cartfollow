using System;
using System.Web.Mvc;
using cartfolo.Controllers;
using cartfolo.Models;
using cartfolo.Tests.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace cartfolo.Tests.Controllers
{
    [TestClass]
    public class GuestbookControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //Arrage
            GuestbookServiceMock mock = new GuestbookServiceMock();
            GuestbookController controller = new GuestbookController(mock);

            //Act
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.ViewBag.Entries.Count, 1);
            Assert.AreEqual(result.ViewBag.Entries[0].Name, "minh");
        }

        [TestMethod]
        public void Create() 
        {
            //Arrage
            GuestbookServiceMock mock = new GuestbookServiceMock();
            GuestbookController controller = new GuestbookController(mock);
            GuestbookEntry entry = new GuestbookEntry();
            entry.Name = "mike";
            entry.Message = "test";

            //Act
            controller.Create(entry);
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.ViewBag.Entries.Count, 2);
        }
    }
}
