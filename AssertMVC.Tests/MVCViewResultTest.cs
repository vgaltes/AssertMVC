using AssertMVC.Tests.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssertMVC.Tests
{
    [TestClass]
    public class MVCViewResultTest
    {
        TestController controller = new TestController();

        [TestMethod]
        public void TestViewHasName()
        {
            string viewName = "TestViewName";
         
            var result = controller.IndexView(viewName);

            result.AsViewResult().HasName(viewName);
        }

        [TestMethod]
        public void TestIsDefault()
        {
            var result = controller.DefaultView();

            result.AsViewResult().IsDefault();
        }

        [TestMethod]
        public void TestWithLayout()
        {
            var layoutName = "_layoutName";
            var viewName = "TestViewName";

            var result = controller.ViewWithLayout(viewName, layoutName);

            result.AsViewResult().WithLayout(layoutName);
        }

        [TestMethod]
        public void TestWithModel()
        {
            var result = controller.ViewWithModel();

            result.AsViewResult().WithModel();
        }
    }
}
