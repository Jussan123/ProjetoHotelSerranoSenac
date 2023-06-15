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
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }

        public ReservaServico() { }

        public ReservaServico(int reservaId, int servicoId, int funcionarioId)
        {
            ReservaId = reservaId;
            ServicoId = servicoId;
            FuncionarioId = funcionarioId;
        }
    }
}