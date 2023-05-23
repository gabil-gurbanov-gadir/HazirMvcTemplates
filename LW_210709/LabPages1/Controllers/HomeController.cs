using LabPages1.Models;
using LabPages1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabPages1.Controllers
{
    public class HomeController : Controller
    {
        //private readonly BarberXContext _context;

        //public HomeController(BarberXContext context)
        //{
        //    _context = context;
        //}
        public IActionResult Index()
        {
            //HomeViewModel homeViewModel = new HomeViewModel()
            //{
            //    Blogs = _context.Blogs.Include(b => b.BlogServices).ThenInclude(bs=>bs.Service).ToList(),
            //    Services = _context.Services.ToList()
            //};
            //return View(homeViewModel);
            return View();
        }
    }
}
