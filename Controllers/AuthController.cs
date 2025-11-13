using Microsoft.AspNetCore.Mvc;
using Blood4A.Models;
using System.Diagnostics;

namespace Blood4A.Controllers;

public class AuthController(ILogger<AuthController> logger) : Controller
{
    private readonly ILogger<AuthController> _logger = logger;

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Cadastro()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}