using InventoryManager.Api.Mediator.Commands;
using InventoryManager.Api.Repositories.Interfaces;
using Inventorymanager.Api.Responses;
using MediatR;

namespace InventoryManager.Api.Mediator.Handlers;


public class AddProductHandler : IRequestHandler<AddProductCommand, BaseResponse>
{
    private readonly IProductRepository _productRepository;

    public AddProductHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<BaseResponse> Handle(AddProductCommand command, CancellationToken cancellationToken)
    {
        try
        {
            var result = _productRepository.AddProduct(command);
            if (result > 0)
            {
                return new BaseResponse
                {
                    Status = "Success"
                };
            }
            return new BaseResponse
            {
                Status = "Failed"
            };
        }
        catch (Exception a)
        {
            Console.WriteLine(a);
            throw;
        }
    }
}