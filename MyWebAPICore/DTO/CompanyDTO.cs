using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MyWebAPICore.DTO
{

    public class CompanyDTO
    {

        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Website { get; set; }

        public IEnumerable<LocationDTO> Locations { get; set; }
        
        
    }
}