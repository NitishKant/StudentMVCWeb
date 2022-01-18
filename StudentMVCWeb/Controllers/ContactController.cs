using Microsoft.AspNetCore.Mvc;

namespace StudentMVCWeb.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
