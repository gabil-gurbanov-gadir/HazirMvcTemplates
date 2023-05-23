using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabPages1.Models
{
    public class BarberXContext:DbContext
    {
        public BarberXContext(DbContextOptions<BarberXContext> opt):base(opt)
        {

        }

        public DbSet<Setting> Settings { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<BlogService> BlogServices { get; set; }
    }
}
