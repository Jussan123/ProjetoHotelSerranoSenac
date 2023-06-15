using System;

namespace ProjetoHotelSerranoSenac
{
    public class Produto
    {
        public static Models.Produto produtoCrud = new Models.Produto();

        public static Models.Produto CadastrarProduto(string nome, string preco, string quantidade, string precoVenda, string precoCompra)
        {
            Models.Produto produto = new Models.Produto(nome, Double.Parse(preco), int.Parse(quantidade), Double.Parse(precoVenda), Double.Parse(precoCompra));
            return produtoCrud.Cadastrar(produto);
        }

        public static IEnumerable<Models.Produto> GetAllProdutos()
        {
            IEnumerable<Models.Produto> produto = produtoCrud.GetAll();

            return produto;
        }

        public static Models.Produto GetProduto(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Produto produto = produtoCrud.Get(idInt);

                    return produto;
                }
                {
                    throw new Exception("Produto não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao buscar Produto");
            }
        }

        public static Models.Produto AlterarProduto(string produtoId, string nome, string preco, string quantidadeEstoque, string precoVenda, string precoCompra)
        {
            try
            {
                if (produtoId != null)
                {
                    int idInt = int.Parse(produtoId);
                    Models.Produto produto = produtoCrud.Get(idInt);

                    produto.Nome = nome;
                    produto.Preco = Double.Parse(preco);
                    produto.QuantidadeEstoque = int.Parse(quantidadeEstoque);
                    produto.PrecoVenda = Double.Parse(precoVenda);
                    produto.PrecoCompra = Double.Parse(precoCompra);

                    produtoCrud.Alterar(produto);

                    return produto;
                }
                {
                    throw new Exception("Produto não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao alterar Produto");
            }
        }

        public static Models.Produto ExcluirProduto(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Produto produto = produtoCrud.Get(idInt);
                    produtoCrud.Excluir(idInt);

                    return produto;
                }
                else
                {
                    throw new Exception("Produto não encontrado");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao excluir Produto!");
            }
        }
    }
}