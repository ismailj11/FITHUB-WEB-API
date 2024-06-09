using AutoMapper;
using FHB_BLL.DTO.Categories;
using FHB_BLL.DTO.Employees;
using FHB_BLL.Services.CategoryServices;
using FHB_BLL.Services.GenericServices;
using FHB_BLL.Wrapping.Exceptions;
using FHB_DAL.Models;
using FHB_DAL.Repositories.Categories;
using FHB_DAL.Repositories.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_BLL.Services.EmployeeServices
{
    public class EmployeeService : GenericService<Employee, EmployeeDto>, IEmployeeService
    {
        public readonly IEmployeeRepository _employeeRepository;
        public readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper) : base(employeeRepository, mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public ApiResponse<EmployeeDto> GetEmployeeByName(string name)
        {
            var response = new ApiResponse<EmployeeDto>();
            var result = _employeeRepository.GetEmployeeByName(name);
            response.Data = _mapper.Map<EmployeeDto>(result);
            return response;
        }

    }
}
