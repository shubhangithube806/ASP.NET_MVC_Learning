using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultipleModelDataInSingleView.Models
{
    public class MultiModelData
    {
        public List<Student> MyStudents { get; set; }   /*List<Student>  means stuent type data return in list*/
        public List<Teacher> MyTeachers { get; set; }
    }
}