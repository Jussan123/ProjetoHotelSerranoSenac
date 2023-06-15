using System;

namespace ProjetoHotelSerranoSenac
{
    public class Despesa
    {
        public static Models.Reserva reservaCrud = new Models.Reserva();
        public static Models.Despesa despesaCrud = new Models.Despesa();
        public static Models.Produto produtoCrud = new Models.Produto();

        public static Models.Despesa CadastrarDespesa(string reservaId, string produtoId, string valor, string quantidade)
        {
            Models.Reserva reserva = reservaCrud.Get(int.Parse(reservaId));

            Models.Produto produto = produtoCrud.Get(int.Parse(produtoId));

            Models.Despesa despesa = new Models.Despesa(reserva.Id, produto.Id, Decimal.Parse(valor), int.Parse(quantidade));
            return despesaCrud.Cadastrar(despesa);
        }

        public static IEnumerable<Models.Despesa> GetAllDespesas()
        {
            IEnumerable<Models.Despesa> Despesas = despesaCrud.GetAll();

            return Despesas;
        }

        public static Models.Despesa GetDespesa(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Despesa despesa = despesaCrud.Get(idInt);

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
                    Models.Despesa despesa = despesaCrud.Get(idInt);

                    despesa.ReservaId = int.Parse(reservaId);
                    despesa.ProdutoId = int.Parse(produtoId);
                    despesa.Valor = Decimal.Parse(valor);
                    despesa.Quantidade = int.Parse(quantidade);

                    despesaCrud.Alterar(despesa);

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
                    Models.Despesa despesa = despesaCrud.Get(idInt);
                    despesaCrud.Excluir(idInt);

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