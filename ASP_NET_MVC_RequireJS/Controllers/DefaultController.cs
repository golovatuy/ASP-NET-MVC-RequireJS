using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_RequireJS.Controllers
{
	public class DefaultController : Controller
	{
		// GET: Default
		public ActionResult Index()
		{
				return View();
		}
		// GET: Default
		public ActionResult IndexSecond()
		{
			return View();
		}
		// GET: Default
		public ActionResult IndexThird()
		{
			return View();
		}
	}
}