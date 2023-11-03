using System.ComponentModel.DataAnnotations;

namespace DayOff.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Leave Name")]
        public required string Name { get; set; }

        [Display(Name = "Default Number of Days")]
        [Range(1, 25, ErrorMessage = "Please enter a valid number")]
        public required int DefaultDays { get; set; }
    }
}
