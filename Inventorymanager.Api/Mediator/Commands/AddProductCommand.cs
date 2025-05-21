using Inventorymanager.Api.Responses;
using MediatR;

namespace InventoryManager.Api.Mediator.Commands;

public class AddProductCommand : IRequest<BaseResponse>
{
    public string ProductName { get; set; }
    public int Unit { get; set; }
}