using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce.Infrastructure.Models
{
    public class MailRequestModel
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "First name lenght should be between 3 and 20")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Last name lenght should be between 3 and 20")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Message lenght should be between 5 and 100")]
        public string Message { get; set; }

    }

    //public class ContactModel
    //{
    //    [Required]
    //    [Display(Name = "First Name")]
    //    [StringLength(20, MinimumLength = 3, ErrorMessage = "First name lenght should be between 3 and 20")]
    //    public string FirstName { get; set; }

    //    [Required]
    //    [StringLength(20, MinimumLength = 3, ErrorMessage = "Last name lenght should be between 3 and 20")]
    //    public string LastName { get; set; }

    //    [Required]
    //    [DataType(DataType.EmailAddress)]
    //    public string Email { get; set; }

    //    [Required]
    //    [StringLength(100, MinimumLength = 5, ErrorMessage = "Message lenght should be between 5 and 100")]
    //    public string Message { get; set; }

    //}
}
