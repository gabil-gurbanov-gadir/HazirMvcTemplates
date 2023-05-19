using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LW_Restourantly.Models;
using LW_Restourantly.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LW_Restourantly.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Bio bio = new Bio()
            {
                Id = 1,
                OpenHourseSmall = "Mon-Sat: 11AM - 23PM",
                OpenHourseBig = "Monday-Saturday: 11:00 AM - 2300 PM",
                Street = "A108 Adam Street",
                City = "New York",
                ZipCode = "NY 535022",
                Country = "USA",
                Phone = "+1 5589 55488 55",
                Email = "info@example.com"
            };
            MealCategory starters = new MealCategory()
            {
                Id = 1,
                Name = "Starters",
                DataName = "starters"
            };
            MealCategory salads = new MealCategory()
            {
                Id = 2,
                Name = "Salads",
                DataName = "salads"
            };
            MealCategory specialty = new MealCategory()
            {
                Id = 3,
                Name = "Specialty",
                DataName = "specialty"
            };
            
            List<MealCategory> mealCategories = new List<MealCategory>()
            {
                starters,salads,specialty
            };
            List<Meal> meals = new List<Meal>()
            {
                new Meal()
                    {
                        Id = 1,
                        MealCategory = starters,
                        ImgName = "lobster-bisque.jpg",
                        Name = "Lobster Bisque",
                        Price = 5.95m,
                        Ingredients = "Lorem, deren, trataro, filede, nerada"

                    },
                    new Meal()
                    {
                        Id = 2,
                        MealCategory = specialty,
                        ImgName = "bread-barrel.jpg",
                        Name = "Bread Barrel",
                        Price = 6.95m,
                        Ingredients = "Lorem, deren, trataro, filede, nerada"

                    },
                    new Meal()
                    {
                        Id = 3,
                        MealCategory = starters,
                        ImgName = "cake.jpg",
                        Name = "Crab Cake",
                        Price = 7.95m,
                        Ingredients = "A delicate crab cake served on a toasted " +
                        "roll with lettuce and tartar sauce"

                    },
                    new Meal()
                    {
                        Id = 4,
                        MealCategory = salads,
                        ImgName = "caesar.jpg",
                        Name = "Caesar Selections",
                        Price = 8.95m,
                        Ingredients = "Lorem, deren, trataro, filede, nerada"

                    },
                    new Meal()
                    {
                        Id = 5,
                        MealCategory = specialty,
                        ImgName = "tuscan-grilled.jpg",
                        Name = "Tuscan Grilled",
                        Price = 9.95m,
                        Ingredients = "Grilled chicken with provolone, " +
                        "artichoke hearts, and roasted red pesto"

                    },
                    new Meal()
                    {
                        Id = 6,
                        MealCategory = starters,
                        ImgName = "mozzarella.jpg",
                        Name = "Mozzarella Stick",
                        Price = 4.95m,
                        Ingredients = "Lorem, deren, trataro, filede, nerada"

                    },
                    new Meal()
                    {
                        Id = 7,
                        MealCategory = salads,
                        ImgName = "greek-salad.jpg",
                        Name = "Greek Salad",
                        Price = 9.95m,
                        Ingredients = "Fresh spinach, crisp romaine, tomatoes, and Greek olives"

                    },
                    new Meal()
                    {
                        Id = 8,
                        MealCategory = salads,
                        ImgName = "spinach-salad.jpg",
                        Name = "Spinach Salad",
                        Price = 9.95m,
                        Ingredients = "Fresh spinach with mushrooms, hard boiled egg, and warm bacon vinaigrette"

                    },
                    new Meal()
                    {
                        Id = 9,
                        MealCategory = specialty,
                        ImgName = "lobster-roll.jpg",
                        Name = "Lobster Roll",
                        Price = 12.95m,
                        Ingredients = "Plump lobster meat, mayo and crisp lettuce on a toasted bulky roll"

                    }
            };
            Menu menu = new Menu()
            {
                Id = 1,
                Title = "Check Our Tasty Menu",
                MealCategories = mealCategories,
                Meals = meals

            };
            List<Special> specials = new List<Special>()
            {
                new Special()
                {
                    Id = 1,
                    Name = "Modi sit est",
                    Title = "Et blanditiis nemo veritatis excepturi",
                    Ingredients = "Qui laudantium consequatur laborum sit qui " +
                    "ad sapiente dila parde sonata raqer a videna mareta " +
                    "paulona marka",
                    Destination = "Et nobis maiores eius. Voluptatibus ut " +
                    "enim blanditiis atque harum sint. Laborum eos ipsum " +
                    "ipsa odit magni. Incidunt hic ut molestiae aut qui. " +
                    "Est repellat minima eveniet eius et quis magni nihil. " +
                    "Consequatur dolorem quaerat quos qui similique accusamus " +
                    "nostrum rem vero",
                    ImgName = "specials-1.png"
                },
                new Special()
                {
                    Id = 2,
                    Name = "Unde praesentium sed",
                    Title = "Architecto ut aperiam autem id",
                    Ingredients = "Qui laudantium consequatur laborum sit qui ad sapiente dila parde sonata raqer a videna mareta paulona marka",
                    Destination = "Ea ipsum voluptatem consequatur quis est. Illum error ullam omnis quia et reiciendis sunt sunt est. Non aliquid repellendus itaque accusamus eius et velit ipsa voluptates. Optio nesciunt eaque beatae accusamus lerode pakto madirna desera vafle de nideran pal",
                    ImgName = "specials-2.png"
                },
                new Special()
                {
                    Id = 3,
                    Name = "Pariatur explicabo vel",
                    Title = "Impedit facilis occaecati odio neque aperiam sit",
                    Ingredients = "Eos voluptatibus quo. Odio similique illum id quidem non enim fuga. Qui natus non sunt dicta dolor et. In asperiores velit quaerat perferendis aut",
                    Destination = "Iure officiis odit rerum. Harum sequi eum illum corrupti culpa veritatis quisquam. Neque necessitatibus illo rerum eum ut. Commodi ipsam minima molestiae sed laboriosam a iste odio. Earum odit nesciunt fugiat sit ullam. Soluta et harum voluptatem optio quae",
                    ImgName = "specials-3.png"
                },
                new Special()
                {
                    Id = 4,
                    Name = "Nostrum qui quasi",
                    Title = "Fuga dolores inventore laboriosam ut est accusamus laboriosam dolore",
                    Ingredients = "Totam aperiam accusamus. Repellat consequuntur iure voluptas iure porro quis delectus",
                    Destination = "Eaque consequuntur consequuntur libero expedita in voluptas. Nostrum ipsam necessitatibus aliquam fugiat debitis quis velit. Eum ex maxime error in consequatur corporis atque. Eligendi asperiores sed qui veritatis aperiam quia a laborum inventore",
                    ImgName = "specials-4.png"
                },
                new Special()
                {
                    Id = 5,
                    Name = "Iusto ut expedita aut",
                    Title = "Est eveniet ipsam sindera pad rone matrelat sando reda",
                    Ingredients = "Omnis blanditiis saepe eos autem qui sunt debitis porro quia.",
                    Destination = "Exercitationem nostrum omnis. Ut reiciendis repudiandae minus. Omnis recusandae ut non quam ut quod eius qui. Ipsum quia odit vero atque qui quibusdam amet. Occaecati sed est sint aut vitae molestiae voluptate vel",
                    ImgName = "specials-5.png"
                }
            };
            List<Event> events = new List<Event>()
            {
                new Event()
                {
                    Id = 1,
                    ImgName = "event-birthday.jpg",
                    Name = "Birthday Parties",
                    Price = 189m
                },
                new Event()
                {
                    Id = 2,
                    ImgName = "event-private.jpg",
                    Name = "Private Parties",
                    Price = 290m
                },
                new Event()
                {
                    Id = 3,
                    ImgName = "event-custom.jpg",
                    Name = "Custom Parties",
                    Price = 99m
                }
            };
            List<Testimonial> testimonials = new List<Testimonial>()
            {
                new Testimonial()
                {
                    Id = 1,
                    Comment = "Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.",
                    ImgName = "testimonials-1.jpg",
                    Fullname = "Saul Goodman",
                    Position = "Ceo &amp; Founder"
                },
                new Testimonial()
                {
                    Id = 2,
                    Comment = "Export tempor illum tamen malis malis eram quae irure esse labore quem cillum quid cillum eram malis quorum velit fore eram velit sunt aliqua noster fugiat irure amet legam anim culpa.",
                    ImgName = "testimonials-2.jpg",
                    Fullname = "Sara Wilsson",
                    Position = "Designer"
                },
                new Testimonial()
                {
                    Id = 3,
                    Comment = "Enim nisi quem export duis labore cillum quae magna enim sint quorum nulla quem veniam duis minim tempor labore quem eram duis noster aute amet eram fore quis sint minim.",
                    ImgName = "testimonials-3.jpg",
                    Fullname = "Jena Karlis",
                    Position = "Store Owner"
                },
                new Testimonial()
                {
                    Id = 4,
                    Comment = "Fugiat enim eram quae cillum dolore dolor amet nulla culpa multos export minim fugiat minim velit minim dolor enim duis veniam ipsum anim magna sunt elit fore quem dolore labore illum veniam.",
                    ImgName = "testimonials-4.jpg",
                    Fullname = "Matt Brandon",
                    Position = "Freelancer"
                },
                new Testimonial()
                {
                    Id = 5,
                    Comment = "Quis quorum aliqua sint quem legam fore sunt eram irure aliqua veniam tempor noster veniam enim culpa labore duis sunt culpa nulla illum cillum fugiat legam esse veniam culpa fore nisi cillum quid.",
                    ImgName = "testimonials-5.jpg",
                    Fullname = "John Larson",
                    Position = "Entrepreneur"
                }
            };
            List<Chef> chefs = new List<Chef>()
            {
                new Chef()
                {
                    Id = 1,
                    Fullname = "Walter White",
                    Position = "Master Chef",
                    ImgName = "chefs-1.jpg"
                },
                new Chef()
                {
                    Id = 2,
                    Fullname = "Sarah Jhonson",
                    Position = "Patissier",
                    ImgName = "chefs-2.jpg"
                },
                new Chef()
                {
                    Id = 3,
                    Fullname = "William Anderson",
                    Position = "Cook",
                    ImgName = "chefs-3.jpg"
                }
            };


            HomeViewModel homeViewModel = new HomeViewModel()
            {
                Bio = bio,
                Menu = menu,
                Specials = specials,
                Events = events,
                Testimonials = testimonials,
                Chefs = chefs

            };
            return View(homeViewModel);
        }
    }
}
