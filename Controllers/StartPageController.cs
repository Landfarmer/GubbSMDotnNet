using Microsoft.AspNetCore.Mvc;

namespace GubbSMDotnNet.Controllers
{
    public class StartPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}