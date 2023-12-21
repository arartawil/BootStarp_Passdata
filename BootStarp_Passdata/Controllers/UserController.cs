using BootStarp_Passdata.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootStarp_Passdata.Controllers
{
    public class UserController : Controller
    {

        [HttpGet]
        public IActionResult Login()
        {
            Login login = new Login();
            login.username= "admin";
            login.password= "admin"; 

            ViewBag.login = login;
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            ViewBag.login = login;

            if (login.username.Equals("Arar") && login.password.Equals("123456"))
            {
                string result = "Done";
                TempData["Msg"] = result;
                ViewBag.login = login;

                ViewData["login"] = login;
            }
            else
            {
                string result = "Check your Account";
                TempData["Msg"] = result;
                ViewData["login"] = login;

            }
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }



    }
}
