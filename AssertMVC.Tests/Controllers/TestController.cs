using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AssertMVC.Tests.Controllers
{
    public class TestController : Controller
    {
        public ActionResult IndexView(string nameView)
        {
            return View(nameView);
        }
    }
}
