using FHB_DAL.Models;
using FHB_DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_DAL.Repositories.Products
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Product GetProductByProductName(string name);


        IEnumerable<Product> GetProductByCategoryID(int categoryID);


        FithubDbContext Context { get; }

    }
}
