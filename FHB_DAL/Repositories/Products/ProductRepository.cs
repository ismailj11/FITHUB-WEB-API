using FHB_DAL.Models;
using FHB_DAL.Repositories.GenericRepository;
using System.Collections.Generic;
using System.Linq;

namespace FHB_DAL.Repositories.Products
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public FithubDbContext Context => throw new NotImplementedException();

        public ProductRepository(FithubDbContext context) : base(context) { }

        public Product GetProductByProductName(string name)
        {
            return _dbSet.FirstOrDefault(x => x.ProductName == name);
        }

        public IEnumerable<Product> GetProductByCategoryID(int categoryID)
        {
            return _dbSet.Where(x => x.FkCategoryId == categoryID).ToList();
        }
    }
}