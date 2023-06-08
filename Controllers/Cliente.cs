using System;

namespace ProjetoHotelSerranoSenac
{
    public class Cliente
    {
       public static Models.Cliente CadastrarCliente(string clienteId, string nome, string email, string telefone, string hotelId)
       {
            int intClienteId = int.Parse(clienteId);
            Models.Cliente cliente = Models.Cliente.Get(intClienteId);

            int intHotelId = int.Parse(hotelId);
            Models.Hotel hotel = Models.Hotel.Get(intHotelId);

            return new Models.Cliente.Cadastrar(cliente, nome, email, telefone, hotel);
       }

       public static Models.Cliente GetCliente(string id)
       {
            int intClienteId = int.Parse(id);
            Models.Cliente cliente = Models.Cliente.Get(intClienteId);

            return cliente;
       }

       public static List<Models.Cliente> GetAllClientes()
       {
            List<Models.Cliente> clientes = new List<Models.Cliente>();
            clientes = Models.Cliente.GetAll();

            return clientes;
       }

       public static Models.Cliente AlterarCliente(string clienteId, string nome, string email, string telefone, string hotelId)
       {
            int intClienteId = int.Parse(clienteId);
            Models.Cliente cliente = Models.Cliente.Get(intClienteId);

            int intHotelId = int.Parse(hotelId);
            Models.Hotel hotel = Models.Hotel.Get(intHotelId);

            return Models.Cliente.Alterar(cliente, nome, email, telefone, hotel);
       }

       public static Models.Cliente ExcluirCliente(string id)
       {
            try
            {
                int intClienteId = int.Parse(id);

                if (intClienteId != null)

                {
                    Models.Cliente cliente = Models.Cliente.Get(intClienteId);
                    cliente.Excluir();
                    
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