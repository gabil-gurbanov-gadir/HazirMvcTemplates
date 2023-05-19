using System;
using System.Collections.Generic;

namespace LW_Restourantly.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<MealCategory> MealCategories { get; set; }
        public List<Meal> Meals { get; set; }
    }
}
