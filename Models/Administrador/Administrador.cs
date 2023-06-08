using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHotelSerranoSenac.Models.Administrador
{
    public class Administrador : CreateReadUpdateDelete<Administrador>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

        public Administrador() { }

        public Administrador(string nome, string email, string senha, int hotelId)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            HotelId = hotelId;
        }
    }
}