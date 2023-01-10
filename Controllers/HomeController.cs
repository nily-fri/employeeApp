using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AAAA.Models;
using AAAA.Models.Database.NilyDb;

namespace AAAA.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly NilyDbContextScaffold _nilyDbContextScaffold;


    public HomeController(ILogger<HomeController> logger, NilyDbContextScaffold nilyDbContextScaffold)
    {
        _logger = logger;
        _nilyDbContextScaffold = nilyDbContextScaffold;
    }

    public IActionResult Index()
    {
        var aaa = _nilyDbContextScaffold.Employees.FirstOrDefault();
        Console.WriteLine("123213");
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}