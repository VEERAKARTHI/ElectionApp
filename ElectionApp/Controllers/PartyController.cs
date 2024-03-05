// Controllers/PartyController.cs

using Microsoft.AspNetCore.Mvc;
using ElectionApp.Models;
using System.Collections.Generic;

namespace ElectionApp.Controllers
{
    public class PartyController : Controller
    {
        public IActionResult Index()
        {            
            var parties = new List<Party>
            {
                new Party { Id = 1, Name = "Party A", Symbol = "Symbol A" },
                new Party { Id = 2, Name = "Party B", Symbol = "Symbol B" },
                new Party { Id = 3, Name = "Party C", Symbol = "Symbol C" },
            };

            return View(parties);
        }
    }
}
