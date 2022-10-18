using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assuncao.School.Business.Models.Enums;

namespace Assuncao.School.Business.Models
{
    public class User : Entity
    {
        public int UserRegistration { get; set; }
        public string UserName { get; set; }
        public UserType UserType { get; set; }
        protected string UserPassword { get; set; }

    }
}
