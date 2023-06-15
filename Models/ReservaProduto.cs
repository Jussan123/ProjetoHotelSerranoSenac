using ProjetoHotelSerranoSenac.Models.Generic;

namespace ProjetoHotelSerranoSenac.Models
{
    public class ReservaProduto : CreateReadUpdateDelete<ReservaProduto>
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public Reserva Reserva { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public ReservaProduto() { }

        public ReservaProduto(int reservaId, int produtoId)
        {
            ReservaId = reservaId;
            ProdutoId = produtoId;
        }
    }
}