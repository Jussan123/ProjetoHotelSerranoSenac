using ProjetoHotelSerranoSenac.Models.Generic;

namespace ProjetoHotelSerranoSenac.Models
{
    public class Servico : CreateReadUpdateDelete<Servico>
    {
        public int Id { get; set; }
        public string TipoServico { get; set; }
        public double Preco { get; set; }

        public Servico() { }

        public Servico(string tipoServico, double preco)
        {
            TipoServico = tipoServico;
            Preco = preco;
        }
    }
}