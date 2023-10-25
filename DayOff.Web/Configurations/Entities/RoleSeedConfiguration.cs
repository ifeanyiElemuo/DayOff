using DayOff.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DayOff.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                // admin role
               new IdentityRole
               {
                   Id = "14872ccf-ac9e-5c81-1720-78cc83aa61ad",
                   Name = Roles.Administrator,
                   NormalizedName = Roles.Administrator.ToUpper(),
               },
               // user role
               new IdentityRole
               {
                   Id = "41827cba-fe5c-2c39-0271-65ee34bb61da",
                   Name = Roles.User,
                   NormalizedName = Roles.User.ToUpper(),
               }
           );
        }
    }
}
