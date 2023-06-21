using ProjetoHotelSerranoSenac.Models.Generic;

namespace ProjetoHotelSerranoSenac.Models
{
    public class ReservaServico : CreateReadUpdateDelete<ReservaServico>
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public Reserva Reserva { get; set; }
        public int ServicoId { get; set; }
        public Servico Servico { get; set; }
        public DateTime DataServico { get; set; }
        public int Quantidade { get; set; }

        public ReservaServico() { }

        public ReservaServico(int reservaId, int servicoId, DateTime dataServico, int quantidade)
        {
            ReservaId = reservaId;
            ServicoId = servicoId;
            DataServico = dataServico;
            Quantidade = quantidade;
        }
    }
}