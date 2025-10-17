using Microsoft.AspNetCore.Mvc;

namespace InshureYouAI.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
