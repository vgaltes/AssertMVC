using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace AssertMVC.Tests
{
    [TestClass]
    public class MVCActionResultTest
    {
        [TestMethod]
        public void TestConvertToViewResult()
        {
            ActionResult viewResult = new ViewResult();

            Assert.IsNotNull(viewResult.AsViewResult());

            viewResult = new PartialViewResult();
            Assert.IsNull(viewResult.AsViewResult());
        }
    }
}
