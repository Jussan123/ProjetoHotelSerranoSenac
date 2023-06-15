using System;

namespace ProjetoHotelSerranoSenac
{
    public class Reserva
    {
        public static Models.Hotel hotelCrud = new Models.Hotel();
        public static Models.Quarto quartoCrud = new Models.Quarto();
        public static Models.Reserva reservaCrud = new Models.Reserva();
        public static Models.Cliente clienteCrud = new Models.Cliente();

        public static Models.Reserva CadastrarReserva(string clienteId, string quartoId, string dataCheckin, string dataCheckout, string preco, string hotelId)
        {
            Models.Cliente cliente = clienteCrud.Get(int.Parse(clienteId));

            Models.Quarto quarto = quartoCrud.Get(int.Parse(quartoId));

            Models.Hotel hotel = hotelCrud.Get(int.Parse(hotelId));

            Models.Reserva reserva = new Models.Reserva(cliente.Id, quarto.Id, DateTime.Parse(dataCheckin), DateTime.Parse(dataCheckout), Double.Parse(preco), hotel.Id);
            return reservaCrud.Cadastrar(reserva);
        }

        public static IEnumerable<Models.Reserva> GetAllReservas()
        {
            IEnumerable<Models.Reserva> reserva = reservaCrud.GetAll();

            return reserva;
        }

        public static Models.Reserva GetReserva(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Reserva reserva = reservaCrud.Get(idInt);

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

        public static Models.Reserva AlterarReserva(string reservaId, string clienteId, string quartoId, string dataCheckin, string dataCheckout, string preco, string hotelId)
        {
            try
            {
                if (reservaId != null)
                {
                    int idInt = int.Parse(reservaId);
                    Models.Reserva reserva = reservaCrud.Get(idInt);

                    reserva.ClienteId = int.Parse(clienteId);
                    reserva.QuartoId = int.Parse(quartoId);
                    reserva.DataCheckin = DateTime.Parse(dataCheckin);
                    reserva.DataCheckout = DateTime.Parse(dataCheckout);
                    reserva.Preco = Double.Parse(preco);
                    reserva.HotelId = int.Parse(hotelId);

                    reservaCrud.Alterar(reserva);

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
                    Models.Reserva reserva = reservaCrud.Get(idInt);
                    reservaCrud.Excluir(idInt);

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