using FHB_DAL.Models;
using FHB_DAL.Repositories.GenericRepository;
using FHB_DAL.Repositories.Tenants;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_DAL.Repositories.Employees
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(FithubDbContext fithubDbContext) : base(fithubDbContext)
        {
        }

        public Employee GetEmployeeByName(string name)
        {
            var result = _dbSet.Where(x => x.EmployeeName == name).FirstOrDefault();
            return result;
        }
    }
}
