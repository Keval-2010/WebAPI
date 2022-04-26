using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dev42.Keval.Dotnet_API.Models
{
    public class Company
    {
        public Company()
        {
            var Locations = new HashSet<Location>();
             
        }
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "This Field is Mandatory*")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "This Field is Mandatory*")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }


        [StringLength(20)]

        public string Phone { get; set; }


        [StringLength(50)]
        public string Website { get; set; }

        public ICollection<Location> Locations { get; set; }

    }
}