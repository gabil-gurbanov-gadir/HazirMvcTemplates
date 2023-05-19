using System;
using System.Collections.Generic;
using LW_Restourantly.Models;

namespace LW_Restourantly.ViewModels
{
    public class HomeViewModel
    {
        public Bio Bio { get; set; }
        public Menu Menu { get; set; }
        public List<Special> Specials { get; set; }
        public List<Event> Events { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Chef> Chefs { get; set; }
    }
}
