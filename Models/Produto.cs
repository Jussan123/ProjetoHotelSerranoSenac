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
        public double PrecoVenda { get; set; }
        public double PrecoCompra { get; set; }

        public Produto() { }

        public Produto(string nome, double preco, double precoVenda, double precoCompra)
        {
            Nome = nome;
            Preco = preco;
            PrecoVenda = precoVenda;
            PrecoCompra = precoCompra;
        }
    }
}