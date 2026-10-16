using Microsoft.AspNetCore.Mvc;

namespace NetCoreLA7.Components 
{
    public class NavLeftViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}