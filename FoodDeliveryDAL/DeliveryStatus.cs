using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryDAL
{
    public class DeliveryStatus
    {
        [Key]
        public int DeliveryStatusId { get; set; }

        [Required]
        [StringLength(50)]
        [Index(IsUnique = true)] // Ensure unique status names
        public string StatusName { get; set; }
    }
}
