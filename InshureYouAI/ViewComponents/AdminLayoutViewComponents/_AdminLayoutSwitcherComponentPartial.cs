using Microsoft.AspNetCore.Mvc;

namespace InshureYouAI.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutSwitcherComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
