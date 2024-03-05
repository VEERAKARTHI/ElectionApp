using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ElectionApp.Models;

namespace ElectionApp.Controllers
{
    public class ElectionResultController : Controller
    {
        public IActionResult Index()
        {
            var ElectionResults = new List<ElectionResult>
            {
                new ElectionResult { Votes = 1000, Candidate = "Candidate1"},
                new ElectionResult { Votes = 2000, Candidate = "Candidate2" },
                new ElectionResult { Votes = 3000, Candidate = "Candidate3"},
            };

            return View(ElectionResults);
        }
    }
}
