using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBookingSystem.Storage.Entities
{
    [Table("Roles")]
    public class Role
    {
        private Role() { }
        public Role(string name, bool canManageUsers = false, bool canManageServices = false, bool canManagePayments =false) {
            Name = name;
            CanManageUsers = canManageUsers;
            CanManageServices = canManageServices;
            CanManagePayments = canManagePayments;
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public bool CanManageUsers { get; set; } = false;
        public bool CanManageServices { get; set; } = false;
        public bool CanManagePayments { get; set; } = false;
        public ICollection<UserRole> UserRoles { get; set; }

    }
}
