using Microsoft.AspNetCore.Mvc;

namespace BankingApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
