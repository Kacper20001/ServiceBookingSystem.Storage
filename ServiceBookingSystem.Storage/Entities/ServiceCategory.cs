using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBookingSystem.Storage.Entities
{
    [Table("ServiceCategories")]
    public class ServiceCategory
    {
        private ServiceCategory() { }
        public ServiceCategory (string name)
        {
            Name = name;
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
