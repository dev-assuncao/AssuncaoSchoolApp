using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assuncao.School.Business.Models
{
    public class Record : Entity
    {
        public Guid SubjectId { get; set; }
        public double[] BimestreGrade { get; set; } = new Double[3];
        public double YearGrade { get; set; }
        public Subject Subject { get; set; }
    }
}
