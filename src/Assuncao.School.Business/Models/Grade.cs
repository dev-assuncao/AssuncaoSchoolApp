using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assuncao.School.Business.Models
{
    public class Grade : Entity
        //public class Subject : entity
    {
        public Student StudentId { get; set; }
        public string SubjectName { get; set; }
        // public string BimestreGrade { get; set; }
        // public YearSchoolGrade {get;set;}
        public int Grades { get; set; }
        public double AverageGrade { get; set; }
        public double FrequenceGrade { get; set; }

    }
}
