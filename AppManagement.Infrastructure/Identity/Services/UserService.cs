using AppManagement.Application.Abstractions.Identity;
using AppManagement.Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity;

namespace AppManagement.Infrastructure.Identity.Services;

public sealed class UserService : IUserService
{
    private readonly UserManager<ApplicationUser> _userManager;

    public UserService(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IEnumerable<User>> GetAll()
    {
        var users = await _userManager.GetUsersInRoleAsync("Employee");

        return users.Select(q => new User
        {
            Id = q.Id,
            Email = q.Email,
            FirstName = q.FirstName,
            LastName = q.LastName,
        });
    }

    public async Task<User?> GetUserById(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);

        if (user == null)
            return null;

        return new User
        {
            Email = user.Email,
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
        };
    }
}
