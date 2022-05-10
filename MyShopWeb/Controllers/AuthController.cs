using DataLayer.Services;
using MyShopWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShopWeb.Controllers
{
	public class AuthController : Controller
	{
		UsersService service = new UsersService();
		public ViewResult Login()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Login(UserLoginViewModel user)
		{
			if (ModelState.IsValid)
			{
				var userValid = service.AuthenticateUser(user.UserName, user.Password);
				if (userValid != null)
				{
					//Create Sessions
					Session["UserId"] = userValid.Id;
					Session["UserRoleId"] = userValid.RoleId;
					return RedirectToAction("Index", "Dashboard");
				}
			}
			return View();
		}
	}
}