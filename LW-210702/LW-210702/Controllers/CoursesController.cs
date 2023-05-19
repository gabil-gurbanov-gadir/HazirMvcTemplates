using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LW_210702.Models;
using Microsoft.AspNetCore.Mvc;


namespace LW_210702.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            List<Course> courses = new List<Course>{
                new Course()
                {
                    Id = 1,
                    Name = "Website Design",
                    Description = "Et architecto provident deleniti facere" +
                    " repellat nobis iste. Id facere quia quae dolores dolorem " +
                    "tempore.",
                    ImgName = "course-1.jpg",
                    Category = "Web Development",
                    Price = 169,
                    TeacherName = "Antonio",
                    TeacherImgName = "trainer-1.jpg"
                },
                new Course()
                {
                    Id = 2,
                    Name = "Search Engine Optimization",
                    Description = "Et architecto provident deleniti facere" +
                    " repellat nobis iste. Id facere quia quae dolores dolorem " +
                    "tempore.",
                    ImgName = "course-2.jpg",
                    Category = "Marketing",
                    Price = 250,
                    TeacherName = "Lana",
                    TeacherImgName = "trainer-2.jpg"
                },
                new Course()
                {
                    Id = 3,
                    Name = "Copywriting",
                    Description = "Et architecto provident deleniti facere" +
                    " repellat nobis iste. Id facere quia quae dolores dolorem " +
                    "tempore.",
                    ImgName = "course-3.jpg",
                    Category = "Content",
                    Price = 180,
                    TeacherName = "Brandon",
                    TeacherImgName = "trainer-3.jpg"
                }
            };
            
            return View(courses);
        }
        public IActionResult Details(int id)
        {
            List<Course> courses = new List<Course>{
                new Course()
                {
                    Id = 1,
                    Name = "Website Design",
                    Description = "Et architecto provident deleniti facere" +
                    " repellat nobis iste. Id facere quia quae dolores dolorem " +
                    "tempore.",
                    ImgName = "course-1.jpg",
                    Category = "Web Development",
                    Price = 169,
                    TeacherName = "Antonio",
                    TeacherImgName = "trainer-1.jpg"
                },
                new Course()
                {
                    Id = 2,
                    Name = "Search Engine Optimization",
                    Description = "Et architecto provident deleniti facere" +
                    " repellat nobis iste. Id facere quia quae dolores dolorem " +
                    "tempore.",
                    ImgName = "course-2.jpg",
                    Category = "Marketing",
                    Price = 250,
                    TeacherName = "Lana",
                    TeacherImgName = "trainer-2.jpg"
                },
                new Course()
                {
                    Id = 3,
                    Name = "Copywriting",
                    Description = "Et architecto provident deleniti facere" +
                    " repellat nobis iste. Id facere quia quae dolores dolorem " +
                    "tempore.",
                    ImgName = "course-3.jpg",
                    Category = "Content",
                    Price = 180,
                    TeacherName = "Brandon",
                    TeacherImgName = "trainer-3.jpg"
                }
            };

            Course course = courses.Find(c=>c.Id == id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }
    }
}
