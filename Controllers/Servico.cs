namespace ProjetoHotelSerranoSenac.Controllers
{
    public class Servico
    {
        public static Models.Servico servicoCrud = new();
        public static void CadastrarServico(string tipoServico, string preco)
        {
            Models.Servico servico = new(tipoServico, double.Parse(preco));
            servicoCrud.Cadastrar(servico);
        }

        public static IEnumerable<Models.Servico> GetAllServicos()
        {
            IEnumerable<Models.Servico> servicos = servicoCrud.GetAll();

            return servicos;
        }

        public static Models.Servico GetServico(string id)
        {
            try
            {
                Models.Servico servico = servicoCrud.Get(int.Parse(id));
                return servico;
            }
            catch (System.Exception e)
            {
                throw new Exception("Erro ao buscar Servico: " + e.Message);
            }          
        }

        public static Models.Servico AlterarServico(string servicoId, string tipoServico, string preco)
        {
            try
            {
                Models.Servico servico = servicoCrud.Get(int.Parse(servicoId));

                servico.TipoServico = tipoServico;
                servico.Preco = double.Parse(preco);

                servicoCrud.Alterar(servico);

                return servico;
            }
            catch (System.Exception e)
            {
                throw new Exception("Erro ao alterar Servico: " + e.Message);
            }
        }

        public static Models.Servico ExcluirServico(string id)
        {
            try
            {
                Models.Servico servico = servicoCrud.Get(int.Parse(id));
                servicoCrud.Excluir(servico.Id);

                return servico;

            }
            catch (System.Exception e)
            {
                throw new Exception("Erro ao excluir Servico: " + e.Message);
            }
        }

        public static Models.Servico GetServicoLimpeza()
        {
            try
            {
                Models.Servico servico = servicoCrud.GetAll().FirstOrDefault(s => s.TipoServico == "Limpeza");
                return servico;
            }
            catch (System.Exception e)
            {
                throw new Exception("Erro ao buscar Servico de Limpeza: " + e.Message);
            }                   
        }

        public static Models.Servico GetServicoDiaria()
        {
            try
            {
                Models.Servico servico = servicoCrud.GetAll().FirstOrDefault(s => s.TipoServico == "Diaria");
                return servico;
            }
            catch (System.Exception e)
            {
                throw new Exception("Erro ao buscar Servico de Diaria: " + e.Message);
            }                   
        }

        public static IEnumerable<Models.Servico> GetLimpezasAgendadas()
        {
            IEnumerable<Models.Servico> servicos = servicoCrud.GetAll().Where(s => s.TipoServico == "Limpeza");
            return servicos;                
        }
    }
}