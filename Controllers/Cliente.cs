using System;

namespace ProjetoHotelSerranoSenac
{
    public class Cliente
    {
        public static Models.Hotel hotelCrud = new Models.Hotel();
        public static Models.Cliente clienteCrud = new Models.Cliente();
        public static Models.Cliente CadastrarCliente(string nome, string email, string telefone, string hotelId)
        {
            int intHotelId = int.Parse(hotelId);
            Models.Hotel hotel = hotelCrud.Get(intHotelId);

            Models.Cliente cliente = new Models.Cliente(nome, email, telefone, hotel.Id);

            return clienteCrud.Cadastrar(cliente);
        }

        public static Models.Cliente GetCliente(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Cliente cliente = clienteCrud.Get(idInt);

                    return cliente;
                }
                {
                    throw new Exception("Cliente não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao buscar Cliente");
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
                if (clienteId != null)
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
                {
                    throw new Exception("Cliente não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao alterar Cliente");
            }
        }

        public static Models.Cliente ExcluirCliente(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Cliente cliente = clienteCrud.Get(idInt);
                    clienteCrud.Excluir(cliente.Id);

                    return cliente;
                }
                else
                {
                    throw new Exception("Cliente não encontrado");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao excluir Cliente!");
            }
        }

    }
}