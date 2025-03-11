using BankingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // Index page
    public IActionResult Index()
    {
        return View();
    }

    // About Us page
    public IActionResult About()
    {
        return View("~/Views/About/Index.cshtml"); 
    }

    // Contact Us page
    public IActionResult Contact()
    {
        return View("~/Views/Contact/Index.cshtml"); 
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}