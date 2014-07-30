﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        public static MVCModel WithModel(this ViewResult result)
        {
            Assert.IsNotNull(result.Model);
            return new MVCModel(result.Model);
        }
    }

    public class MVCModel
    {
        object model = null;

        public MVCModel(object model)
        {
            this.model = model;
        }

        public void OfType<T>()
        {
            Assert.AreEqual(typeof(T), model.GetType());
        }
    }
}