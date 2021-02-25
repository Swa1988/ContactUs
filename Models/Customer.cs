using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactUs.Models
{
    public class Customer
    {
        [Key]
        public int CustId { get; set; }

        [DisplayName("First name")]
        [Required(ErrorMessage = "Required.")]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        [Required(ErrorMessage = "Required.")]
        public string LastName { get; set; }

        [DisplayName("Your email")]
        [Required(ErrorMessage = "Required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [DisplayName("Phone number")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public int PhoneNumber { get; set; }

        [DisplayName("Contact Purpose")]
        public string ContactPurpose { get; set; }
        [DisplayName("Your message")]
        public string Message { get; set; }
    }

   
}