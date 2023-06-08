using System;

namespace ProjetoHotelSerranoSenac
{
    public class Checkin
    {
        public static Models.Checkin CadastrarCheckin(string checkinId, string reservaId, string data_checkin)
        {
            int intCheckinId = int Parse(checkinId);
            Models.Checkin checkin = Models.Checkin.Get(intCheckinId);

            int intReservaId = int Parse(reservaId);
            Models.Reserva reserva = Models.Reserva.Get(intReservaId);

            return new Models.Checkin.Cadastrar(checkin, reserva, data_checkin);
        }

        public static List<Models.Checkin> GetAllCheckins()
        {
            List<Models.Checkin> checkins = new List<Models.Checkin>();
            checkins = Models.Checkin.GetAll();

            return checkins;
        }

        public static Models.Checkin GetCheckins(string id)
        {
            int intCheckinId = int Parse(id);
            Models.Checkin checkin = Models.Checkin.Get(intCheckinId);

            return checkin;
        }

        public static Models.Checkin AlterarCheckin(string checkinId, string reservaId, string data_checkin)
        {
            int intCheckinId = int Parse(checkinId);
            Models.Checkin checkin = Models.Checkin.Get(intCheckinId);
            int intReservaId = int Parse(reservaId);
            Models.Reserva reserva = Models.Reserva.Get(intReservaId);

            return checkin.Alterar(reserva, reserva, data_checkin);
        }

        public static Models.Checkin ExcluirCheckin(string id)
        {
            try
            {
                int idInt = int.Parse(id);

                if (idInt != null)
                {

                    Models.Checkin checkin = Models.Checkin.Excluir(idInt);

                    return idInt;
                }
                {
                    throw new Exception("Checkin não existe");
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Erro ao excluir Checking");
            }
        }
    }
}