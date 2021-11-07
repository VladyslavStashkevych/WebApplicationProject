using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppProject.Models {
    public class Expense {
        [Key]
        public int Id { get; set; }
        [DisplayName("Purchase")]
        [Required]
        public string PurchaseName { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Amount must be greater than 0.")]
        public double Cost { get; set; }
    }
}
