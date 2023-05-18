using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Paramotor.Models;
using Paramotor.Models.Entities;

namespace Paramotor.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    ParamotordbContext db = new ParamotordbContext();

    public IActionResult Index()
    {
        var model = new IndexViewModel()
        {
            Site = db.Sites!.First()
        };
        return View(model);
    }

    [Route("/about-us")]
    public IActionResult AboutUs()
    {
        var model = new IndexViewModel()
        {
            Site = db.Sites!.First()
        };
        return View(model);
    }

    [Route("/service")]
    public IActionResult Service()
    {
        var model = new IndexViewModel()
        {
            Site = db.Sites!.First()
        };
        return View(model);
    }

    [Route("/blog")]
    public IActionResult Blog()
    {
        var model = new IndexViewModel()
        {
            Site = db.Sites!.First()
        };
        return View(model);
    }

    [Route("/blog-detail/{title}/{id}")]
    public IActionResult BlogDetail(string title, int id)
    {
        var model = new IndexViewModel()
        {
            Site = db.Sites!.First()
        };
        return View(model);
    }

    [Route("/event")]
    public IActionResult Event()
    {
        var model = new IndexViewModel()
        {
            Site = db.Sites!.First()
        };
        return View(model);
    }

    [Route("/event-detail/{title}/{id}")]
    public IActionResult EventDetail(string title, int id)
    {
        var model = new IndexViewModel()
        {
            Site = db.Sites!.First()
        };
        return View(model);
    }

    [Route("/cource")]
    public IActionResult Cource()
    {
        var model = new IndexViewModel()
        {
            Site = db.Sites!.First()
        };
        return View(model);
    }

    [Route("/cource-detail/{title}/{id}")]
    public IActionResult CourceDetail(string title, int id)
    {
        var model = new IndexViewModel()
        {
            Site = db.Sites!.First()
        };
        return View(model);
    }

     [Route("/contact")]
    public IActionResult Contact()
    {
        var model = new IndexViewModel()
        {
            Site = db.Sites!.First()
        };
        return View(model);
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
