using Microsoft.AspNetCore.Mvc;

namespace E_commerce.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult register()
        {
            return View();
        }

        public IActionResult login()
        {
            return View(); 
        }
    }
}
