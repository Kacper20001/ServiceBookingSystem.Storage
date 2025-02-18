using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBookingSystem.Storage.Entities
{
    [Table("Payments")]
    public class Payment
    {
        protected Payment() { }
        public Payment(string userId, int reservationId, decimal amount)
        {
            UserId = userId;
            ReservationId = reservationId;
            Amount = amount;
        }
        [Key]
        public int Id { get; set; }

        public string UserId {  get; set; }
        public User User { get; set; }

        public int ReservationId { get; set; }  
        public Reservation Reservation { get; set; }

        [Required]
        public decimal Amount {  get; set; }

    }
}
