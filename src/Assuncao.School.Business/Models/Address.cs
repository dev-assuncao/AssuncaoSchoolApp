using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assuncao.School.Business.Models
{
    public class Address : Entity
    {
        public User UserId { get; set; }
        public string Logradouro { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Cep { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Estate { get; set; }
        public string UF { get; set; }
        public User User { get; set; }
    }
}
