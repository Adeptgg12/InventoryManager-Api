using InventoryManager.Infrastructure;
using InventoryManager.Infrastructure.Models;
using InventoryManager.Models;
using InventoryManager.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InventoryManager.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly InventoryManagerDbContext _context;

        public ProductRepository(InventoryManagerDbContext context)
        {
            _context = context;
        }
        public int AddProduct(ProductModelInput productInput)
        {
            try
            {
                var existProduct = _context.ProductTb.FirstOrDefault(p => p.ProductName == productInput.ProductName);

                if (existProduct == null)
                {
                    var newProduct = new ProductModel
                    {
                        ProductName = productInput.ProductName,
                        Unit = productInput.Unit.ToString(),
                        CreatedAt = DateTime.Now,
                    };
                    _context.ProductTb.Add(newProduct);
                    _context.SaveChanges();

                    var transaction = new StockTransactionModel
                    {
                        ProductId = newProduct.ProductId,
                        Quantity = productInput.Unit,
                        TransactionType = "In",
                        TransactionDate = DateTime.Now
                    };
                    _context.StockTransactionTb.Add(transaction);
                }
                else
                {
                    int currentUnit = int.TryParse(existProduct.Unit, out var parsedUnit) ? parsedUnit : 0;
                    existProduct.Unit = (currentUnit + productInput.Unit).ToString();
                    var transaction = new StockTransactionModel
                    {
                        ProductId = existProduct.ProductId,
                        Quantity = productInput.Unit,
                        TransactionType = "In",
                        TransactionDate = DateTime.Now
                    };
                    _context.StockTransactionTb.Add(transaction);
                }
                return _context.SaveChanges();
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
                throw;
            }
            
        }

        public List<ProductModel> GetAllProducts()
        {
            try
            {
                return _context.ProductTb.ToList();
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
                throw;
            }
        }

        public List<StockTransactionModel> GetAllStockTransaction(FilterModel filterData = null)
        {
            try
            {
                var query = _context.StockTransactionTb.Include(t => t.Product).AsQueryable();

                if (filterData != null)
                {
                    if (!string.IsNullOrWhiteSpace(filterData.ProductName))
                    {
                        var product = _context.ProductTb.FirstOrDefault(p => p.ProductName == filterData.ProductName);
                        if (product != null)
                        {
                            query = query.Where(s => s.ProductId == product.ProductId);
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(filterData.TransactionType))
                    {
                        query = query.Where(s => s.TransactionType == filterData.TransactionType);
                    }

                    if (filterData.TransactionDate.HasValue)
                    {
                        // เฉพาะวันที่ (ไม่สนเวลา)
                        var dateOnly = filterData.TransactionDate.Value.Date;
                        query = query.Where(s => s.TransactionDate.Date == dateOnly);
                    }
                }

                return query.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }


        public dynamic OutProduct(ProductModelInput product)
        {
            try
            {
                var getproduct = _context.ProductTb.FirstOrDefault(p => p.ProductName == product.ProductName);

                if (getproduct != null)
                {

                    int currentUnit = int.TryParse(getproduct.Unit, out var parsedUnit) ? parsedUnit : 0;

                    if (currentUnit >= product.Unit)
                    {
                        getproduct.Unit = (currentUnit - product.Unit).ToString();

                        var transaction = new StockTransactionModel
                        {
                            ProductId = getproduct.ProductId,
                            Quantity = product.Unit,
                            TransactionType = "Out",
                            TransactionDate = DateTime.Now
                        };
                        _context.StockTransactionTb.Add(transaction);
                        _context.SaveChanges();

                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                return  3;
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
                throw;
            }
            
        }
    }
}
