using InventoryManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManager.Infrastructure.Models;

namespace InventoryManager.Repositories.Interfaces
{
    public interface IProductRepository
    {
        int AddProduct(ProductModelInput product);
        public List<ProductModel> GetAllProducts();
        public List<StockTransactionModel> GetAllStockTransaction(FilterModel filterData);
        dynamic OutProduct(ProductModelInput product);
    }
}
