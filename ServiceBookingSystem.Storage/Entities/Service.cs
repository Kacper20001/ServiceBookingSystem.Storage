using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBookingSystem.Storage.Entities
{
    [Table("Services")]
    public class Service
    {
        protected Service() { }
        public Service(string name, string description, decimal price, int categoryId, string providerId)
        {
            Name = name;
            Description = description;
            Price = price;
            CategoryId = categoryId;
            ProviderId = providerId;
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }  
        
        public double AverageRating { get; set; }
        
        public int CategoryId {  get; set; }
        public ServiceCategory Category { get; set; }

        public string ProviderId { get; set; } 
        public User Provider { get; set; }  

        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Review> Reviews { get; set; }
        
    }
}
