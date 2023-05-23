﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LabPages1.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength:50)]
        public string Title { get; set; }


        [Required]
        [StringLength(maximumLength: 500)]
        public string Desc { get; set; }

        public DateTime BlogTime { get; set; }

        public List<BlogService> BlogServices { get; set; }
    }
}
