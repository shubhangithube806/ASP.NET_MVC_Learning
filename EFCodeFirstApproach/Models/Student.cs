using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFCodeFirstApproach.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }  //IN the database Id becomes primary key so use data annotation [key]

        public string Name { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }
    }
}