using FHB_BLL.DTO.Categories;
using FHB_BLL.DTO.Employees;
using FHB_BLL.Services.GenericServices;
using FHB_BLL.Wrapping.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_BLL.Services.EmployeeServices
{
    public interface IEmployeeService : IGenericService<EmployeeDto>
    {
        ApiResponse<EmployeeDto> GetEmployeeByName(string name);
    }
}
