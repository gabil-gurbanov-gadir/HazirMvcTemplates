using LabPages1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabPages1.ViewModels
{
    public class HomeViewModel
    {
        public List<Blog> Blogs { get; set; }
        public List<Service> Services { get; set; }
    }
}
