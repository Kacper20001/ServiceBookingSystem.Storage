using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBookingSystem.Storage.Entities
{
    [Table("Users")]
    public class User
    {
        private User() { }
        public User(string fullName, string email, string passwordHash, DateTime dateOfBirth)
        {
            FullName = fullName;
            Email = email;
            PasswordHash = passwordHash;
            DateOfBirth = dateOfBirth;
            RegisteredAt = DateTime.UtcNow;
            IsVerified = false;
            IsActive = true;
        }
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(150)]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Phone]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [Url]
        public string AvatarUrl { get; set; }

        public DateTime DateOfBirth { get; set; }

        public bool IsVerified { get; set; } = false;

        public bool IsActive { get; set; } = true;

        public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;

        public DateTime LastLogin { get; set; }

        public int? AddressId { get; set; }
        public Address Address { get; set; }    

        public ICollection<Role> Roles { get; set; }
        public ICollection<Service> Services { get; set; }  
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Review> Reviews { get; set; }

    }
}
