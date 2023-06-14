using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoHotelSerranoSenac.Models.Generic;

namespace ProjetoHotelSerranoSenac.Models
{
    public class Checkout : CreateReadUpdateDelete<Checkout>
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public Reserva.Reserva Reserva { get; set; }
        public DateTime DataCheckout { get; set; }

        public Checkout() { }

        public Checkout(int reservaId, DateTime dataCheckout)
        {
            ReservaId = reservaId;
            DataCheckout = dataCheckout;
        }
    }
}