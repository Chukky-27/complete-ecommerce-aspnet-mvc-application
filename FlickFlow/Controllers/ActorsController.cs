﻿using FlickFlow.Data.Services;
using FlickFlow.Models;
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

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _actorsService.AddActorAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _actorsService.GetActorByIdAsync(id);

            if (actorDetails == null) return View("Empty");
            return View(actorDetails);
        }
    }
}
