using System;

namespace ProjetoHotelSerranoSenac
{
    public class Limpeza
    {
        public static Models.Quarto quartoCrud = new Models.Quarto();
        public static Models.Checkout checkoutCrud = new Models.Checkout();
        public static Models.Funcionario funcionarioCrud = new Models.Funcionario();
        public static Models.Limpeza limpezaCrud = new Models.Limpeza();
        public static Models.Limpeza CadastrarLimpeza(string quartoId, string data, string checkoutId, string funcionarioId)
        {
            Models.Quarto quarto = quartoCrud.Get(int.Parse(quartoId));

            Models.Checkout checkout = checkoutCrud.Get(int.Parse(checkoutId));

            Models.Funcionario funcionario = funcionarioCrud.Get(int.Parse(funcionarioId));

            Models.Limpeza limpeza = new Models.Limpeza(quarto.Id, DateTime.Parse(data), funcionario.Id, checkout.Id);
            return limpezaCrud.Cadastrar(limpeza);
        }

        public static IEnumerable<Models.Limpeza> GetAllLimpezas()
        {
            IEnumerable<Models.Limpeza> limpeza = limpezaCrud.GetAll();

            return limpeza;
        }

        public static Models.Limpeza GetLimpeza(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Limpeza limpeza = limpezaCrud.Get(idInt);

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
                    Models.Limpeza limpeza = limpezaCrud.Get(idInt);

                    limpeza.QuartoId = int.Parse(quartoId);
                    limpeza.Data = DateTime.Parse(data);
                    limpeza.CheckoutId = int.Parse(checkoutId);
                    limpeza.FuncionarioId = int.Parse(funcionarioId);

                    limpezaCrud.Alterar(limpeza);

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
                    Models.Limpeza limpeza = limpezaCrud.Get(idInt);
                    limpezaCrud.Excluir(idInt);

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