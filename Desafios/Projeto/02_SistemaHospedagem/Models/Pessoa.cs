using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome) 
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }
        public string nome{get; set;}
        public string sobrenome{get; set;}
    }
}