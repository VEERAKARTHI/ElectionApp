using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ElectionApp.Models;

namespace ElectionApp.Controllers
{
    public class ElectionResultController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ElectionResultController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var ElectionResults = _context.ElectionResults.ToList();

            return View(ElectionResults);
        }
    }
}
