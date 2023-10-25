using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DayOff.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            // assign admin or user roles to employee
            builder.HasData(
                // new admin user
                new IdentityUserRole<string>
                {
                    // admin role id and employee user id
                    RoleId = "14872ccf-ac9e-5c81-1720-78cc83aa61ad",
                    UserId = "18578dda-fd1e-4d21-9380-78dc83af61fb"
                },
                // new normal user
                new IdentityUserRole<string>
                {
                    // user role id and employee user id
                    RoleId = "41827cba-fe5c-2c39-0271-65ee34bb61da",
                    UserId = "75818bbc-ef2c-1b34-0983-65ab79ed17cd"
                }
            );
        }
    }
}