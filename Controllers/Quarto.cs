using System;

namespace ProjetoHotelSerranoSenac
{
    public class Quarto
    {
        public static Models.Quarto CadastrarQuarto(string numero_quarto, string descricao, string valor, string disponivel, string hotelId)
        {
            int intHotelId = intParse(hotelId);
            Models.Hotel hotel = Models.Hotel.Get(intHotelId);

            Models.Quarto quarto = new Models.Quarto.Get(numero_quarto, descricao, valor, disponivel, hotel);
            return Models.Quarto.Cadastrar(quarto);
        }

        public static List<Models.Quarto> GetAllQuartos()
        {
            List<Models.Quarto> quarto = Models.Quarto.GetAll();

            return quarto;
        }

        public static Models.Quarto GetQuarto(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Quarto quarto = Models.Quarto.Get(idInt);

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
                    Models.Quarto quarto = Models.Quarto.Get(idInt);

                    quarto.Numero_quarto = numero_quarto;
                    quarto.Descricao = descricao;
                    quarto.Valor = valor;
                    quarto.Disponivel = disponivel;
                    quarto.HotelId = int.Parse(hotelId);

                    Models.Quarto.Alterar(quarto);

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
                    Models.Quarto quarto = Models.Quarto.Get(idInt);
                    Models.Quarto.Excluir(idInt);

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