using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assuncao.School.Business.Models
{
    public class Professor : Entity
    {
        public User UserId { get; set; }
        public int ProfessorRegistration { get; set; }
        public int IdInepProfessor { get; set; }
        public string ProfessorName { get; set; }
        public Subject Subject { get; set; }


        // Entity Framework
        public IEnumerable<GradeClass> GradeClasses { get; set; }
        public User User { get; set; }
    }
}
