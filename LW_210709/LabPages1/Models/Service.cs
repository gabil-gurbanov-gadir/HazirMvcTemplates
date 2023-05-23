using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LabPages1.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength:50)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string ImgName { get; set; }

        public List<BlogService> BlogServices { get; set; }
    }
}
