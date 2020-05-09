using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PelaSoft.Tools.PrettyJson.Web.Models
{
    public class FormatVM
    {
        public string Url { get; set; }
        public string FormatLink { get; set; }
		public string DisplayUrl { get; internal set; }
	}
}