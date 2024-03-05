using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ElectionApp.Models;

namespace ElectionApp.Controllers
{
    public class CandidateController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CandidateController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            var candidates = _context.Candidates.ToList();
            return View(candidates);
        }
    }
}
