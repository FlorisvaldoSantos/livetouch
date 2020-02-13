using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string UrlFoto { get; set; }
        public string Token { get; set; }
        public string[] Roles { get; set; }
        public string Error { get; set; }

    }
}
