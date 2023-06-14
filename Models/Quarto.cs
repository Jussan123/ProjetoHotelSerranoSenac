using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoHotelSerranoSenac.Models.Generic;

namespace ProjetoHotelSerranoSenac.Models
{
    public class Quarto : CreateReadUpdateDelete<Quarto>
    {
        public int Id { get; set; }
        public int NumeroQuarto { get; set; }
        public string Descricao { get; set; }
        public bool Disponivel { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

        public Quarto() { }

        public Quarto(int numeroQuarto, string descricao, bool disponivel, int hotelId)
        {
            NumeroQuarto = numeroQuarto;
            Descricao = descricao;
            Disponivel = disponivel;
            HotelId = hotelId;
        }
    }
}