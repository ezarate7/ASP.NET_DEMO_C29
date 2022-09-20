using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_DEMO_C29.Models
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
