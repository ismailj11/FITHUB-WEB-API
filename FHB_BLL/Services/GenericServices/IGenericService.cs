using FHB_BLL.Wrapping.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_BLL.Services.GenericServices
{
    public interface IGenericService<Dto> where Dto : class
    {
        ApiResponse<IEnumerable<Dto>> GetAll();
        ApiResponse<Dto> GetById(int id);
        ApiResponse<Dto> Add(Dto t);
        ApiResponse<Dto> Update(Dto t);
        ApiResponse<bool> Delete(int t);
        ApiResponse<bool> Delete(Dto t);
    }
}
