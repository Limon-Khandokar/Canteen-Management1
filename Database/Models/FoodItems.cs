using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    internal class FoodItems
    {
        [Key]
        public String FoodItemId { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public String ? FoodName { get; set; }
        [Required]
        public String FoodType { get; set; }
        [Required]
        public String FoodDescription { get; set; }
        [Required]
        public String FoodPrice { get; set; } = String.Empty;
        [Required]
        public bool IsAvalable { get; set; }

        


    }
}
