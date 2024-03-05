using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ElectionApp.Models;

namespace ElectionApp.Controllers
{
    public class CandidateController : Controller
    {
        public IActionResult Index()
        {
            var Candidates = new List<Candidate>
            {
                new Candidate { Id = 1, Name = "Candidate1", Party = "Party A"},
                new Candidate { Id = 2, Name = "Candidate2", Party = "Party A" },
                new Candidate { Id = 3, Name = "Candidate3", Party = "Party A"},
            };

            return View(Candidates);
        }
    }
}
