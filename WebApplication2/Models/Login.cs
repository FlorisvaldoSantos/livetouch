using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool MaterLogado { get; set; }
        public string Error { get; set; }
    }
}
