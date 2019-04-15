using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clockwork.Web.Controllers
{
    public class TimeController : Controller
    {
        public ActionResult Index()
        {
            List<SelectListItem> Timezones = new List<SelectListItem>();
            
            foreach (TimeZoneInfo info in TimeZoneInfo.GetSystemTimeZones())
            {
                Timezones.Add(new SelectListItem
                {
                    Text = info.DisplayName,
                    Value = info.Id,
                });
            }

            ViewData["Timezones"] = Timezones;
            ViewBag.Api = System.Configuration.ConfigurationManager.AppSettings["Api"];

            return View();
        }
    }
}