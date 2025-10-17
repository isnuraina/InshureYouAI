using Microsoft.AspNetCore.Mvc;

namespace InshureYouAI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
