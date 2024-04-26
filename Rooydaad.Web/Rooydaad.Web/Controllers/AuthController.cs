using Microsoft.AspNetCore.Mvc;
using Rooydaad.Web.Models;

namespace Rooydaad.Web.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Credentials credentials)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "You logged in ;)";
                return View();
            }

            ViewBag.Message = string.Empty;
            return View(credentials);
        }
    }
}
