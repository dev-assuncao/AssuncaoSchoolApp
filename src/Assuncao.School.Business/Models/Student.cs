using Assuncao.School.Business.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assuncao.School.Business.Models
{
    public class Student : Entity
    {
        public int IdInepStudent { get; set; }
        public string StudentName { get; set; }
        public DateTime BirthDay { get; set; }
        public GenderStudent GenderStudent { get; set; }
        public Race Race { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public int PhoneStudent { get; set; }
        public string Situation { get; set; }
        public string StudentCPF { get; set; }
    }
}
