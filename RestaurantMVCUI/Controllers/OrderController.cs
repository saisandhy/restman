using Microsoft.AspNetCore.Mvc;

namespace RestaurantMVCUI.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
