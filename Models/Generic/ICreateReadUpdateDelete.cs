using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHotelSerranoSenac.Models.Generic
{
    public interface ICreateReadUpdateDelete
    {
        public static T Cadastrar(T obj);
        public static IEnumerable<T> GetAll();
        public static T Get(int id);
        public static T Alterar(T obj);
        public static void Excluir(int id);
    }
}