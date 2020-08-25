using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesBoard_s321853_MelishaSuzaneLafaber.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string CartId { get; set; }
        public int Item { get; set; }
        public int Quantity { get; set; }
    }
}
