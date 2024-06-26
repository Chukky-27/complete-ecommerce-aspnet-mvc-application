﻿using FlickFlow.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlickFlow.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ProducersController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _appDbContext.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
