using System;

namespace ProjetoHotelSerranoSenac
{
    public class Administrador
    {
        public static Models.Administrador CadastrarAdministrador(string nome, string email, string senha, string hotelId)
        {
            int intHotelId = int.Parse(hotelId);
            Models.Hotel hotel = Models.Hotel.Get(intHotelId);
            Models.Administrador administrador = new Models.Administrador(nome, email, senha, hotel);
            return Models.Administrador.Cadastrar(administrador);
        }

        public static List<Models.Administrador> GetAllAdministradores()
        {
            List<Models.Administrador> administradores = Models.Administrador.GetAll();

            return administradores;
        }

        public static Models.Administrador GetAdministrador(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Administrador administrador = Models.Administrador.Get(idInt);

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
                    Models.Administrador administrador = Models.Administrador.Get(idInt);

                    administrador.Nome = nome;
                    administrador.Email = email;
                    administrador.Senha = senha;
                    administrador.HotelId = int.Parse(hotelId);

                    Models.Administrador.Alterar(administrador);

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
                    Models.Administrador administrador = Models.Administrador.Get(idInt);

                    Models.Administrador.Excluir(idInt);

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