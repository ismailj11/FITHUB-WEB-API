using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FHB_DAL.Models;
using FHB_DAL.Repositories.GenericRepository;

namespace FHB_DAL.Repositories.Users
{
    using Entity = User;
    public class UserRepository : GenericRepository<Entity>, IUserRepository

    {
        public UserRepository(FithubDbContext fithubDbContext) : base(fithubDbContext) { }

        public Entity GetUserByUsername(string username)
        {
            return _dbSet.Where(x => x.Username == username).FirstOrDefault();
        }


    }
}
