using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHotelSerranoSenac.Models.Generic
{
    public abstract class CreateReadUpdateDelete<T> : ICreateReadUpdateDelete<T> where T : class
    {
        public T Cadastrar(T obj)
        {
            Banco.DataBase db = new Banco.DataBase();
            db.Set<T>().Add(obj);
            db.SaveChanges();

            return obj;
        }

        public IEnumerable<T> GetAll()
        {
            Banco.DataBase db = new Banco.DataBase();
            return db.Set<T>().ToList();
        }

        public T Get(int id)
        {
            Banco.DataBase db = new Banco.DataBase();
            return db.Set<T>().Find(id);
        }

        public T Alterar(T obj)
        {
            Banco.DataBase db = new Banco.DataBase();
            db.Set<T>().Update(obj);
            db.SaveChanges();
            return obj;
        }

        public void Excluir(int id)
        {
            Banco.DataBase db = new Banco.DataBase();
            db.Set<T>().Remove(Get(id));
            db.SaveChanges();
        }
    }
}