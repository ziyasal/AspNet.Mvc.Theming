﻿using System;
using System.Web.Mvc;

namespace AspNet.Mvc.Theming.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ThemeAttribute : ActionFilterAttribute
    {
        public ThemeAttribute(string theme)
        {
            Theme = theme;
        }

        public string Theme { get; private set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.RouteData.Values.Add("Theme", Theme);
            base.OnActionExecuting(filterContext);
        }
    }
}