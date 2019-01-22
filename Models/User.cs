using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace WeddingPlanner.Models
{
    public class User
    {
        [Key]
        public int ID {get;set;}
        [Required(ErrorMessage="First Name Field Required")]
        [MinLength(2, ErrorMessage="Is that your real name?")]
        [Display(Name="First Name: ")]
        public string FirstName{get;set;}
        [Required(ErrorMessage="Last Name Field required, too, you're not Madonna")]
        [MinLength(3, ErrorMessage="Is that really your last name?")]
        [Display(Name="Last Name: ")]
        public string LastName{get;set;}
        [Required(ErrorMessage="We're gonna need that Email, bud")]
        [EmailAddress(ErrorMessage="No Funny Business!")]
        [Display(Name="Email Address: ")]
        public string Email {get;set;}
        [Required(ErrorMessage="What's your safe word?")]
        [MinLength(8, ErrorMessage="Construct additional pylons!")]
        [Display(Name="Password: ")]
        [DataType(DataType.Password)]
        public string Password  {get;set;}
        [NotMapped]
        [Display(Name="Confirm Password: ")]
        [Compare("Password", ErrorMessage="Hey! that's not what you siad before!")]
        [Required(ErrorMessage="Please Confirm your Pylons")]
        [DataType(DataType.Password)]

        public string ConfirmPassWord{get;set;}
        public DateTime CreatedAt{get;set;}
        public DateTime UpdatedAt{get;set;}
        public List<RSVP> RSVPs{get;set;}
    }
}