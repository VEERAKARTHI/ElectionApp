// Controllers/StateController.cs

using Microsoft.AspNetCore.Mvc;
using ElectionApp.Models;
using System.Collections.Generic;

namespace ElectionApp.Controllers
{
    public class StateController : Controller
    {
        public IActionResult Index()
        {
            // Sample data initialization
            var states = new List<State>
            {
                new State { Name = "State A", NumberOfMPSeats = 10 },
                new State { Name = "State B", NumberOfMPSeats = 15 },
                new State { Name = "State C", NumberOfMPSeats = 8 },
                // Add more states and their corresponding MP seat counts as needed
            };

            return View(states);
        }
    }
}
