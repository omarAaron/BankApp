using Microsoft.AspNetCore.Mvc;

namespace BankingApp.Controllers
{
    public class AboutController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
