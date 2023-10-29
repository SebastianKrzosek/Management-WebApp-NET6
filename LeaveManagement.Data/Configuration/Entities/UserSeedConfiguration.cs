using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(new Employee
            {
                Id = "2c46e3c4-14f7-48cf-85d1-7d2090371576",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                FirstName = "System",
                LastName = "Admin",
                PasswordHash = hasher.HashPassword(null, "P@$$w0rd1"),
                EmailConfirmed = true,
                DateOfBirth = new DateTime(1998, 5, 24),
                DateJoined = DateTime.Now,
            },
            new Employee
            {
                Id = "9cbebf8f-5d6a-4e7c-9fdd-22786c79c0dc",
                Email = "user@localhost.com",
                NormalizedEmail = "USER@LOCALHOST.COM",
                UserName = "user@localhost.com",
                NormalizedUserName = "USER@LOCALHOST.COM",
                FirstName = "System",
                LastName = "User",
                PasswordHash = hasher.HashPassword(null, "P@$$w0rd1"),
                EmailConfirmed = true,
                DateOfBirth = new DateTime(1998, 5, 24),
                DateJoined = DateTime.Now,
            }); ;
        }
    }
}