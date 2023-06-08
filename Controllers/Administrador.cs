using System;

namespace ProjetoHotelSerranoSenac
{
    public class Administrador
    {
        public static Models.Administrador CadastrarAdministrador(string administradorId, string nome, string email, string senha, string hotelId)
        {
            int intAdministradorId = int.Parse(administradorId);
            Models.Administrador administrador = Models.Administrador.Get(intAdministradorId);

            int intHotelId = int.Parse(hotelId);
            Models.Hotel hotel = Models.Hotel.Get(intHotelId);

            return new Models.Administradores.Cadastrar(administrador, nome, email, senha, hotel);

        }

        public static List<Models.Administrador> GetAllAdministradores()
        {
            List<Models.Administrador> administradores = new List<Models.Administrador>();
            administradores = Models.Administrador.GetAll();

            return administradores;
        }

        public static Models.Administrador GetAdministrador(string id)
        {
            int intId = int.Parse(id);
            Models.Administrador administradores Models.Administrador.GetAll(intId);

            return administradores;
        }

        public static Models.Administrador AlterarAdministrador(string administradorId, string nome, string email, string senha, string hotelId)
        {
            int intAdministradorId = int.Parse(administradorId);
            Models.Administrador administrador = Models.Administrador.Get(intAdministradorId);

            int intHotelId = int.Parse(hotelId);
            Models.Hotel hotel = Models.Hotel.Get(intHotelId);

            return Models.Administrador.Alterar(intHotelId, nome, email, senha, intHotelId);
        }

        public static Models.Administrador ExcluirAdministrador(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.administrador administrador = Models.Administrador.Excluir(idInt);

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