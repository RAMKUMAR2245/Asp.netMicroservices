using catalog.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catalog.API.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<products>> GetProducts();
        Task<products> GetProduct(string id);
        Task<IEnumerable<products>> GetProductByName(string name);
        Task<IEnumerable<products>> GetProductByCategory(string categoryName);

        Task CreateProduct(products product);
        Task<bool> UpdateProduct(products product);
        Task<bool> DeleteProduct(string id);
    }
}
