using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AssertMVC
{
    public static class MVCActionResult
    {
        public static ViewResult AsViewResult(this ActionResult result)
        {
            return result as ViewResult;
        }
    }
}