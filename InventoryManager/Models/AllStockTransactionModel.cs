namespace Inventorymanager.Models;

public class AllStockTransactionModel
{
    public int? ProductId { get; set; }
    public string? ProductName { get; set; }
    public int? Quantity { get; set; }
    public string? TransactionType { get; set; }
    public DateTime? TransactionDate { get; set; }
    
}