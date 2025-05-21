using InventoryManager.Api.Mediator.Commands;
using InventoryManager.Api.Repositories.Interfaces;
using Inventorymanager.Api.Responses;
using InventoryManager.Infrastructure.Models;
using MediatR;

namespace InventoryManager.Api.Mediator.Handlers;


public class GetAllStockTransactionHanlder : IRequestHandler<FilterCommand, List<AllStockTransactionRespose>>
{
    private readonly IProductRepository _productRepository;

    public GetAllStockTransactionHanlder(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<List<AllStockTransactionRespose>> Handle(FilterCommand command, CancellationToken cancellationToken)
    {
        try
        {
            var result = _productRepository.GetAllStockTransaction(command);
            return result;
        }
        catch (Exception a)
        {
            Console.WriteLine(a);
            throw;
        }
    }
}