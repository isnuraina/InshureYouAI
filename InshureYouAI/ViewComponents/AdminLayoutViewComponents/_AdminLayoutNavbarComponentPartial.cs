using Microsoft.AspNetCore.Mvc;

namespace InshureYouAI.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

