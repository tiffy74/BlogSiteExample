using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetC.JuniorDeveloperExam.Web.Models
{
    public class Form
    {
        [Required(ErrorMessage = "Name is required.")]
        public string name { get; set; }
        public DateTime date { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string emailAddress { get; set; }
        public string message { get; set; }
    }
}
