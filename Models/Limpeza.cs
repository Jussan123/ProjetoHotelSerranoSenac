using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoHotelSerranoSenac.Models.Generic;

namespace ProjetoHotelSerranoSenac.Models
{
    public class Limpeza : CreateReadUpdateDelete<Limpeza>
    {
        public int Id { get; set; }
        public int QuartoId { get; set; }
        public Quarto Quarto { get; set; }
        public DateTime Data { get; set; }
        public int? CheckoutId { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }

        public Limpeza() { }

        public Limpeza(int quarto, DateTime data, int idFuncionario, int? checkoutId = null)
        {
            QuartoId = quarto;
            Data = data;
            FuncionarioId = idFuncionario;
            CheckoutId = checkoutId;
        }
    }
}