using System;
using System.ComponentModel.DataAnnotations;

namespace dev42.Keval.Dotnet_API.Models
{
    public class Country
    {
        [Key]
        public Guid Id { get; set; }
        
        [StringLength(50)]
        [Required(ErrorMessage = "This Field is Mandatory*")]
        public string Name { get; set; }
        [StringLength(20)]
        [Required(ErrorMessage = "This Field is Mandatory*")]
        public string Code { get; set; }

    }
}