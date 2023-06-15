using System;

namespace ProjetoHotelSerranoSenac
{
    public class Checkin
    {
        public static Models.Reserva reservaCrud = new Models.Reserva();
        public static Models.Checkin checkinCrud = new Models.Checkin();

        public static Models.Checkin CadastrarCheckinstring(string reservaId, string data_checkin)
        {
            int intReservaId = int.Parse(reservaId);
            Models.Reserva reserva = reservaCrud.Get(intReservaId);

            Models.Checkin checkin = new Models.Checkin(reserva.Id, DateTime.Parse(data_checkin));
            return checkinCrud.Cadastrar(checkin);
        }

        public static IEnumerable<Models.Checkin> GetAllCheckins()
        {
            IEnumerable<Models.Checkin> checkins = checkinCrud.GetAll();

            return checkins;
        }

        public static Models.Checkin GetCheckins(string id)
        {
            try
            {
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Checkin checkin = checkinCrud.Get(idInt);

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
                    Models.Checkin checkin = checkinCrud.Get(idInt);

                    checkin.DataCheckin = DateTime.Parse(data_checkin);
                    checkin.ReservaId = int.Parse(reservaId);

                    checkinCrud.Alterar(checkin);

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
                if (id != null)
                {
                    int idInt = int.Parse(id);
                    Models.Checkin checkin = checkinCrud.Get(idInt);

                    checkinCrud.Excluir(idInt);

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