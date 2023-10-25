using Microsoft.AspNetCore.Identity;

namespace DayOff.Web.Data
{
    public class Employee : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? NINumber { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
