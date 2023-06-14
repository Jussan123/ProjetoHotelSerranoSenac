using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoHotelSerranoSenac.Models.Generic;

namespace ProjetoHotelSerranoSenac.Models
{
    public class Checkin : CreateReadUpdateDelete<Checkin>
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public Reserva Reserva { get; set; }
        public DateTime DataCheckin { get; set; }

        public Checkin() { }

        public Checkin(int reservaId, DateTime dataCheckin)
        {
            ReservaId = reservaId;
            DataCheckin = dataCheckin;
        }
    }
}