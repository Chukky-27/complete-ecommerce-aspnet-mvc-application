using FlickFlow.Data;
using FlickFlow.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace FlickFlow.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _actorsService;

        public ActorsController(IActorsService actorsService)
        {
            _actorsService = actorsService;
        }

        public async Task <IActionResult> Index()
        {
            var data = await _actorsService.GetAllActors();
            return View(data);
        }

        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
