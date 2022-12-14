using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TranHoangChung.Models;

namespace TranHoangChung.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
[HttpGet]
    public IActionResult Index()
    {
        return View();
    }
[HttpPost]
    public IActionResult Index(string FullName)
    {
        ViewBag.name="Hello " + FullName;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
