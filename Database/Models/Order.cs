using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    internal class Order
    {
        [Key]
        public String OrderId { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public String ? UserId { get; set; }
        [Required]
        public String ? OrderDate { get; set; }
        [Required]
        public String ? TotalAmount { get; set; }
        [Required]
        public String? TotalPrice { get; set; } 
        public String? OrderStatus { get; set; }  //Pending ,Completed,Canceled

    }
}
