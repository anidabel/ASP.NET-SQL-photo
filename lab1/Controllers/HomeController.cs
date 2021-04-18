using lab1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace lab1.Controllers
{
    public class HomeController : Controller
    {
        private static HockeyPlayerParams hockeyPlayerParams;
        HockeyPlayerContext db;
        public int k = 0;

        public HomeController(HockeyPlayerContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            HockeyPlayerParams hpp = new HockeyPlayerParams
            {
                positions = new SelecList(new List<string>()
                {
                    "",
                    "C",
                    "D",
                    "G",
                    "LW",
                    "RW"
                })
            };
            return View(hpp);
        }
        [HttpPost]
        public string Index(HockeyPlayerParams @params)
        {
            hockeyPlayerParams = @params;
            if (hockeyPlayerParams.birthdayFrom == new DateTime(0001, 01, 01))
                hockeyPlayerParams.birthdayFrom = DateTime.MinValue;
            if (hockeyPlayerParams.birthdayTo == new DateTime(0001, 01, 01))
                hockeyPlayerParams.birthdayTo = DateTime.MaxValue;
            if (hockeyPlayerParams.birthdayFrom > hockeyPlayerParams.birthdayTo)
            {
                DateTime tmp = hockeyPlayerParams.birthdayFrom;
                hockeyPlayerParams.birthdayFrom = hockeyPlayerParams.birthdayTo;
                hockeyPlayerParams.birthdayTo = tmp;
            }
            if (hockeyPlayerParams.weightTo <= 0)
            {
                hockeyPlayerParams.weightTo = 120;
            }
            if(hockeyPlayerParams.heightTo <= 0)
            {
                hockeyPlayerParams.heightTo = 200;
            }
            if (hockeyPlayerParams.weightFrom > hockeyPlayerParams.weightTo)
            {
                var tmp = hockeyPlayerParams.weightTo;
                hockeyPlayerParams.weightTo = hockeyPlayerParams.weightFrom;
                hockeyPlayerParams.weightFrom = tmp;
            }
            if (hockeyPlayerParams.heightFrom > hockeyPlayerParams.heightTo)
            {
                var tmp = hockeyPlayerParams.heightTo;
                hockeyPlayerParams.heightTo = hockeyPlayerParams.heightFrom;
                hockeyPlayerParams.heightFrom = tmp;
            }
            var savedRosters = db.hockeyPlayer.ToList();
            savedRosters = savedRosters.Where(roster => (hockeyPlayerParams.position == null || hockeyPlayerParams.position == roster.position) &&
                                                        (roster.birthday >= hockeyPlayerParams.birthdayFrom && roster.birthday <= hockeyPlayerParams.birthdayTo) &&
                                                        (hockeyPlayerParams.weightTo >= roster.weight && hockeyPlayerParams.weightFrom <= roster.weight) &&
                                                        (hockeyPlayerParams.heightTo >= roster.height && hockeyPlayerParams.heightFrom <= roster.height)).ToList();
            if (savedRosters.Count() == 0)
                return "С таким набором фильтров таблица будет пуста.";
            return "the parameters are set";
        }
        [HttpGet]
        public IActionResult Table()
        {
            var savedRosters = db.hockeyPlayer.ToList();
            if (hockeyPlayerParams != null)
            {
                savedRosters = savedRosters.Where(roster => (hockeyPlayerParams.position == null || hockeyPlayerParams.position == roster.position) &&
                                                        (roster.birthday >= hockeyPlayerParams.birthdayFrom && roster.birthday <= hockeyPlayerParams.birthdayTo) &&
                                                        (hockeyPlayerParams.weightTo >= roster.weight && hockeyPlayerParams.weightFrom <= roster.weight) &&
                                                        (hockeyPlayerParams.heightTo >= roster.height && hockeyPlayerParams.heightFrom <= roster.height)).ToList();
            }
            
            return View(savedRosters.ToList());
        }
        
        [HttpGet]
        public IActionResult Photo(string ID)
        {
            Photo p = new Photo();
            p.Name = ID.ToString();
            var savedRosters = db.hockeyPlayer.ToList();
            if (hockeyPlayerParams != null)
            {
                savedRosters = savedRosters.Where(roster => (hockeyPlayerParams.position == null || hockeyPlayerParams.position == roster.position) &&
                                                        (roster.birthday >= hockeyPlayerParams.birthdayFrom && roster.birthday <= hockeyPlayerParams.birthdayTo) &&
                                                        (hockeyPlayerParams.weightTo >= roster.weight && hockeyPlayerParams.weightFrom <= roster.weight) &&
                                                        (hockeyPlayerParams.heightTo >= roster.height && hockeyPlayerParams.heightFrom <= roster.height) &&
                                                        (String.Compare(roster.playerid, ID) == 0)).ToList();
            }
            else
            {
                savedRosters = savedRosters.Where(roster => (String.Compare(roster.playerid, ID) == 0)).ToList();
            }
            p.Data = savedRosters[0].photo;
            return View(p);
        }
        public ActionResult GetImage(string ID)
        {
            //var Player = db.hockeyPlayer.ToList();
            //int i = 0;
            
            var savedRosters = db.hockeyPlayer.ToList();
            if (hockeyPlayerParams != null)
            {
                savedRosters = savedRosters.Where(roster => (hockeyPlayerParams.position == null || hockeyPlayerParams.position == roster.position) &&
                                                        (roster.birthday >= hockeyPlayerParams.birthdayFrom && roster.birthday <= hockeyPlayerParams.birthdayTo) &&
                                                        (hockeyPlayerParams.weightTo >= roster.weight && hockeyPlayerParams.weightFrom <= roster.weight) &&
                                                        (hockeyPlayerParams.heightTo >= roster.height && hockeyPlayerParams.heightFrom <= roster.height) &&
                                                        (String.Compare(roster.playerid, ID) == 0)).ToList();
            }
            else
            {
                savedRosters = savedRosters.Where(roster => (String.Compare(roster.playerid, ID) == 0)).ToList();
            }
            byte[] bytes = savedRosters[0].photo;
            return File(bytes, "image/jpg");
        }
    }
}

