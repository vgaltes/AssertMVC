using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace AssertMVC
{
    public static class MVCViewResult
    {
        public static void WithName(this ViewResultBase result, string expectedName)
        {
            Assert.AreEqual(expectedName, result.ViewName);
        }

        public static void Default(this ViewResultBase result)
        {
            Assert.AreEqual(string.Empty, result.ViewName);
        }

        public static void WithLayout(this ViewResult result, string layoutName)
        {
            Assert.AreEqual(layoutName, result.MasterName);
        }

        public static MVCModel WithModel(this ViewResultBase result)
        {
            Assert.IsNotNull(result.Model);
            return new MVCModel(result.Model);
        }
    }
}