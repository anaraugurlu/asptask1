using asptask1.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptask1.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index()
        {
            return View();
        }

        public IActionResult Drink()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink {Id=1,Name="cola",Price=5},
                new Drink {Id=2,Name="fanta",Price=3},
                new Drink {Id=3,Name="pepsi",Price=2}
            };
           
            return View(drinks );
        }
        public IActionResult HotMeal()
        {
            List<HotMeal> hotmeal = new List<HotMeal>
            {
                new HotMeal {Id=1,Name="dolma",Price=25},
                new HotMeal {Id=2,Name="kabab",Price=30},
                new HotMeal {Id=3,Name="levengi",Price=20}
            };

            return View(hotmeal);
        }
        public IActionResult FastFood()
        {
            List<FastFood> fastfoods = new List<FastFood>
            {
                new FastFood {Id=1,Name="burger",Price=25},
                new FastFood {Id=2,Name="pizza",Price=30},
                new FastFood {Id=3,Name="lahmacun",Price=20}
            };

            return View(fastfoods);
        }

    }
}
