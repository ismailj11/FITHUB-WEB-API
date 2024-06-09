using FHB_DAL.Models;
using FHB_DAL.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace FHB_DAL.Repositories.Categories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(FithubDbContext context) : base(context) { }

        public Category GetCategoryByName(string name)
        {
            return _dbSet.FirstOrDefault(x => x.CategoryName == name);
        }
    }
}