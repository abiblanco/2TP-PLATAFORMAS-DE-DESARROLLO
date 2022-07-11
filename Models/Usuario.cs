using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Usuario
    {
        public int id;
        public string name;
        public string email;

        public Usuario(int id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
        }
    }
}
