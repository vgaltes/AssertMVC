using AssertMVC.Tests.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssertMVC.Tests
{
    [TestClass]
    public class MVCViewResultTest
    {
        [TestMethod]
        public void TestViewHasName()
        {
            string viewName = "TestViewName";

            var controller = new TestController();
            var result = controller.IndexView(viewName);

            result.AsViewResult().HasName(viewName);
        }
    }
}
