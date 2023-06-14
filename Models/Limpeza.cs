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
        public int Quarto { get; set; }
        public DateTime Data { get; set; }
        public int? CheckoutId { get; set; }

        public Limpeza() { }

        public Limpeza(int quarto, DateTime data, int? checkoutId = null)
        {
            Quarto = quarto;
            Data = data;
            CheckoutId = checkoutId;
        }
    }
}