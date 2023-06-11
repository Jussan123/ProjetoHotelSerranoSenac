using System;

namespace ProjetoHotelSerranoSenac
{
    public class Checkin
    {
        public static Models.Checkin CadastrarCheckinstring(string reservaId, string data_checkin)
        {
            int intReservaId = int.Parse(reservaId);
            Models.Reserva reserva = Models.Reserva.Get(intReservaId);

            Models.Checkin checkin = new Models.Checkin(reserva, data_checkin);
            return Models.Checkin.Cadastrar(checkin);
        }

        public static List<Models.Checkin> GetAllCheckins()
        {
            List<Models.Checkin> checkins = Models.Checkin.GetAll();

            return checkins;
        }

        public static Models.Checkin GetCheckins(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Checkin checkin = Models.Checkin.Get(idInt);

                    return checkin;
                }
                {
                    throw new Exception("Checkin não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao buscar Checkin");
            }
        }

        public static Models.Checkin AlterarCheckin(string checkinId, string reservaId, string data_checkin)
        {
            try
            {
                if (checkinId != null)
                {
                    int idInt = int.Parse(checkinId);
                    Models.Checkin checkin = Models.Checkin.Get(idInt);

                    checkin.Data_checkin = data_checkin;
                    checkin.ReservaId = int.Parse(reservaId);

                    Models.Checkin.Alterar(checkin);

                    return checkin;
                }
                {
                    throw new Exception("Checkin não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao alterar Checkin");
            }
        }

        public static Models.Checkin ExcluirCheckin(string id)
        {
            try
            {
                if (idInt != null)
                {
                    int idInt = int.Parse(id);
                    Models.Checkin checkin = Models.Checkin.Get(idInt);

                    Models.Checkin.Excluir(idInt);

                    return checkin;
                }
                {
                    throw new Exception("Checkin não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao excluir Checkin");
            }
        }
    }
}