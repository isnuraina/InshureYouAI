using Microsoft.AspNetCore.Mvc;

namespace InshureYouAI.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutNavbarMenuComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
