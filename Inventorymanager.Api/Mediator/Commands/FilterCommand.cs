using Inventorymanager.Api.Responses;
using InventoryManager.Infrastructure.Models;
using MediatR;

namespace InventoryManager.Api.Mediator.Commands;


public class FilterCommand : IRequest<List<AllStockTransactionRespose>>
{
    public string? ProductName { get; set; }
    public string? TransactionType { get; set; }
    public DateTime? TransactionDate { get; set; }
}