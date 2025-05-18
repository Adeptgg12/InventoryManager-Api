using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Infrastructure.Models;

[Table("ProductTb")]

public class ProductModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductId { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(200)")]
    public string ProductName { get; set; }
    

    [Column(TypeName = "nvarchar(50)")]
    public string Unit { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public ICollection<StockTransactionModel> StockTransactions { get; set; } = new List<StockTransactionModel>();
}