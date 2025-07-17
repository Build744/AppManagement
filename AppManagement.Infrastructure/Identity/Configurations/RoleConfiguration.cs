using AppManagement.Application.Abstractions.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppManagement.Infrastructure.Identity.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole
            {
                Id = "9e560806-f61f-4031-ae9b-a9faad6824f9",
                Name = RoleName.Customer,
                NormalizedName = RoleName.Customer.ToUpper(),
            },
            new IdentityRole
            {
                Id = "e4a52831-c19e-469e-a3d7-f30ebe5badec",
                Name = RoleName.Administrator,
                NormalizedName = RoleName.Administrator.ToUpper(),
            }
        );
    }
}
