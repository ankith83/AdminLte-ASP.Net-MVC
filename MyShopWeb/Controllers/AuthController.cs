using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShopWeb.Controllers
{
	public class AuthController : Controller
	{
		public ViewResult Login()
		{
			return View();
		}
	}
}