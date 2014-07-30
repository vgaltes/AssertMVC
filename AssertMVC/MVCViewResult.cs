using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace AssertMVC
{
    public static class MVCViewResult
    {
        public static void HasName(this ViewResult result, string expectedName)
        {
            Assert.AreEqual(expectedName, result.ViewName);
        }
    }
}