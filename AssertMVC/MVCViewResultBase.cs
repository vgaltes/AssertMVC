﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace AssertMVC
{
    public static class MVCViewResultBase
    {
        public static void WithName(this ViewResultBase result, string expectedName)
        {
            Assert.AreEqual(expectedName, result.ViewName);
        }

        public static void Default(this ViewResultBase result)
        {
            Assert.AreEqual(string.Empty, result.ViewName);
        }

        public static MVCModel WithModel(this ViewResultBase result)
        {
            Assert.IsNotNull(result.Model);
            return new MVCModel(result.Model);
        }

        public static MVCViewBag WithViewBag(this ViewResultBase result)
        {
            return WithViewData(result);
        }

        public static MVCViewBag WithViewData(this ViewResultBase result)
        {
            Assert.IsNotNull(result.ViewBag);
            return new MVCViewBag(result.ViewData);
        }
    }
}