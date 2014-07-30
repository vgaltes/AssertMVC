using System.Web.Mvc;

namespace AssertMVC.Tests.Controllers
{
    public class TestController : Controller
    {
        internal ActionResult IndexView(string viewName)
        {
            return View(viewName);
        }

        internal ActionResult DefaultView()
        {
            return View();
        }

        internal ActionResult ViewWithLayout(string viewName, string layoutName)
        {
            return View(viewName, layoutName);
        }

        internal ActionResult ViewWithModel()
        {
            return View(1);
        }

        internal ActionResult ViewWithModel(object model)
        {
            return View(model);
        }

        internal ActionResult IndexPartialView(string viewName)
        {
            return PartialView(viewName);
        }
    }
}