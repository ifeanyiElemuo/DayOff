﻿using System.ComponentModel.DataAnnotations;

namespace DayOff.Web.Models
{
    public class EmployeeListVM
    {
        public string Id { get; set; }

        [Display (Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Date Joined")]
        public string CreatedAt { get; set; }

    }
}
