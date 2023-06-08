using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHotelSerranoSenac.Models
{
    public class Produto : CreateReadUpdateDelete<Produto>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

        public Produto() { }

        public Produto(string nome, double preco, int hotelId)
        {
            Nome = nome;
            Preco = preco;
            HotelId = hotelId;
        }
    }
}