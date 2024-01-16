using Assignment_7.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_7.Controllers
{
    public class PlayersController : Controller
    {
        static List<Player> players = new List<Player>()
        {
            new Player(){PId = 1,PName="Dhoni",PCountry="India",PType="wicketKeeper"},
            new Player(){PId = 2,PName="Kohli",PCountry="India",PType="Batsman"},
            new Player(){PId = 4,PName="Yuvraj",PCountry="India",PType="Bowler"},

        };
        public IActionResult Index()
        {
            return View(players);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Player());
        }
        [HttpPost]
        public IActionResult Create(Player play)
        {
            if (ModelState.IsValid)
            {
                players.Add(play);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
            
        
}

