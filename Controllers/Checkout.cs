using System;

namespace ProjetoHotelSerranoSenac
{
    public class Checkout
    {
        public static Models.Checkout CadastrarCheckout(string reservaId, string data_checkout)
        {
            int intReservaId = int.Parse(reservaId);
            Models.Reserva reserva = Models.Reserva.Get(intReservaId);

            Models.Checkout checkout = Models.Checkout(reserva, data_checkout);
            return Models.Checkout.Cadastrar(checkout);
        }

        public static List<Models.Checkout> GetAllCheckouts()
        {
            List<Models.Checkout> checkouts = Models.Checkout.GetAll();

            return checkouts;
        }

        public static Models.Checkout GetCheckout(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Checkout checkout = Models.Checkout.Get(idInt);

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

        public static Models.Checkout AlterarCheckout(string checkoutId, string reservaId, string data_checkin)
        {
            try
            {
                if (checkoutId != null)
                {
                    int idInt = int.Parse(checkoutId);
                    Models.Checkout checkout = Models.Checkout.Get(idInt);

                    checkout.Data_checkin = data_checkin;
                    checkout.ReservaId = int.Parse(reservaId);

                    Models.Checkout.Alterar(checkout);

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
                    int intId = int.Parse(id);
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