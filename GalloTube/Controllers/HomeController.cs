using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GalloTube.Models;
using GalloTube.Interfaces;


namespace GalloTube.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IVideoRepository _videoRepository;

    public HomeController(ILogger<HomeController> logger, IVideoRepository videoRepository)
    {
        _logger = logger;
        _videoRepository = videoRepository;
    }

    public IActionResult Index()
    {
        var videos = _videoRepository.ReadAllDetailed();
        return View(videos);
    }

    public IActionResult Video(int id)
    {
        var video  = _videoRepository.ReadByIdDetailed(id);
        return View(video);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        _logger.LogError("Ocorreu um erro");
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}