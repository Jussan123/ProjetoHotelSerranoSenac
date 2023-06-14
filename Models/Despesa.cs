using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoHotelSerranoSenac.Models.Generic;

namespace ProjetoHotelSerranoSenac.Models
{
    public class Despesa : CreateReadUpdateDelete<Despesa>
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public int ProdutoId { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }

        public Despesa() { }

        public Despesa(int reservaId, int produtoId, decimal valor, int quantidade)
        {
            ReservaId = reservaId;
            ProdutoId = produtoId;
            Valor = valor;
            Quantidade = quantidade;
        }
    }
}