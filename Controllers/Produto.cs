using System;

namespace ProjetoHotelSerranoSenac.Controllers
{
    public class Produto
    {
        public static Models.Produto produtoCrud = new();

        public static Models.Produto CadastrarProduto(string nome, string preco, string quantidade,  string precoCompra, string hotelId)
        {
            Models.Produto produto = new(nome, Double.Parse(preco),  Double.Parse(quantidade),  Double.Parse(precoCompra), int.Parse(hotelId));
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
                Models.Produto produto = produtoCrud.Get(int.Parse(id));

                return produto;

            }
            catch (System.Exception e)
            {
                throw new Exception("Erro ao buscar Produto: " + e.Message);
            }
        }

        public static Models.Produto AlterarProduto(string produtoId, string nome, string preco, string quantidade,  string precoCompra, string hotelId)
        {
            try
            {
                int idInt = int.Parse(produtoId);
                Models.Produto produto = produtoCrud.Get(idInt);

                produto.Nome = nome;
                produto.Preco = Double.Parse(preco);
                produto.Quantidade = Double.Parse(quantidade);
                produto.PrecoCompra = Double.Parse(precoCompra);
                produto.HotelId = int.Parse(hotelId);

                produtoCrud.Alterar(produto);

                return produto;
            }
            catch (System.Exception e)
            {
                throw new Exception("Erro ao alterar Produto: " + e.Message);
            }
        }

        public static Models.Produto ExcluirProduto(string id)
        {
            try
            {
                int idInt = int.Parse(id);
                Models.Produto produto = produtoCrud.Get(idInt);
                produtoCrud.Excluir(idInt);

                return produto;
            }
            catch (System.Exception e)
            {
                throw new Exception("Erro ao excluir Produto: " + e.Message);
            }
        }
    }
}