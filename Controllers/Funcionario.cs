using System;

namespace ProjetoHotelSerranoSenac
{
    public class Funcionario
    {
        public static Models.Funcionario funcionarioCrud = new Models.Funcionario();

        public static Models.Funcionario CadastrarFuncionario(string nome, string email, string telefone, string role, string salario)
        {
            Models.Funcionario funcionario = new Models.Funcionario(nome, email, telefone, role, Double.Parse(salario));
            return funcionarioCrud.Cadastrar(funcionario);
        }

        public static IEnumerable<Models.Funcionario> GetAllFuncionarios()
        {
            IEnumerable<Models.Funcionario> funcionario = funcionarioCrud.GetAll();

            return funcionario;
        }

        public static Models.Funcionario GetFuncionario(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Funcionario funcionario = funcionarioCrud.Get(idInt);

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

        public static Models.Funcionario AlterarFuncionario(string funcionarioId, string nome, string email, string telefone, string role, string salario)
        {
            try
            {
                if (funcionarioId != null)
                {
                    int idInt = int.Parse(funcionarioId);
                    Models.Funcionario funcionario = funcionarioCrud.Get(idInt);

                    funcionario.Nome = nome;
                    funcionario.Email = email;
                    funcionario.Telefone = telefone;
                    funcionario.Salario = Double.Parse(salario);
                    funcionario.Role = role;

                    funcionarioCrud.Alterar(funcionario);

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
                    Models.Funcionario funcionario = funcionarioCrud.Get(idInt);
                    funcionarioCrud.Excluir(idInt);

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