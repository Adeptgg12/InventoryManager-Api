using InventoryManager.Api.Mediator.Commands;
using InventoryManager.Api.Repositories.Interfaces;
using Inventorymanager.Api.Responses;
using MediatR;

namespace InventoryManager.Api.Mediator.Handlers;


public class OutProductHandler : IRequestHandler<OutProductCommand, BaseResponse>
{
    private readonly IProductRepository _productRepository;

    public OutProductHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<BaseResponse> Handle(OutProductCommand command, CancellationToken cancellationToken)
    {
        try
        {
            var result = _productRepository.OutProduct(command);
            if (result == 1)
            {
                return new BaseResponse
                {
                    Status = "Product Outed successfully"
                };
            }
            else if (result == 2)
            {
                return new BaseResponse
                {
                    Status = "ไม่สามารถลบสินค้าได้เนื่องจากจำนวนสินค้าในคลังไม่เพียงพอ"
                };
                
            }
            else if (result == 3)
            {
                return new BaseResponse
                {
                    Status = "ไม่พบสินค้าที่ต้องการลบ"
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