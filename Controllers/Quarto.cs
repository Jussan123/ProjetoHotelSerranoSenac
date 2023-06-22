using System;

namespace ProjetoHotelSerranoSenac.Controllers
{
    public class Quarto
    {
        public static Models.Hotel hotelCrud = new();
        public static Models.Quarto quartoCrud = new();
        public static Models.Quarto CadastrarQuarto(string numero_quarto, string descricao, string valor, string disponivel, string hotelId)
        {
            Models.Hotel hotel = hotelCrud.Get(int.Parse(hotelId));

            Models.Quarto quarto = new(int.Parse(numero_quarto), descricao, Double.Parse(valor), disponivel != null && disponivel != "" ? true : false, hotel.Id);
            return quartoCrud.Cadastrar(quarto);
        }

        public static IEnumerable<Models.Quarto> GetAllQuartos()
        {
            IEnumerable<Models.Quarto> quarto = quartoCrud.GetAll();

            return quarto;
        }

        public static Models.Quarto GetQuarto(string id)
        {
            try
            {
                Models.Quarto quarto = quartoCrud.Get(int.Parse(id));

                return quarto;
            }
            catch (System.Exception e)
            {

                throw new Exception("Erro ao buscar Quarto: " + e.Message);
            }
        }

        public static Models.Quarto AlterarQuarto(string quartoId, string numero_quarto, string descricao, string valor, string disponivel, string hotelId)
        {
            try
            {
                int idInt = int.Parse(quartoId);
                Models.Quarto quarto = quartoCrud.Get(idInt);

                quarto.NumeroQuarto = int.Parse(numero_quarto);
                quarto.Descricao = descricao;
                quarto.Valor = Double.Parse(valor);
                quarto.Disponivel = disponivel != null && disponivel != "" &&  disponivel == "Sim" ? true : false;
                quarto.HotelId = int.Parse(hotelId);

                quartoCrud.Alterar(quarto);

                return quarto;
            }
            catch (System.Exception)
            {
                throw new Exception("Erro ao alterar Quarto");
            }
        }

        public static Models.Quarto ExcluirQuarto(string id)
        {
            try
            {
                Models.Quarto quarto = quartoCrud.Get(int.Parse(id));
                quartoCrud.Excluir(quarto.Id);

                return quarto;

            }
            catch (System.Exception)
            {
                throw new Exception("Erro ao excluir Quarto!");
            }
        }

        public static void GetQuartoDisponivel (Models.Quarto quarto)
        {
            if (quarto.Disponivel == false)
                throw new Exception("Quarto não disponível");

        }
    }
}