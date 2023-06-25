using System;

namespace ProjetoHotelSerranoSenac.Controllers
{
    public class Reserva
    {
        public static Models.Hotel hotelCrud = new();
        public static Models.Quarto quartoCrud = new();
        public static Models.Reserva reservaCrud = new();
        public static Models.Cliente clienteCrud = new();
        public static Models.Produto produtoCrud = new();
        public static Models.Servico servicoCrud = new();
        public static Models.ReservaProduto reservaProdutoCrud = new();
        public static Models.ReservaServico reservaServicoCrud = new();

        public static Models.Reserva CadastrarReserva(string clienteId, string quartoId, string dataCheckin, string dataCheckout, string hotelId, string valor)
        {
            Models.Cliente cliente = clienteCrud.Get(int.Parse(clienteId));

            Models.Quarto quarto = quartoCrud.Get(int.Parse(quartoId));
            Controllers.Quarto.GetQuartoDisponivel(quarto);

            Models.Hotel hotel = hotelCrud.Get(int.Parse(hotelId));

            Models.Reserva reserva = new(cliente.Id, quarto.Id, DateTime.Parse(dataCheckin), DateTime.Parse(dataCheckout), Double.Parse(valor), hotel.Id);

            reserva = reservaCrud.Cadastrar(reserva);

            TimeSpan diferenca = reserva.DataCheckout - reserva.DataCheckin;
            ReservarServico(reserva.Id, Controllers.Servico.GetServicoDiaria().Id, DateTime.Parse(dataCheckin), diferenca.Days);
            ReservarServico(reserva.Id, Controllers.Servico.GetServicoLimpeza().Id, DateTime.Parse(dataCheckout), 1);

            return reserva;
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
                Models.Reserva reserva = reservaCrud.Get(int.Parse(id));
                return reserva;
            }
            catch (System.Exception e)
            {
                throw new Exception("Erro ao buscar Reserva: " + e.Message);
            }          
        }

        public static Models.Reserva AlterarReserva(string reservaId, string clienteId, string quartoId, string dataCheckin, string dataCheckout, string preco, string hotelId)
        {
            try
            {
                Models.Reserva reserva = reservaCrud.Get(int.Parse(reservaId));

                reserva.ClienteId = int.Parse(clienteId);
                reserva.QuartoId = int.Parse(quartoId);
                reserva.DataCheckin = DateTime.Parse(dataCheckin);
                reserva.DataCheckout = DateTime.Parse(dataCheckout);
                reserva.Preco = double.Parse(preco);
                reserva.HotelId = int.Parse(hotelId);

                reservaCrud.Alterar(reserva);

                return reserva;
            }
            catch (System.Exception e)
            {
                throw new Exception("Erro ao alterar Reserva: " + e.Message);
            }
        }

        public static void SomarValorReserva(Models.Reserva reserva, double valor)
        {
            reserva.Preco += valor;
            reservaCrud.Alterar(reserva);
        }

        public static Models.Reserva ExcluirReserva(string id)
        {
            try
            {
                Models.Reserva reserva = reservaCrud.Get(int.Parse(id));
                reservaCrud.Excluir(reserva.Id);

                return reserva;

            }
            catch (System.Exception e)
            {
                throw new Exception("Erro ao excluir Reserva: " + e.Message);
            }
        }

        public static void GetPrazoAlteraReserva(Models.Reserva reserva)
        {
            DateTime prazo = reserva.DataCheckin.AddDays(-1);
            if (DateTime.Now > prazo)
                throw new Exception("Não é possível alterar a reserva, pois o prazo de alteração expirou.");
        }

        public static Models.ReservaProduto ReservarProduto(string reservaId, string produtoId, string quantidade)
        {
            try 
            {
                Models.Reserva reserva = reservaCrud.Get(int.Parse(reservaId));
                Models.Produto produto = produtoCrud.Get(int.Parse(produtoId));

                Models.ReservaProduto reservaProduto = new(reserva.Id, produto.Id, int.Parse(quantidade));
                SomarValorReserva(reserva, produto.Preco * int.Parse(quantidade));
                return reservaProdutoCrud.Cadastrar(reservaProduto);
            } 
            catch (System.Exception e)
            {
                throw new Exception("Erro ao reservar produto: " + e.Message);
            }
        }

        public static Models.ReservaServico ReservarServico(int reservaId, int servicoId, DateTime dataServico, int quantidade)
        {
            try 
            {
                Models.Reserva reserva = reservaCrud.Get(reservaId);
                Models.Servico servico = servicoCrud.Get(servicoId);

                Models.ReservaServico reservaServico = new(reserva.Id, servico.Id, dataServico, quantidade);
                SomarValorReserva(reserva, servico.Preco * quantidade);
                return reservaServicoCrud.Cadastrar(reservaServico);
            }
            catch (System.Exception e)
            {
                throw new Exception("Erro ao reservar serviço: " + e.Message);
            }
        }

        public static IEnumerable<Models.ReservaProduto> GetAllReservaProdutos(string reservaId)
        {
            IEnumerable<Models.ReservaProduto> reservaProduto = reservaProdutoCrud.GetAll().Where(x => x.ReservaId == int.Parse(reservaId));

            return reservaProduto;
        }

        public static IEnumerable<Models.ReservaServico> GetAllReservaServicos(string reservaId)
        {
            IEnumerable<Models.ReservaServico> reservaServico = reservaServicoCrud.GetAll().Where(x => x.ReservaId == int.Parse(reservaId));

            return reservaServico;
        }

        public static IEnumerable<Models.Reserva> GetAllReservasCliente(string clienteId)
        {
            IEnumerable<Models.Reserva> reserva = reservaCrud.GetAll().Where(x => x.ClienteId == int.Parse(clienteId));

            return reserva;
        }

        public static IEnumerable<Models.Reserva> GetAllReservasHotel(string hotelId)
        {
            IEnumerable<Models.Reserva> reserva = reservaCrud.GetAll().Where(x => x.HotelId == int.Parse(hotelId));

            return reserva;
        }

        public static IEnumerable<Models.Reserva> GetAllReservasQuarto(string quartoId)
        {
            IEnumerable<Models.Reserva> reserva = reservaCrud.GetAll().Where(x => x.QuartoId == int.Parse(quartoId));

            return reserva;
        }
    }
}