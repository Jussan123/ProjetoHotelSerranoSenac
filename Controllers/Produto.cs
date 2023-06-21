using System;

namespace ProjetoHotelSerranoSenac
{
    public class Produto
    {
        public static Models.Produto CadastrarProduto(string nome, string preco, string quantidade, string hotelId)
        {
            int intHotelId = intParse(hotelId);
            Models.Hotel hotel = Models.Hotel.Get(intHotelId);

            Models.Produto produto = new Models.Despesa.Get(nome, preco, quantidade, hotel);
            return Models.Produto.Cadastrar(produto);
        }

        public static List<Models.Produto> GetAllProdutos()
        {
            List<Models.Produto> produto = Models.Produto.GetAll();

            return produto;
        }

        public static Models.Produto GetProduto(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Produto produto = Models.Produto.Get(idInt);

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

        public static Models.Produto AlterarProduto(string produtoId, string nome, string preco, string quantidade, string hotelId)
        {
            try
            {
                if (produtoId != null)
                {
                    int idInt = int.Parse(produtoId);
                    Models.Produto produto = Models.Produto.Get(idInt);

                    produto.Nome = nome;
                    produto.Preco = preco;
                    produto.Preco = preco;
                    produto.Quantidade = quantidade;
                    produto.HotelId = int.Parse(hotelId);

                    Models.Produto.Alterar(produto);

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
                    Models.Produto produto = Models.Produto.Get(idInt);
                    Models.Produto.Excluir(idInt);

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