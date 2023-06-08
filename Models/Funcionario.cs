using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHotelSerranoSenac.Models
{
    public class Funcionario : CreateReadUpdateDelete<Funcionario>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email {get; set;}
        public string Telefone {get; set;}
        public decimal Salario {get; set;}
        public string Funcao {get; set;}
        public int HotelId {get; set;}
        public Hotel Hotel {get; set;}

        public Funcionario() { }

        public Funcionario(string nome, string email, string telefone, decimal salario, string funcao, int hotelId)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Salario = salario;
            Funcao = funcao;
            HotelId = hotelId;
        }
    }
}