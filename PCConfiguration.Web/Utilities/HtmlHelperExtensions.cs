﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PCConfiguration.Web
{
    public static class HtmlHelperExtensions
    {
        /// <summary>
        /// For making navigation links in the NavBar selected.
        /// </summary>
        public static string IsSelected(this IHtmlHelper htmlHelper, string controllers, string actions, string cssClass = "selected")
        {
            string currentAction = htmlHelper.ViewContext.RouteData.Values["action"] as string;
            string currentController = htmlHelper.ViewContext.RouteData.Values["controller"] as string;

            IEnumerable<string> acceptedActions = (actions ?? currentAction).Split(',');
            IEnumerable<string> acceptedControllers = (controllers ?? currentController).Split(',');

            return acceptedActions.Contains(currentAction) && acceptedControllers.Contains(currentController) ?
                cssClass : String.Empty;
        }
    }
}