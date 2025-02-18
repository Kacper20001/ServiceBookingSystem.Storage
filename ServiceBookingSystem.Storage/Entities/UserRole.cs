using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBookingSystem.Storage.Entities
{
    [Table("UserRoles")]
    public class UserRole
    {
        [Key]
        [Column(Order = 1)]
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
