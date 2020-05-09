using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PelaSoft.Tools.PrettyJson.Web.Controllers
{
	public class FormatController : Controller
	{
		// GET: Format
		[ValidateInput(false)]
		public ActionResult Index(string url)
		{
			return Content(GetContent(url));
		}

		public ActionResult Display(string url)
		{
			return View(model: GetContent(url));
		}

		private string GetContent(string url)
		{
			var client = new WebClient();
			var jsonContent = client.DownloadString(url);

			string jsonFormatted = JValue.Parse(jsonContent).ToString(Formatting.Indented);
			return jsonFormatted;
		}

	}
}