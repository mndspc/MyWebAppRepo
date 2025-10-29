using Microsoft.AspNetCore.Mvc;

namespace ModelDemo.Controllers
{
    public class OrderInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
