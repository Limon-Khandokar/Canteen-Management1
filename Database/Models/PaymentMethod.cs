using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    internal class PaymentMethod
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PaymentMethodName { get; set; }
        public bool IsActive { get; set; }
    }
}
