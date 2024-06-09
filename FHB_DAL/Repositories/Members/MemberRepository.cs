using FHB_DAL.Models;
using FHB_DAL.Repositories.Employees;
using FHB_DAL.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_DAL.Repositories.Members
{
    public class MemberRepository : GenericRepository<Member>, IMemberRepository
    {
        public MemberRepository(FithubDbContext fithubDbContext) : base(fithubDbContext)
        {
        }

        public Member GetMemberByName(string name)
        {
            var result = _dbSet.Where(x => x.MemberName == name).FirstOrDefault();
            return result;
        }
    }
}
