using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_Learning.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        [ScaffoldColumn(false)]  //means when i use create template then  thier is no textfield  made for the contact field
        public int Contact { get; set; }

        [ScaffoldColumn(false)]
        public string Address { get; set; }
    }
}