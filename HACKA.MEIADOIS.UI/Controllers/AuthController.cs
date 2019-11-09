using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HACKA.MEIADOIS.UI.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }
    }
}