using System;
using System.Web.Mvc;

public static class CustomExtension
{
    public static string MakeActiveClass(this UrlHelper urlHelper, string controller)
    {
        string result = "active";

        string controllerName = urlHelper.RequestContext.RouteData.Values["controller"].ToString();

        if (!controllerName.Equals(controller, StringComparison.OrdinalIgnoreCase))
        {
            result = null;
        }

        return result;
    }
}