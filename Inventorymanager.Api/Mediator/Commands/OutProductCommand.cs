using Inventorymanager.Api.Responses;
using MediatR;

namespace InventoryManager.Api.Mediator.Commands;

public class OutProductCommand : IRequest<BaseResponse>
{
    public string ProductName { get; set; }
    public int Unit { get; set; }
}