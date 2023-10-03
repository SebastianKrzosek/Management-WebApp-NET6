using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = "3e7225dd-cee7-420b-9277-2c1863915e36",
                UserId = "2c46e3c4-14f7-48cf-85d1-7d2090371576",
            },
            new IdentityUserRole<string>
            {
                RoleId = "f49e3b73-4892-47ac-b69a-5d315c3cd11e",
                UserId = "9cbebf8f-5d6a-4e7c-9fdd-22786c79c0dc",
            });
        }
    }
}