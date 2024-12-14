using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    internal class OrderDetails
    {
        [Key]
        public String OrderDetailsId { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public String ? OrderId { get; set; }
        [Required]
        public String FooditemId { get; set; } = String.Empty;
        [Required]
        public String ?  Quantity { get; set; }
        [Required]
        public String Foodprice { get; set;} = String.Empty;    
    }
}
