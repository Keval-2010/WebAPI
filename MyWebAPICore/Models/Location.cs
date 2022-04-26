using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dev42.Keval.Dotnet_API.Models
{
    public class Location
    {
        [Key]
        public Guid Id { get; set; }
        public Company Company { get; set; }
        [Required]
        public Guid CompanyId { get; set; }

        [StringLength(100)]
        [Required]
        public string Address { get; set; }

        [StringLength(50)]
        [Required]
        public string City { get; set; }

        [StringLength(50)]
        [Required]
        public string Province { get; set; }

        [StringLength(20)]
        [Required]
        public string PostalCode { get; set; }
        public Country Country { get; set; }
        public Guid CountryId { get; set; }
        
        [StringLength(20)]
        public string OtherCountry { get; set; }

        public bool IsPrimary { get; set; }
    }
}