using LeaveManagement.Common.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configuration.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                    new IdentityRole
                    {
                        Id = "3e7225dd-cee7-420b-9277-2c1863915e36",
                        Name = Roles.Administrator,
                        NormalizedName = Roles.Administrator.ToUpper(),
                    },
                    new IdentityRole
                    {
                        Id = "f49e3b73-4892-47ac-b69a-5d315c3cd11e",
                        Name = Roles.User,
                        NormalizedName = Roles.User.ToUpper(),
                    }
                );
        }
    }
}