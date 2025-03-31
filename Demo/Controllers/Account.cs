using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class Account : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
    }
}
