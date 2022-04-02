using asptask1.Entities;
using asptask1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptask1.Controllers
{
    public class HomeController : Controller
    {
        List<Drink> drinks = new List<Drink>
            {
               
                new Drink {Id=2,  Name="Fanta", Price= 11},
                new Drink {Id=3,  Name="Juice", Price= 12},
                new Drink {Id=4,   Name="Coca-Cola", Price= 13},
               
            };
        List<HotMeal> hotmeals = new List<HotMeal>
            {
                new HotMeal {Id=1, Name="Minestrone Soup", Price= 20},
                new HotMeal {Id=2,  Name="Seasoned Rice", Price= 19},
                new HotMeal {Id=3,  Name="Apple Crisp", Price= 22},
               
            };
        List<FastFood> fastfoods = new List<FastFood>
            {
                new FastFood {Id=1,  Name="Hamburger", Price= 15},
                new FastFood {Id=3,   Name="Pizza", Price= 18},
                new FastFood {Id=3,   Name="Burrito", Price= 18},
               
            }; 
        public IActionResult Drink()
        {
            return View(drinks);
        }
        public IActionResult FastFood()
        {
            return View(fastfoods);
        }
        public IActionResult Index()
        {


            return View();
        }
       
        public IActionResult HotMeal()
        {
            return View(hotmeals);
        }
       

    }
}

