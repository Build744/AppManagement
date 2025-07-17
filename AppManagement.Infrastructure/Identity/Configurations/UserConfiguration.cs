using AppManagement.Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppManagement.Infrastructure.Identity.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        var hasher = new PasswordHasher<ApplicationUser>();
        builder.HasData(
            new ApplicationUser
            {
                Id = "526033fb-d870-4f16-bdc9-74dbed29a281",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "System",
                LastName = "Admin",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@sser123"),
                EmailConfirmed = true,
            },
            new ApplicationUser
            {
                Id = "e67a49ce-0022-477e-9b16-69c705a0d99a",
                Email = "customer01@localhost.com",
                NormalizedEmail = "CUSTOMER01@LOCALHOST.COM",
                FirstName = "System",
                LastName = "User",
                UserName = "customer01@localhost.com",
                NormalizedUserName = "CUSTOMER01@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@sser123"),
                EmailConfirmed = true,
            }
        );
    }
}
