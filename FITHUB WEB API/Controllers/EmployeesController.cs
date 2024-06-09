using FHB_BLL.DTO.Categories;
using FHB_BLL.DTO.Employees;
using FHB_BLL.Services.CategoryServices;
using FHB_BLL.Services.EmployeeServices;
using FHB_BLL.Wrapping.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace FITHUB_WEB_API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class EmployeesController : GenericController<EmployeeDto>
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService service) : base(service)
        {
            _employeeService = service;
        }

        [HttpGet("GetEmployeeByName")]
        public ApiResponse<EmployeeDto> GetEmployeeByNames(string name)
        {
            return _employeeService.GetEmployeeByName(name);
        }

    }
}
