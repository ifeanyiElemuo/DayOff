using Microsoft.AspNetCore.Identity;

namespace DayOff.Web.Data
{
    public class Employee : IdentityUser
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string NINumber { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
