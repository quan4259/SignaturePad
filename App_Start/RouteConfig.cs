using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SignaturePad
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(name: "thong-tin-ca-nhan", url: "thong-tin-ca-nhan", defaults: new { controller = "ASP_ThongTinCaNhan", action = "ASP_ThongTinCaNhan", id = UrlParameter.Optional });
            routes.MapRoute(name: "dang-nhap-he-thong", url: "dang-nhap-he-thong", defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional });
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
