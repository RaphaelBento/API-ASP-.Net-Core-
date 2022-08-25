using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_DotNetCore.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        public Cliente(int id, string nome , string sobreNome)
        {
            Id = id;
            Nome = nome;
            SobreNome = sobreNome;
        }
    }
}
