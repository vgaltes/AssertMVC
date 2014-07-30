using System.Web.Mvc;

namespace AssertMVC.Tests.Controllers
{
    public class TestController : Controller
    {
        public ActionResult IndexView(string nameView)
        {
            return View(nameView);
        }

        internal ActionResult DefaultView()
        {
            return View();
        }
    }
}
