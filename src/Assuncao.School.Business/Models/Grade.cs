using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assuncao.School.Business.Models
{
    public class Grade :  Entity
    {
        public int GradeNumber { get; set; }
        public double AverageGrade { get; set; }
        public double FrequenceGrade { get; set; }
    }
}
