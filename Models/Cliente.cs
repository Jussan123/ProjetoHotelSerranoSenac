using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHotelSerranoSenac.Models
{
    public class Cliente : CreateReadUpdateDelete<Cliente>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email {get; set;}
        public string Telefone {get; set;}
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

        public Cliente() { }

        public Cliente(string nome, string email, string telefone, int hotelId)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            HotelId = hotelId;
        }
    }
}