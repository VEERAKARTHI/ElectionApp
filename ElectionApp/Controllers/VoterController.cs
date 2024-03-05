using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ElectionApp.Models;

namespace ElectionApp.Controllers
{
    public class VoterController : Controller
    {
        public IActionResult Index()
        {
            var Voters = new List<Voter>
            {
                new Voter { Id = 1, Name = "User1" },
                new Voter { Id = 2, Name = "User2" },
                new Voter { Id = 3, Name = "User3"},
            };

            return View(Voters);
        }
    }
}
