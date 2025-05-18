using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Infrastructure.Models;

[Table("StockTransactionTb")]
public class StockTransactionModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int StockTransactionId { get; set; }

    public int ProductId { get; set; }
    public ProductModel Product { get; set; } = null!;

    public int Quantity { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(10)")]
    public string TransactionType { get; set; } // IN = รับเข้า, OUT = จ่ายออก
    
    public DateTime TransactionDate { get; set; } = DateTime.Now;
}