using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assuncao.School.Business.Models
{
    public class Subject : Entity
    {
        public Guid ProfessorId { get; set; }
        public string SubjectName { get; set; }
        public Record Record { get; set; }
        public Professor Professor { get; set; }
    }
}
