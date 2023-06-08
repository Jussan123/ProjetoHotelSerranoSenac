using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHotelSerranoSenac.Models.Generic
{
    public abstract class CreateReadUpdateDelete<T> : ICreateReadUpdateDelete
    {
        public T Cadastrar(T obj)
        {
            T objCreated = new T();
            return objCreated;

            Banco db = new Banco();
            db.Set<T>().Add(obj);
            db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            Banco db = new Banco();
            return db.Set<T>().ToList();
        }

        public T Get(int id)
        {
            Banco db = new Banco();
            return db.Set<T>().Find(id);
        }

        public T Alterar(T obj)
        {
            Banco db = new Banco();
            db.Set<T>().Update(obj);
            db.SaveChanges();
            return obj;
        }

        public void Excluir(int id)
        {
            Banco db = new Banco();
            db.Set<T>().Remove(Get(id));
            db.SaveChanges();
        }
    }
}