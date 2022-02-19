using Microsoft.AspNetCore.Mvc;
using OleevMvcApp.Models;
using OleevMvcApp.Vıew_model;
using System.Diagnostics;

namespace OleevMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly OleevContext _context;


        public HomeController(ILogger<HomeController> logger, OleevContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            IndexVM vm = new();
            vm.Section1 = _context.SectionOnes.First();
            return View(vm);
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
}