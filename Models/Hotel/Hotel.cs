using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHotelSerranoSenac.Models.Hotel
{
    public class Hotel : CreateReadUpdateDelete<Hotel>
    {
        //Hoteis (hotelId, nome, endereco, telefone)
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