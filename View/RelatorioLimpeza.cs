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
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Cliente");
            dataTable.Columns.Add("Quarto");
            dataTable.Columns.Add("Data Checkin");
            dataTable.Columns.Add("Data Checkout");
            dataTable.Columns.Add("Preço");
            dataTable.Columns.Add("Hotel");

            foreach (var item in ProjetoHotelSerranoSenac.Controllers.Reserva.GetAllReservas())
            {
                ProjetoHotelSerranoSenac.Models.Cliente clienteReserva = ProjetoHotelSerranoSenac.Controllers.Cliente.GetCliente(item.ClienteId.ToString());
                ProjetoHotelSerranoSenac.Models.Quarto quartoReserva = ProjetoHotelSerranoSenac.Controllers.Quarto.GetQuarto(item.QuartoId.ToString());
                ProjetoHotelSerranoSenac.Models.Hotel hotelReserva = ProjetoHotelSerranoSenac.Controllers.Hotel.GetHotel(item.HotelId.ToString());

                String quartoNroDescricao = String.Concat(quartoReserva.NumeroQuarto, " - ", quartoReserva.Descricao);
                object[] linhaReserva = { item.Id.ToString(), clienteReserva.Nome, quartoNroDescricao, item.DataCheckin.ToString(), item.DataCheckout.ToString(), item.Preco.ToString(), hotelReserva.Nome };
                dataTable.Rows.Add(linhaReserva);
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