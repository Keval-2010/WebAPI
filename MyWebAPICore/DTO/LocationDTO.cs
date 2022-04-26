using System;
using System.ComponentModel.DataAnnotations;

namespace MyWebAPICore.DTO
{
    public class LocationDTO
    {

        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(50)]
        public string Province { get; set; }
        [StringLength(20)]
        public string PostalCode { get; set; }
        public Guid CountryId { get; set; }
        [StringLength(20)]
        public string OtherCountry { get; set; }
        public bool IsPrimary { get; set; }
    }
}