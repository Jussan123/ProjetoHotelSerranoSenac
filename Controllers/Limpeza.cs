using System;

namespace ProjetoHotelSerranoSenac
{
    public class Limpeza
    {
        public static Models.Limpeza CadastrarLimpeza(string quartoId, string data, string checkoutId, string funcionarioId)
        {
            int intQuartoId = intParse(quartoId);
            Models.Quarto quarto = Models.Quarto.Get(intQuartoId);

            int intCheckoutId = intParse(checkoutId);
            Models.Checkout checkout = Models.Checkout.Get(intCheckoutId);

            int intFuncionarioId = intParse(funcionarioId);
            Models.Funcionario funcionario = Models.Funcionario.Get(intFuncionarioId);

            Models.Limpeza limpeza = new Models.Despesa.Get(quarto, data, checkout, funcionario);
            return Models.Limpeza.Cadastrar(limpeza);
        }

        public static List<Models.Limpeza> GetAllLimpezas()
        {
            List<Models.Limpeza> limpeza = Models.Limpeza.GetAll();

            return limpeza;
        }

        public static Models.Limpeza GetLimpeza(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Limpeza limpeza = Models.Limpeza.Get(idInt);

                    return limpeza;
                }
                {
                    throw new Exception("Limpeza não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao buscar Limpeza");
            }
        }

        public static Models.Limpeza AlterarLimpeza(string limpezaId ,string quartoId, string data, string checkoutId, string funcionarioId)
        {
            try
            {
                if (limpezaId != null)
                {
                    int idInt = int.Parse(limpezaId);
                    Models.Limpeza limpeza = Models.Limpeza.Get(idInt);

                    limpeza.QuartoId = int.Parse(quartoId);
                    limpeza.Data = data;
                    limpeza.CheckoutId = int.Parse(checkoutId);
                    limpeza.FuncionarioId = int.Parse(funcionarioId);

                    Models.limpeza.Alterar(limpeza);

                    return limpeza;
                }
                {
                    throw new Exception("Limpeza não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao alterar Limpeza");
            }
        }

        public static Models.Limpeza ExcluirLimpeza(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Limpeza limpeza = Models.Limpeza.Get(idInt);
                    Models.Limpeza.Excluir(idInt);

                    return limpeza;
                }
                else
                {
                    throw new Exception("Limpeza não encontrado");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao excluir Limpeza!");
            }
        }
    }
}