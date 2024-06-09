using FHB_BLL.Wrapping.Exceptions;
using FHB_DAL.Repositories.Users;
using System;

namespace FHB_BLL.Services.AuthenticationServices
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository userRepository;

        public AuthService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public ApiResponse<bool> login(string userName, string password)
        {
            try
            {
                var user = userRepository.GetUserByUsername(userName);
                if (user == null)
                {
                    return new ApiResponse<bool>
                    {
                        Success = false,
                        ErrorMessage = "User name not found"
                    };
                }

                if (user.Password != password)
                {
                    return new ApiResponse<bool>
                    {
                        Success = false,
                        ErrorMessage = "Wrong password"
                    };
                }

                else
                {
                    return new ApiResponse<bool>
                    {
                        Success = true,
                        ErrorMessage = "Authenticated succesfully"
                    };
                }

                return new ApiResponse<bool>(true);
            }
            catch (Exception ex)
            {
                return new ApiResponse<bool>
                {
                    Success = false,
                    ErrorMessage = $"An error occurred: {ex.Message}"
                };
            }
        }
    }


}