using Microsoft.AspNetCore.Identity;
using OnSalePrue.Common.Enums;
using OnSalePrue.Web.Data.Entities;
using OnSalePrue.Web.Models;
using System;
using System.Threading.Tasks;

namespace OnSalePrue.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

        Task<User> AddUserAsync(AddUserViewModel model, Guid imageId, UserType userType);

    }

}
