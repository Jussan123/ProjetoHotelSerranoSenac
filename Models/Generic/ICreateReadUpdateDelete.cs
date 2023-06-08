using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHotelSerranoSenac.Models.Generic
{
    public interface ICreateReadUpdateDelete
    {
        public T Cadastrar(T obj);
        public IEnumerable<T> GetAll();
        public T Get(int id);
        public T Alterar(T obj);
        public void Excluir(int id);
    }
}