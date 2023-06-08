using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHotelSerranoSenac.Models
{
    public class Reserva : CreateReadUpdateDelete<Reserva>
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int QuartoId { get; set; }
        public Quarto Quarto { get; set; }
        public DateTime DataCheckin { get; set; }
        public DateTime DataCheckout { get; set; }
        public decimal Preco { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

        public Reserva() { }

        public Reserva(int clienteId, int quartoId, DateTime dataCheckin, DateTime dataCheckout, decimal preco, int hotelId)
        {
            ClienteId = clienteId;
            QuartoId = quartoId;
            DataCheckin = dataCheckin;
            DataCheckout = dataCheckout;
            Preco = preco;
            HotelId = hotelId;
        }
    }
}