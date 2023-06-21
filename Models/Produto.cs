using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoHotelSerranoSenac.Models.Generic;

namespace ProjetoHotelSerranoSenac.Models
{
    public class Produto : CreateReadUpdateDelete<Produto>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public double Quantidade { get; set; }
        public double PrecoVenda { get; set; }
        public double PrecoCompra { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

        public Produto() { }

        public Produto(string nome, double preco, double quantidade,  double precoCompra, int hotelId)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            PrecoCompra = precoCompra;
            HotelId = hotelId;
        }
    }
}