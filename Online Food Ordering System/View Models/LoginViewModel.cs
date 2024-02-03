﻿using System.ComponentModel.DataAnnotations;

namespace Online_Food_Ordering_System.View_Models
{
    public class LoginViewModel
    {
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address format")]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z])(?=.*[^a-zA-Z\d]).{6,}$", ErrorMessage = "the password must consist of 6 digit container Number Upper and Lower character and at least one non-alphanumeric")]
        [Required]
        public string Password { get; set; }

    }
}
