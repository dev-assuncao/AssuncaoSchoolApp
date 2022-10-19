using Assuncao.School.Business.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assuncao.School.Business.Models
{
    public class GradeClass :  Entity
    {    
        public string ClassName { get; set; }
        public int IdInepTurma { get; set; }
        public int YearSchoolClass { get; set; }
        public ShiftClass ShiftClass { get; set; }
        public DateTime YearClass { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Professor> Professors { get; set; }
    }
}
