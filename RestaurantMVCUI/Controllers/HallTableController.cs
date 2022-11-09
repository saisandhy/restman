using Microsoft.AspNetCore.Mvc;

namespace RestaurantMVCUI.Controllers
{
    public class HallTableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
