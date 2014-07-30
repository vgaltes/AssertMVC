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

        public static void IsDefault(this ViewResult result)
        {
            Assert.AreEqual(string.Empty, result.ViewName);
        }

        public static void WithLayout(this ViewResult result, string layoutName)
        {
            Assert.AreEqual(layoutName, result.MasterName);
        }

        public static void WithModel(this ViewResult result)
        {
            Assert.IsNotNull(result.Model);
        }
    }
}