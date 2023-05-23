using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabPages1.Models
{
    public class BlogService
    {
        public int Id { get; set; }

        public int BlogId { get; set; }

        public Blog Blog { get; set; }

        public int ServiceId { get; set; }

        public Service Service { get; set; }
    }
}
