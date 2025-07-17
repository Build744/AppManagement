namespace AppManagement.Application.Abstractions.Identity;

public interface IUserService
{
    Task<IEnumerable<User>> GetAll();
    Task<User?> GetUserById(string userId);
}
