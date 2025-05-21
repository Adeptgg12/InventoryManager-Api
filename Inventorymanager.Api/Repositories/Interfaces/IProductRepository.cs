

using InventoryManager.Api.Mediator.Commands;
using Inventorymanager.Api.Responses;
using InventoryManager.Infrastructure.Models;

namespace InventoryManager.Api.Repositories.Interfaces
{
    public interface IProductRepository
    {
        int AddProduct(AddProductCommand product);
        public List<ProductDto> GetAllProducts();
        public List<AllStockTransactionRespose> GetAllStockTransaction(FilterCommand command);
        dynamic OutProduct(OutProductCommand product);
    }
}
