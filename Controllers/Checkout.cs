using System;

namespace ProjetoHotelSerranoSenac
{
    public class Checkout
    {
        public static Models.Reserva reservaCrud = new Models.Reserva();
        public static Models.Checkout checkoutCrud = new Models.Checkout();
        public static Models.Checkout CadastrarCheckout(string reservaId, string data_checkout)
        {
            int intReservaId = int.Parse(reservaId);
            Models.Reserva reserva = reservaCrud.Get(intReservaId);

            Models.Checkout checkout = new Models.Checkout(reserva.Id, DateTime.Parse(data_checkout));
            return checkoutCrud.Cadastrar(checkout);
        }

        public static IEnumerable<Models.Checkout> GetAllCheckouts()
        {
            IEnumerable<Models.Checkout> checkouts = checkoutCrud.GetAll();

            return checkouts;
        }

        public static Models.Checkout GetCheckout(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Checkout checkout = checkoutCrud.Get(idInt);

                    return checkout;
                }
                {
                    throw new Exception("Checkout não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao buscar Checkout");
            }
        }

        public static Models.Checkout AlterarCheckout(string checkoutId, string reservaId, string data_checkout)
        {
            try
            {
                if (checkoutId != null)
                {
                    int idInt = int.Parse(checkoutId);
                    Models.Checkout checkout = checkoutCrud.Get(idInt);

                    checkout.DataCheckout = DateTime.Parse(data_checkout);
                    checkout.ReservaId = int.Parse(reservaId);

                    checkoutCrud.Alterar(checkout);

                    return checkout;
                }
                {
                    throw new Exception("Checkout não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao alterar Checkout");
            }
        }

        public static Models.Checkout ExcluirCheckout(string id)
        {
            try
            {
            
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Checkout checkout = checkoutCrud.Get(idInt);
                    checkoutCrud.Excluir(checkout.Id);

                    return checkout;
                }
                {
                    throw new Exception("Checkout não existe ");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao excluir checkout");
            }
        }
    }
}