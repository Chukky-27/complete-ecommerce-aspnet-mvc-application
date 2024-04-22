using Microsoft.AspNetCore.Mvc;

namespace FlickFlow.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
