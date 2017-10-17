using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HeyChat.Controllers
{
    public class LoginController : Controller
    {
		[HttpPost]
		public ActionResult Index()
		{
			string user = Request.Form["username"];

			if (user.Trim() == "")
			{
				return Redirect("/");
			}

            Session["user"] = user;

			return Redirect("/chat");
		}
    }
}
