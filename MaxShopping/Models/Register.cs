using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShoppingSite.Models
{
    public class Register
    {
        [Required(ErrorMessage="Name is Required")]
        public string name { get; set; }

        [Required(ErrorMessage = "Email Address is Required")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
        [EmailAddress(ErrorMessage="Invalid Mail Address")]
        public string emailAddress { get; set; }


        [Required(ErrorMessage = "Mobile no is required")]
        public string mobileno { get; set; }

        [Required(ErrorMessage="Password is Required")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string password { get; set; }
        
    }
}