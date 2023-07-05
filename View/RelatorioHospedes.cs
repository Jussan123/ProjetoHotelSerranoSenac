using ProjetoHotelSerranoSenac;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System.Data;
using System.Diagnostics;
using System.Drawing;

namespace View
{

    public class RelatorioHospedes : Form
    {
        public RelatorioHospedes()
        {
            //Create a new PDF document.
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.Pages.Add();
            PdfGrid pdfGrid = new PdfGrid();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Telefone");
            dataTable.Columns.Add("Hotel");

            foreach (var item in ProjetoHotelSerranoSenac.Controllers.Cliente.GetAllClientes())
            {
                ProjetoHotelSerranoSenac.Models.Hotel hotelCliente = ProjetoHotelSerranoSenac.Controllers.Hotel.GetHotel(item.HotelId.ToString());

                dataTable.Rows.Add(new object[] { item.Id.ToString(), item.Nome, item.Email, item.Telefone, hotelCliente.Nome });
            }

            pdfGrid.DataSource = dataTable;
            pdfGrid.Draw(page, new PointF(10, 10));

            doc.Save(System.IO.Directory.GetCurrentDirectory() + @"\RelatorioHospedes.pdf");
            doc.Close(true);

            var p = new Process();
            p.StartInfo = new ProcessStartInfo(System.IO.Directory.GetCurrentDirectory() + @"\RelatorioHospedes.pdf")
            {
                UseShellExecute = true
            };
            p.Start();
        }
    }
}