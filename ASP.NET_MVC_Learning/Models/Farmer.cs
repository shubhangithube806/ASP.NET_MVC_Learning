using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_Learning.Models
{
    public class Farmer //YOU HAVE TO TAKE SPECIFIC TYPE OF DATA FROM USER YOU HAVE TO USE REGULAR EXPRESSION
    {
        //[Required]  THIS gives default error message

        [DisplayName("Id")]
        [Required(ErrorMessage = "Id is mandatory")]          //This gives custom error message (made by you)
        public int FarmerId { get; set; }


        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is mandatory")]
        [StringLength(20,MinimumLength = 5, ErrorMessage ="Name should be in between 5 and 20")]
        public string FarmerName { get; set; }


        [DisplayName("Age")]
        [Required(ErrorMessage = "Age is mandatory")]
        [Range(20, 60, ErrorMessage ="Age should be in the rang of 20 & 60")]
        public int? FarmerAge { get; set; }  // ? means i made int nullable means it can take null value also


        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is mandatory")]
        public string FarmerGender { get; set; }


        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is mandatory")]
        [RegularExpression("^([0-9a-zA]([-\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$", ErrorMessage ="Invalid Email")]
        public string FarmerEmail { get; set; }


        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is mandatory")]
        [RegularExpression(@"(?=^.{8,}$)((?=.*\d)|(?=.*\w+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage ="Uppercase, LowerCase, Numbers, Symbols, 8 Characters")]
        [DataType(DataType.Password)]
        public string FarmerPassword { get; set; }


        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = " Confirm Password is mandatory")]
        [Compare("FarmerPassword", ErrorMessage = "Password is not identical")]
        public string FarmerConfirmPassword { get; set; }


        [DisplayName("Organization Name")]
        //[ReadOnly("true")]
        public string OrganizationName { get; set; }


        [DisplayName("Address is")]
        [Required(ErrorMessage = "Address   is mandatory")]
        [DataType(DataType.MultilineText)]
        public string FarmerAddress { get; set; }


        [DisplayName("Start Date")]
        [Required(ErrorMessage = "Start Date   is mandatory")]
        [DataType(DataType.Date)]
        public string FarmerStartDate { get; set; }


        [DisplayName("Start Time")]
        [Required(ErrorMessage = "Start Time   is mandatory")]
        [DataType(DataType.Time)]
        public string FarmerStartTime { get; set; }
    }
}
