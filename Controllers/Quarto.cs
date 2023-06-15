using System;

namespace ProjetoHotelSerranoSenac
{
    public class Quarto
    {
        public static Models.Hotel hotelCrud = new Models.Hotel();
        public static Models.Quarto quartoCrud = new Models.Quarto();
        public static Models.Quarto CadastrarQuarto(string numero_quarto, string descricao, string valor, string disponivel, string hotelId)
        {
            Models.Hotel hotel = hotelCrud.Get(int.Parse(hotelId));

            Models.Quarto quarto = new Models.Quarto(int.Parse(numero_quarto), descricao, Double.Parse(valor), disponivel != null && disponivel != "" ? true : false, hotel.Id);
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
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Quarto quarto = quartoCrud.Get(idInt);

                    return quarto;
                }
                {
                    throw new Exception("Quarto não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao buscar Quarto");
            }
        }

        public static Models.Quarto AlterarQuarto(string quartoId, string numero_quarto, string descricao, string valor, string disponivel, string hotelId)
        {
            try
            {
                if (quartoId != null)
                {
                    int idInt = int.Parse(quartoId);
                    Models.Quarto quarto = quartoCrud.Get(idInt);

                    quarto.NumeroQuarto = int.Parse(numero_quarto);
                    quarto.Descricao = descricao;
                    quarto.Valor = Double.Parse(valor);
                    quarto.Disponivel = disponivel != null && disponivel != "" ? true : false;
                    quarto.HotelId = int.Parse(hotelId);

                    quartoCrud.Alterar(quarto);

                    return quarto;
                }
                {
                    throw new Exception("Quarto não existe");
                }
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
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Quarto quarto = quartoCrud.Get(idInt);
                    quartoCrud.Excluir(quarto.Id);

                    return quarto;
                }
                else
                {
                    throw new Exception("Quarto não encontrado");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao excluir Quarto!");
            }
        }
    }
}