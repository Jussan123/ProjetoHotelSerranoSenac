using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoHotelSerranoSenac.Models.Generic;

namespace ProjetoHotelSerranoSenac.Models
{
    public class Hotel : CreateReadUpdateDelete<Hotel>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Hotel() { }

        public Hotel(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }
    }
}