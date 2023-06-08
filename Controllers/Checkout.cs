using System;

namespace ProjetoHotelSerranoSenac
{
    public class Checkout
    {
        public static Models.Checkout CadastrarCheckout(string checkoutId, string reservaId, string data_checkout)
        {
            int intCheckoutId = int.Parse(checkoutId);
            Models.Checkout checkout = Models.Checkout.Get(intCheckoutId);

            int intReservaId = int.Parse(reservaId);
            Models.Checkout reserva = Models.Checkout.Get(intReservaId);

            return new Models.Checkout.Cadastrar(checkout, reserva, data_checkout);
        }

        public static List<Models.Checkout> GetAllCheckouts()
        {
            List<Models.Checkout> checkouts = new List<Models.Checkout>();
            checkouts = Models.Checkout.GetAll();

            return checkouts;
        }

        public static Models.Checkout GetCheckout(string id)
        {
            int intCheckoutId = int.Parse(id);
            Models.Checkout checkout = Models.Checkout.Get(intCheckoutId);

            return checkout;
        }

        public static Models.Checkout AlterarCheckout(string checkoutId, string reservaId, string data_checkin)
        {
            int intCheckoutId = int.Parse(checkoutId);
            Models.Checkout checkout = Models.Checkout.Get(intCheckoutId);

            int intReservaId = int.Parse(reservaId);
            Models.Checkout reserva = Models.Checkout.Get(intReservaId);

            return Models.Checkout.Alter(checkout, reserva, data_checkin);
        }

        public static Models.Checkout ExcluirCheckout(string id)
        {
            try
            {
                int intId = int.Parse(id);

                if (intId != null)
                {
                    Models.Checkout checkout = Models.Checkout.Get(intId);
                    checkout.Excluir();

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