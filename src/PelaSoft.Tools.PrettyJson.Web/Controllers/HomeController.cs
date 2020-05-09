using PelaSoft.Tools.PrettyJson.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PelaSoft.Tools.PrettyJson.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index(string url)
		{
			var model = new FormatVM { Url = url };

			if (!string.IsNullOrWhiteSpace(url))
			{
				model.FormatLink = Url.Action("index", "format", new { url = url }, "http");
				model.DisplayUrl = Url.Action("display", "format", new { url = url }, "http");
			}

			return View(model);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}