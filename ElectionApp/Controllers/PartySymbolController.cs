// Controllers/PartySymbolController.cs

using Microsoft.AspNetCore.Mvc;
using ElectionApp.Models;
using System.Collections.Generic;

namespace ElectionApp.Controllers
{
    public class PartySymbolController : Controller
    {
        public IActionResult Index()
        {
            var symbols = new List<PartySymbol>
            {
                new PartySymbol { Id = 1, Symbol = "Symbol A" },
                new PartySymbol { Id = 2, Symbol = "Symbol B" },
                new PartySymbol { Id = 3, Symbol = "Symbol C" },
            };

            return View(symbols);
        }
    }
}
