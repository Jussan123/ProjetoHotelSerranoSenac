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
        public double Valor { get; set; }
        public bool Disponivel { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

        public Quarto() { }

        public Quarto(int numeroQuarto, string descricao, double valor, bool disponivel, int hotelId)
        {
            NumeroQuarto = numeroQuarto;
            Descricao = descricao;
            Valor = valor;
            Disponivel = disponivel;
            HotelId = hotelId;
        }

        public  string booleanToString(){
            string disponivel = "Não";
             if(Disponivel.ToString() == "True"){
                disponivel = "Sim";
            }else{
                disponivel = "Não";
            }
            return disponivel;
        }
    }
}