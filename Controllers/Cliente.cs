using System;

namespace ProjetoHotelSerranoSenac.Controllers
{
    public class Cliente
    {
        public static Models.Hotel hotelCrud = new();
        public static Models.Cliente clienteCrud = new();
        public static Models.Cliente CadastrarCliente(string nome, string email, string telefone, string hotelId)
        {
            int intHotelId = int.Parse(hotelId);
            Models.Hotel hotel = hotelCrud.Get(intHotelId);

            Models.Cliente cliente = new(nome, email, telefone, hotel.Id);

            return clienteCrud.Cadastrar(cliente);
        }

        public static Models.Cliente GetCliente(string id)
        {
            try
            {
                Models.Cliente cliente = clienteCrud.Get(int.Parse(id));

                return cliente;
            }
            catch (System.Exception e)
            {
                throw new Exception("Erro ao buscar Cliente: " + e.Message);
            }
        }

        public static IEnumerable<Models.Cliente> GetAllClientes()
        {
            IEnumerable<Models.Cliente> clientes = clienteCrud.GetAll();

            return clientes;
        }

        public static Models.Cliente AlterarCliente(string clienteId, string nome, string email, string telefone, string hotelId)
        {

            try
            {
                int idInt = int.Parse(clienteId);
                Models.Cliente cliente = clienteCrud.Get(idInt);

                cliente.Nome = nome;
                cliente.Email = email;
                cliente.Telefone = telefone;
                cliente.HotelId = int.Parse(hotelId);

                clienteCrud.Alterar(cliente);

                return cliente;
            }
            catch (System.Exception e)
            {
                throw new Exception("Erro ao alterar Cliente: " + e.Message);
            }
        }

        public static Models.Cliente ExcluirCliente(string id)
        {
            try
            {
                int idInt = int.Parse(id);
                Models.Cliente cliente = clienteCrud.Get(idInt);
                clienteCrud.Excluir(cliente.Id);

                return cliente;
            }
            catch (System.Exception e)
            {
                throw new Exception("Erro ao excluir Cliente: " + e.Message);
            }
        }
    }
}