using System;

namespace ProjetoHotelSerranoSenac
{
    public class Hotel
    {
        public static Models.Hotel CadastrarHotel(string nome, string endereco, string telefone)
        {
            Models.Funcionario funcionario = new Models.Despesa.Get(nome, endereco, telefone);
            return Models.Funcionario.Cadastrar(funcionario);
        }

        public static List<Models.Hotel> GetAllHoteis()
        {
            List<Models.Hotel> hotel = Models.Hotel.GetAll();

            return hotel;
        }

        public static Models.Hotel GetHotel(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Hotel hotel = Models.Hotel.Get(idInt);

                    return hotel;
                }
                {
                    throw new Exception("Hotel não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao buscar Hotel");
            }
        }

        public static Models.Hotel AlterarHotel(string hotelId, string nome, string endereco, string telefone)
        {
            try
            {
                if (HotelId != null)
                {
                    int idInt = int.Parse(HotelId);
                    Models.Hotel hotel = Models.Hotel.Get(idInt);

                    hotel.Nome = nome;
                    hotel.Email = email;
                    hotel.Telefone = telefone;

                    Models.Hotel.Alterar(hotel);

                    return hotel;
                }
                {
                    throw new Exception("Hotel não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao alterar Hotel");
            }
        }

        public static Models.Hotel ExcluirHotel(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Hotel hotel = Models.Hotel.Get(idInt);
                    Models.Hotel.Excluir(idInt);

                    return hotel;
                }
                else
                {
                    throw new Exception("Hotel não encontrado");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao excluir Hotel!");
            }
        }
    }
}