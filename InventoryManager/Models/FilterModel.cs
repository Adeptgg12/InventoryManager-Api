using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Models
{
    public class FilterModel
    {
        public int? ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? TransactionType { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
