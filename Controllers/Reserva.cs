using System;

namespace ProjetoHotelSerranoSenac
{
    public class Reserva
    {
        public static Models.Reserva CadastrarReserva(string clienteId, string quartoId, string data_checkin, string data_checkout, string preco, string hotelId)
        {
            int intClienteId = int.Parse(clienteId);
            Models.Cliente cliente = Models.Cliente.Get(intClienteId);

            int intQuartoId = intParse(quartoId);
            Models.Quarto quarto = Models.Quarto.Get(intQuartoId);

            int intHotelId = intParse(hotelId);
            Models.Hotel hotel = Models.Hotel.Get(intHotelId);

            Models.Reserva reserva = new Models.Reserva.Get(cliente, quarto, data_checkin, data_checkout, preco, hotel);
            return Models.Reserva.Cadastrar(reserva);
        }

        public static List<Models.Reserva> GetAllReservas()
        {
            List<Models.Reserva> reserva = Models.Reserva.GetAll();

            return reserva;
        }

        public static Models.Reserva GetReserva(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Reserva reserva = Models.Reserva.Get(idInt);

                    return reserva;
                }
                {
                    throw new Exception("Reserva não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao buscar Reserva");
            }
        }

        public static Models.Reserva AlterarReserva(string reservaId, string clienteId, string quartoId, string data_checkin, string data_checkout, string preco, string hotelId)
        {
            try
            {
                if (reservaId != null)
                {
                    int idInt = int.Parse(reservaId);
                    Models.Reserva reserva = Models.Reserva.Get(idInt);

                    reserva.ClienteId = int.Parse(clienteId);
                    reserva.QuartoId = int.Parse(quartoId);
                    reserva.DataCheckin = data_checkin;
                    reserva.DataCheckout = data_checkout;
                    reserva.Preco = preco;
                    reserva.FuncionarioId = int.Parse(funcionarioId);

                    Models.Reserva.Alterar(reserva);

                    return reserva;
                }
                {
                    throw new Exception("Reserva não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao alterar Reserva");
            }
        }

        public static Models.Reserva ExcluirReserva(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Reserva reserva = Models.Reserva.Get(idInt);
                    Models.Reserva.Excluir(idInt);

                    return reserva;
                }
                else
                {
                    throw new Exception("Reserva não encontrado");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao excluir Reserva!");
            }
        }
    }
}