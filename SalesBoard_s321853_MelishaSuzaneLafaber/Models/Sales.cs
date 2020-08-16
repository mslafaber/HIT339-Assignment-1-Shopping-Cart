using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesBoard_s321853_MelishaSuzaneLafaber.Models
{
    public class Sales
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int Item { get; set; }
        public string Buyer { get; set; }
        public int Quantity { get; set; }
    }
}
