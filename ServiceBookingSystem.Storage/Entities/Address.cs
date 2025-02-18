using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBookingSystem.Storage.Entities
{
    [Table("Addresses")]
    public class Address
    {
        protected Address() { }
        public Address (string street, string city, string postalCode, string country)
        {
            Street = street;
            City = city;
            PostalCode = postalCode;
            Country = country;
        }
        [Key]
        public int Id { get; set; } 

        [Required]
        [MaxLength(100)]
        public string Street { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }    

        [Required]
        [MaxLength(10)]
        public string PostalCode { get; set; }

        [Required]
        [MaxLength(50)]
        public string Country { get; set; }
    }
}
