using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;

namespace AssertMVC.Tests
{
    [TestClass]
    public class MVCActionResultTest
    {
        [TestMethod]
        public void TestShouldBeViewResult()
        {
            ActionResult viewResult = new ViewResult();

            var result = viewResult.ShouldBe<ViewResult>();
            Assert.IsInstanceOfType(result, typeof(MVCViewResult));
        }

        [TestMethod]
        public void TestShouldBeJsonResult()
        {
            ActionResult jsonResult = new JsonResult();

            jsonResult.ShouldBe<JsonResult>();
        }
    }
}