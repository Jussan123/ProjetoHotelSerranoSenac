using System;

namespace ProjetoHotelSerranoSenac
{
    public class Funcionario
    {
        public static Models.Funcionario CadastrarFuncionario(string nome, string email, string telefone, string salario, string funcao, string hotelId)
        {
            int intHotelId = intParse(hotelId);
            Models.Hotel hotel = Models.Hotel.Get(intHotelId);

            Models.Funcionario funcionario = new Models.Despesa.Get(produto, nome, email, telefone, salario, funcao, hotel);
            return Models.Funcionario.Cadastrar(funcionario);
        }

        public static List<Models.Funcionario> GetAllFuncionarios()
        {
            List<Models.Funcionario> funcionario = Models.Funcionario.GetAll();

            return funcionario;
        }

        public static Models.Funcionario GetFuncionario(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Funcionario funcionario = Models.Funcionario.Get(idInt);

                    return funcionario;
                }
                {
                    throw new Exception("Funcionario não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao buscar Funcionario");
            }
        }

        public static Models.Funcionario AlterarFuncionario(string funcionarioId, string nome, string email, string telefone, string salario, string funcao, string hotelId)
        {
            try
            {
                if (funcionarioId != null)
                {
                    int idInt = int.Parse(funcionarioId);
                    Models.Funcionario funcionario = Models.Funcionario.Get(idInt);

                    funcionario.Nome = nome;
                    funcionario.Email = email;
                    funcionario.Telefone = telefone;
                    funcionario.Salario = salario;
                    funcionario.Funcao = funcao;
                    funcionario.HotelId = int.Parse(hotelId);

                    Models.Funcionario.Alterar(funcionario);

                    return funcionario;
                }
                {
                    throw new Exception("Funcionario não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao alterar Funcionario");
            }
        }

        public static Models.Funcionario ExcluirFuncionario(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Funcionario funcionario = Models.Funcionario.Get(idInt);
                    Models.Funcionario.Excluir(idInt);

                    return funcionario;
                }
                else
                {
                    throw new Exception("Funcionario não encontrado");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao excluir Funcionario!");
            }
        }
    }
}