using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBookingSystem.Storage.Entities
{
    [Table("Reservations")]
    public class Reservation
    {
        protected Reservation() { }
        public Reservation(DateTime date, int serviceId, string userId)
        {
            Date = date;
            ServiceId = serviceId;
            UserId = userId;
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public int ServiceId;
        public Service Service { get; set; }

        public string UserId {  get; set; }    
        public User User { get; set; }  
    }
}
