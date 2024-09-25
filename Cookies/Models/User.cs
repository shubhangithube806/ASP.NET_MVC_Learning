using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cookies.Models
{
    public class User
    {
        [Required(ErrorMessage ="UserName is required")]
        public string UserName { get; set; }
    }
}