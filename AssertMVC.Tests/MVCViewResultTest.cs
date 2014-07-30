using AssertMVC.Tests.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestMethod]
        public void TestIsDefault()
        {
            var controller = new TestController();
            var result = controller.DefaultView();

            result.AsViewResult().IsDefault();
        }
    }
}
