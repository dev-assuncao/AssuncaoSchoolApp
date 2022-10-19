using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assuncao.School.Business.Models
{
    public class School : Entity
    {
        public string SchoolName { get; set; }      
        public string CompetentAuthority { get; set; }
        public string Director { get; set; }
        public string Email { get; set; }
        public string CnpjSchool { get; set; }
        public string PhoneNumber { get; set; }
        public int IdInepSchool { get; set; }
        public Address SchoolAddress { get; set; }
    }
}
