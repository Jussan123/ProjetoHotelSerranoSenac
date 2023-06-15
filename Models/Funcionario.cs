using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoHotelSerranoSenac.Models.Generic;

namespace ProjetoHotelSerranoSenac.Models
{
    public class Funcionario : CreateReadUpdateDelete<Funcionario>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email {get; set;}
        public string Role {get; set;}
        public string Telefone {get; set;}
        public double Salario {get; set;}

        public Funcionario() { }

        public Funcionario(string nome, string email, string telefone, string role, double salario)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Role = role;
            Salario = salario;
        }
    }
}