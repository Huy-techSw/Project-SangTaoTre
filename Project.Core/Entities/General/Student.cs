using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Entities.General
{
    public class Student
    {
        public string StudentId { get; set; }
        public int StudentGrade { get; set; }
        public string StudentName { get; set;}
        public int StudentAge { get; set;}
        public string StudentGender { get; set;}
        public string StudentPhone { get; set;}
        public string StudentEmail { get; set;} = string.Empty;

    }
}
