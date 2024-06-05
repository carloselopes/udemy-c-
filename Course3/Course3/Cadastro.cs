using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course3
{
    internal class Cadastro
    {
        public string name { get; set; }
        public string email { get; set; }

        public Cadastro(string nome, string email)
        {
            this.name = nome;
            this.email = email;
        }
        public Cadastro() { }

        public override string ToString()
        {
            return name + ", " + email;
        }
    }
}
