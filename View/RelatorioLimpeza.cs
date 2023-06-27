using ProjetoHotelSerranoSenac;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System.Data;
using System.Diagnostics;
using System.Drawing;

namespace View
{

    public class RelatorioLimpeza : Form
    {
        public RelatorioLimpeza()
        {
            //Create a new PDF document.
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.Pages.Add();
            PdfGrid pdfGrid = new PdfGrid();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id Reserva");
            dataTable.Columns.Add("Cliente");
            dataTable.Columns.Add("Serviço");
            dataTable.Columns.Add("Data do Serviço");
            dataTable.Columns.Add("Hotel");

            foreach (var reserva in ProjetoHotelSerranoSenac.Controllers.Reserva.GetAllReservas())
            {
                foreach (var reservaServico in ProjetoHotelSerranoSenac.Controllers.Reserva.GetAllReservaServicos(reserva.Id.ToString()))
                {
                    ProjetoHotelSerranoSenac.Models.Cliente clienteReserva = ProjetoHotelSerranoSenac.Controllers.Cliente.GetCliente(reserva.ClienteId.ToString());
                    ProjetoHotelSerranoSenac.Models.Hotel hotelReserva = ProjetoHotelSerranoSenac.Controllers.Hotel.GetHotel(reserva.HotelId.ToString());
                    ProjetoHotelSerranoSenac.Models.Servico servicoReserva = ProjetoHotelSerranoSenac.Controllers.Servico.GetServico(reservaServico.Id.ToString());

                    object[] linhaReserva = { reserva.Id.ToString(), clienteReserva.Nome, servicoReserva.TipoServico, reservaServico.DataServico.ToString(), hotelReserva.Nome };
                    dataTable.Rows.Add(linhaReserva);
                }
            }

            pdfGrid.DataSource = dataTable;
            pdfGrid.Draw(page, new PointF(10, 10));

            doc.Save(System.IO.Directory.GetCurrentDirectory() + @"\RelatorioLimpeza.pdf");
            doc.Close(true);

            var p = new Process();
            p.StartInfo = new ProcessStartInfo(System.IO.Directory.GetCurrentDirectory() + @"\RelatorioLimpeza.pdf")
            {
                UseShellExecute = true
            };
            p.Start();
        }
    }
}