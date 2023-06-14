using System;

namespace ProjetoHotelSerranoSenac
{
    public class Cliente
    {
        public static Models.Cliente CadastrarCliente(string nome, string email, string telefone, string hotelId)
        {
            int intHotelId = int.Parse(hotelId);
            Models.Hotel hotel = Models.Hotel.Get(intHotelId);

            Models.Cliente cliente = new Models.Cliente(nome, email, telefone, hotel);

            return Models.Cliente.Cadastrar(cliente);
        }

        public static Models.Cliente GetCliente(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Cliente cliente = Models.Cliente.Get(idInt);

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

        public static List<Models.Cliente> GetAllClientes()
        {
            List<Models.Cliente> clientes = Models.Cliente.GetAll();

            return clientes;
        }

        public static Models.Cliente AlterarCliente(string clienteId, string nome, string email, string telefone, string hotelId)
        {

            try
            {
                if (clienteId != null)
                {
                    int idInt = int.Parse(clienteId);
                    Models.Cliente cliente = Models.Cliente.Get(idInt);

                    cliente.Nome = nome;
                    cliente.Email = email;
                    cliente.Telefone = telefone;
                    cliente.HotelId = int.Parse(hotelId);

                    Models.Cliente.Alterar(cliente);

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
                    Models.Cliente cliente = Models.Cliente.Get(idInt);
                    Models.Cliente.Excluir(idInt);

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