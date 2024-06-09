using FHB_BLL.Wrapping.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_BLL.Services.AuthenticationServices
{
    public  interface IAuthService
    {
        ApiResponse<bool> login(string userName, string password);
    }
}
