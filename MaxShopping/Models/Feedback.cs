using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShoppingSite.Models
{
    public class Feedback
    {
        [Required(ErrorMessage="Name is Required")]
        [Display(Name="Name")]
        public string Name { get; set; }

        [Required(ErrorMessage="Email is Required")]
        [Display(Name="Email")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
        public string emailId { get; set; }

        [Required(ErrorMessage="Mobile No is Required")]
        [Display(Name="Mobile")]        
        public string MobileNo { get; set; }

        [Required(ErrorMessage="Feedback is Required")]
        [Display(Name="Feedback")]
        public string FeedbackRes { get; set; }
    }
}
