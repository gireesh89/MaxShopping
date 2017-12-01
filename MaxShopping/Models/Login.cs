using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingSite.Models
{
    public class Login
    {
        [Required(ErrorMessage="Please enter UserName",AllowEmptyStrings=false)]
        public string UserName { get; set; }
        
        [Required(ErrorMessage="Please enter Password",AllowEmptyStrings=false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password { get; set; }

        public string CustomerName { get; set; }

        public bool RememberMe { get; set; }
    }
}