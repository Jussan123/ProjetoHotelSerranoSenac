using System;
using ProjetoHotelSerranoSenac.Models.Generic;

namespace ProjetoHotelSerranoSenac
{
    public class Administrador
    {
        public static Models.Administrador administradorCrud = new Models.Administrador();
        public static Models.Hotel hotelCrud = new Models.Hotel();

        public static Models.Administrador CadastrarAdministrador(string nome, string email, string senha, string hotelId)
        {
            int intHotelId = int.Parse(hotelId);
            Models.Hotel hotel = hotelCrud.Get(intHotelId);
            Models.Administrador administrador = new Models.Administrador(nome, email, senha, hotel.Id);
            return administradorCrud.Cadastrar(administrador);
        }

        public static IEnumerable<Models.Administrador> GetAllAdministradores()
        {
            IEnumerable<Models.Administrador> administradores = administradorCrud.GetAll();

            return administradores;
        }

        public static Models.Administrador GetAdministrador(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Administrador administrador = administradorCrud.Get(idInt);

                    return administrador;
                }
                {
                    throw new Exception("Administrador não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao buscar administrador");
            }
        }

        public static Models.Administrador AlterarAdministrador(string administradorId, string nome, string email, string senha, string hotelId)
        {
            try
            {
                if (administradorId != null)
                {
                    int idInt = int.Parse(administradorId);
                    Models.Administrador administrador = administradorCrud.Get(idInt);

                    administrador.Nome = nome;
                    administrador.Email = email;
                    administrador.Senha = senha;
                    administrador.HotelId = int.Parse(hotelId);

                    administradorCrud.Alterar(administrador);

                    return administrador;
                }
                {
                    throw new Exception("Administrador não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao alterar administrador");
            }
        }

        public static Models.Administrador ExcluirAdministrador(string id)
        {
            try
            { 
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Administrador administrador = administradorCrud.Get(idInt);

                    administradorCrud.Excluir(idInt);

                    return administrador;
                }
                {
                    throw new Exception("Administrador não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao excluir administrador");
            }
        }
    }
}