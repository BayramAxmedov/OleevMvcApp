using Microsoft.AspNetCore.Mvc;

namespace OleevMvcApp.Areas.AdminOlev.Controllers
{
    [Area("AdminOlev")]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
