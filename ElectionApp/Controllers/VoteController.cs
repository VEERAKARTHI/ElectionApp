// Controllers/VoteController.cs

using Microsoft.AspNetCore.Mvc;
using ElectionApp.Models;
using System.Collections.Generic;

namespace ElectionApp.Controllers
{
    public class VoteController : Controller
    {
        private readonly List<Candidate> _candidates;

        public VoteController()
        {
            
            _candidates = new List<Candidate>
            {
                new Candidate { Id = 1, Name = "Candidate A", Party = "Party X" },
                new Candidate { Id = 2, Name = "Candidate B", Party = "Party Y" },
                new Candidate { Id = 3, Name = "Candidate C", Party = "Party Z" },
            };
        }

        // GET: /Vote
        public IActionResult Index()
        {
            return View(_candidates);
        }

        // POST: /Vote/Submit
        [HttpPost]
        public IActionResult Submit(int candidateId)
        {
            // Save vote to database or perform other actions
            // Redirect to a thank you page or another appropriate action
            return RedirectToAction("ThankYou");
        }

        // GET: /Vote/ThankYou
        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
