using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LabPages1.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:25)]
        public string LogoName { get; set; }

        [Required]
        [StringLength(maximumLength: 25)]
        public string Phone { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Email { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Street { get; set; }

        [Required]
        [StringLength(maximumLength: 25)]
        public string City { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string Country { get; set; }

        [Required]
        [StringLength(maximumLength: 500)]
        public string HomeTitle { get; set; }


    }
}
