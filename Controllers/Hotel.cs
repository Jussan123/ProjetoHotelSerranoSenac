using System;

namespace ProjetoHotelSerranoSenac.Controllers
{
    public class Hotel
    {
        public static Models.Hotel hotelCrud = new Models.Hotel();
        public static Models.Hotel CadastrarHotel(string nome, string endereco, string telefone)
        {
            Models.Hotel hotel = new Models.Hotel(nome, endereco, telefone);
            return hotelCrud.Cadastrar(hotel);
        }

        public static IEnumerable<Models.Hotel> GetAllHoteis()
        {
            IEnumerable<Models.Hotel> hotel = hotelCrud.GetAll();

            return hotel;
        }

        public static Models.Hotel GetHotel(string id)
        {
            try
            {
                int idInt = int.Parse(id);
                Models.Hotel hotel = hotelCrud.Get(idInt);

                return hotel;
            }
            catch (System.Exception e)
            {
                throw new Exception("Erro ao buscar Hotel: " + e.Message);
            }
        }

        public static Models.Hotel AlterarHotel(string hotelId, string nome, string endereco, string telefone)
        {
            try
            {
                int idInt = int.Parse(hotelId);
                Models.Hotel hotel = hotelCrud.Get(idInt);

                hotel.Nome = nome;
                hotel.Endereco = endereco;
                hotel.Telefone = telefone;

                hotelCrud.Alterar(hotel);

                return hotel;
            }
            catch (System.Exception e)
            {
                throw new Exception("Erro ao alterar Hotel: " + e.Message);
            }
        }

        public static Models.Hotel ExcluirHotel(string id)
        {
            try
            {
                int idInt = int.Parse(id);
                Models.Hotel hotel = hotelCrud.Get(idInt);
                hotelCrud.Excluir(hotel.Id);

                return hotel;
            }
            catch (System.Exception e)
            {
                throw new Exception("Erro ao excluir Hotel: " + e.Message);
            }
        }
    }
}