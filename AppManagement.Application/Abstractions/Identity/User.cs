namespace AppManagement.Application.Abstractions.Identity;

public sealed class User
{
    public string Id { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
