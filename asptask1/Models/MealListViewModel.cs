using asptask1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptask1.Models
{
    public class MealListViewModel
    {
        public  List<HotMeal> HotMeals { get; set; }
        public List<FastFood> FastFoods { get; set; }
        public List<Drink> Drinks { get; set; }

    }
}
