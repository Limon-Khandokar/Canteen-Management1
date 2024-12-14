using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    internal class Payment
    {
        [Key]
        public String PaymentId { get; set; } = Guid.NewGuid().ToString();
        public String ? OrderId { get; set; }
        public String PaymentMethod { get; set; } //Cash,Card,Online
        public String PaymentDate { get; set; }
        public double PaymentAmount { get; set; }
    }
}
