using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBookingSystem.Storage.Entities
{
    [Table("Reviews")]
    public class Review
    {
        protected Review() { }
        public Review(string userId, int serviceId, int rating, string comment)
        {
            UserId = userId;
            ServiceId = serviceId;
            Rating = rating;
            Comment = comment;

        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }
        public User User { get; set; }

        [Required]
        public int ServiceId { get; set; }
        public Service Service { get; set; }

        [Required]
        [Range(1,5, ErrorMessage = "The rating must be from 1 to 5.")]
        public int Rating {  get; set; }

        [MaxLength(1000)]
        public string Comment { get; set; }

        public DateTime CreatAt { get; set; }
    }
}
