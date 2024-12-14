using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    internal class FeedBack
    {
        [Key]
        public String FeedbackId { get; set; } = Guid.NewGuid().ToString();
        
        public String ? UserId { get; set; }
        
        public String? UserName { get; set; }
        public String? OrderId { get; set; }
        [Required]
        public String ? Comments { get; set; }
        public int Rating { get; set; } //1 - 5 star 
    }
}
