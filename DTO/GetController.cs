using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace SignaturePad.DTO
{
    public class GetController
    {
        public static string RouterCurrent = "";
        public static string GetControllerNameFromUrl()
        {
            var httpContext = new HttpContextWrapper(System.Web.HttpContext.Current);
            var routeData = RouteTable.Routes.GetRouteData(httpContext);

            if (routeData != null && routeData.Values.ContainsKey("controller"))
            {
                RouterCurrent = routeData.Values["controller"].ToString();
                return routeData.Values["controller"].ToString();
            }

            return null;
        }
    }
}