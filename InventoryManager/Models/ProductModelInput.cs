using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Models
{
    public class ProductModelInput
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Unit { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
