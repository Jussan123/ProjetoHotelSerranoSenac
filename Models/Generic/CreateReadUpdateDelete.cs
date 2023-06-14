using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHotelSerranoSenac.Models.Generic
{
    public abstract class CreateReadUpdateDelete<T> : ICreateReadUpdateDelete
    {
        public static T Cadastrar(T obj)
        {
            T objCreated = new T();
            Banco.DataBase db = new Banco.DataBase();
            db.Set<T>().Add(obj);
            db.SaveChanges();

            return objCreated;
        }

        public static IEnumerable<T> GetAll()
        {
            Banco.DataBase db = new Banco.DataBase();
            return db.Set<T>().ToList();
        }

        public static T Get(int id)
        {
            Banco.DataBase db = new Banco.DataBase();
            return db.Set<T>().Find(id);
        }

        public static T Alterar(T obj)
        {
            Banco.DataBase db = new Banco.DataBase();
            db.Set<T>().Update(obj);
            db.SaveChanges();
            return obj;
        }

        public static void Excluir(int id)
        {
            Banco.DataBase db = new Banco.DataBase();
            db.Set<T>().Remove(Get(id));
            db.SaveChanges();
        }
    }
}