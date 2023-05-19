using System;
namespace LW_Restourantly.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public decimal Price { get; set; }
        public string ImgName { get; set; }
        public MealCategory MealCategory { get; set; }
    }
}
