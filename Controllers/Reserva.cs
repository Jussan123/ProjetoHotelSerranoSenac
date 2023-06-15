using System;

namespace ProjetoHotelSerranoSenac
{
    public class Reserva
    {
        public static Models.Hotel hotelCrud = new Models.Hotel();
        public static Models.Quarto quartoCrud = new Models.Quarto();
        public static Models.Reserva reservaCrud = new Models.Reserva();
        public static Models.Cliente clienteCrud = new Models.Cliente();
        public static Models.Funcionario funcionarioCrud = new Models.Funcionario();
        public static Models.Reserva CadastrarReserva(string clienteId, string quartoId, string data_checkin, string data_checkout, string preco, string hotelId, string funcionarioId)
        {
            Models.Cliente cliente = clienteCrud.Get(int.Parse(clienteId));

            Models.Quarto quarto = quartoCrud.Get(int.Parse(quartoId));

            Models.Hotel hotel = hotelCrud.Get(int.Parse(hotelId));

            Models.Funcionario funcionario = funcionarioCrud.Get(int.Parse(funcionarioId));

            Models.Reserva reserva = new Models.Reserva(cliente.Id, quarto.Id, DateTime.Parse(data_checkin), DateTime.Parse(data_checkout), Decimal.Parse(preco), hotel.Id, funcionario.Id);
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

        public static Models.Reserva AlterarReserva(string reservaId, string clienteId, string quartoId, string data_checkin, string data_checkout, string preco, string hotelId, string funcionarioId)
        {
            try
            {
                if (reservaId != null)
                {
                    int idInt = int.Parse(reservaId);
                    Models.Reserva reserva = reservaCrud.Get(idInt);

                    reserva.ClienteId = int.Parse(clienteId);
                    reserva.QuartoId = int.Parse(quartoId);
                    reserva.DataCheckin = DateTime.Parse(data_checkin);
                    reserva.DataCheckout = DateTime.Parse(data_checkout);
                    reserva.Preco = Decimal.Parse(preco);
                    reserva.HotelId = int.Parse(hotelId);
                    reserva.FuncionarioId = int.Parse(funcionarioId);

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