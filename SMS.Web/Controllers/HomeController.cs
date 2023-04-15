using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SMS.Web.Models;

namespace SMS.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var longTime= DateTime.Now.ToLongTimeString();
        var message= "Time Now";

        ViewBag.LongTime=longTime;
        ViewBag.Message=message;
        return View();
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

        public IActionResult About()
    {
        var about= new AboutViewModel();
        about.Title="About page";
        about.Message="This is the about page";
        about.Formed= new DateTime(2022,1,1);
        return View (about);
    }
}
