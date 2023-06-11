using System;

namespace ProjetoHotelSerranoSenac
{
    public class Despesa
    {
        public static Models.Cliente CadastrarDespesa(string despesaId, string reservaId, string produtoId, string valor, string quantidade)
        {
            int intDespesaId = int Parse(despesaId);
            Models.Despesa despesa = Models.Despesa.Get(intDespesaId);

            int intReservaId = intParse(reservaId);
            Models.Reserva reserva = Models.Reserva.Get(intReserva);

            int intProdutoId = intParse(produtoId);
            Models.Produto produto = Models.Produto.Get(intProdutoId);

            return new Models.Despesa.Cadastrar(despesa.Id, reserva.Id, produto.Id, valor, quantidade);
        }

        public static List<Models.Despesa> GetAllDespesas()
        {
            List<Models.Despesa> Despesas = new List<Models.Despesa>();
            Despesas = Models.Despesa.GetAll();

            return Despesas;
        }

        public static Models.Despesa GetDespesa(string id)
        {
            int intDespesaId = int.Parse(id);
            Models.Despesa despesa = Models.Despesa.Get(intDespesaId);

            return despesa;
        }

        public static Models.Despesa AlterarDespesa(string despesaId, string reservaId, string produtoId, string valor, string quantidade)
        {
            int intDespesaId = intParse(despesaId);
            Models.Despesa despesa = Models.Despesa.Get(intDespesaId);

            int intReservaId = intParse(reservaId);
            Models.Reserva reserva = Models.Reserva.Get(intReservaId);

            int intProdutoId = intParse(produtoId);
            Models.Produto produto = Models.Produto.Get(intProdutoId);

            return Models.Despesa.Alterar(despesa, reserva, produto, valor, quantidade);
        }

        public static Models.Despesa Excluir(string id)
        {

            try
            {
                int intDespesaId = int.Parse(id);

                if (intDespesaId != null)

                {
                    Models.Despesa despesa = Models.Despesa.Get(intDespesaId);
                    despesa.Excluir();

                    return despesa;
                }
                else
                {
                    throw new Exception("Despesa não encontrado");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao excluir Despesa!");
            }
        }
    }
}