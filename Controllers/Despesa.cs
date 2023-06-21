using System;

namespace ProjetoHotelSerranoSenac
{
    public class Despesa
    {
        public static Models.Despesa CadastrarDespesa(string reservaId, string produtoId, string valor, string quantidade)
        {
            int intReservaId = intParse(reservaId);
            Models.Reserva reserva = Models.Reserva.Get(intReserva);

            int intProdutoId = intParse(produtoId);
            Models.Produto produto = Models.Produto.Get(intProdutoId);

            Models.Despesa despesa = Models.Despesa.Get(reserva, produto, valor, quantidade);
            return Models.Despesa.Cadastrar(despesa);
        }

        public static List<Models.Despesa> GetAllDespesas()
        {
            List<Models.Despesa> Despesas = Models.Despesa.GetAll();

            return Despesas;
        }

        public static Models.Despesa GetDespesa(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Despesa despesa = Models.Despesa.Get(idInt);

                    return despesa;
                }
                {
                    throw new Exception("Despesa não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao buscar Despesa");
            }
        }

        public static Models.Despesa AlterarDespesa(string despesaId, string reservaId, string produtoId, string valor, string quantidade)
        {
            try
            {
                if (despesaId != null)
                {
                    int idInt = int.Parse(despesaId);
                    Models.Despesa despesa = Models.Despesa.Get(idInt);

                    despesa.ReservaId = int.Parse(reservaId);
                    despesa.ProdutoId = int.Parse(produtoId);
                    despesa.Valor = valor;
                    despesa.Quantidade = quantidade;

                    Models.Despesa.Alterar(despesa);

                    return despesa;
                }
                {
                    throw new Exception("Despesa não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao alterar Despesa");
            }
        }

        public static Models.Despesa ExcluirDespesa(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Despesa despesa = Models.Despesa.Get(idInt);
                    Models.Despesa.Excluir(idInt);

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