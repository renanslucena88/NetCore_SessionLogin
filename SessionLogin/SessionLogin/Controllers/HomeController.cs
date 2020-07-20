using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SessionLogin.Models;

namespace SessionLogin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm] User user)
        {
            if (ModelState.IsValid)
            {
                if (user.Email == "renanestudos88@gmail.com" && user.Password == "123456")
                {
                    HttpContext.Session.SetString("Login", "true");
                    return RedirectToAction("Index", "Words");
                }
                else
                {
                    ViewBag.Message = "Email or Password wrong";
                }
            }

            return View();
        }
    }
}
