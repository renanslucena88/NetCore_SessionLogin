using Microsoft.AspNetCore.Mvc;
using SessionLogin.Library.Filters;
using SessionLogin.Models;
using System;

namespace SessionLogin.Controllers
{
    [Login]
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ReceiveContact([FromForm] Contact contact)
        {
            if (ModelState.IsValid)
            {
                string content = String.Format("Nome: {0}, Email: {1}, Assunto: {2}, Msg: {3}", contact.Name, contact.Email, contact.Subject, contact.Message);
                return new ContentResult() { Content = content };
            }
            else
            {
                return View("Index");
            }


        }
    }
}
