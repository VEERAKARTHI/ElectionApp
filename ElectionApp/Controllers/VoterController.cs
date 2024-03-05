using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ElectionApp.Models;

namespace ElectionApp.Controllers
{
    public class VoterController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VoterController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var voters = _context.Voters.ToList();
            return View(voters);
        }
    }
}
