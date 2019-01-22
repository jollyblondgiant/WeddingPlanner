using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace WeddingPlanner.Models
{
    public class Login
    {
        [Required(ErrorMessage="Email Field Required!")]
        [Display(Name="Email: ")]
        public string Email{get;set;}
        [Required(ErrorMessage="What's the secret password?")]
        [Display(Name="Password: ")]
        [DataType(DataType.Password)]
        public string Password{get;set;}
    }
}