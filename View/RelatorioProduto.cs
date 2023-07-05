using ProjetoHotelSerranoSenac;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System.Data;
using System.Diagnostics;
using System.Drawing;

namespace View
{

    public class RelatorioProduto : Form
    {
        public RelatorioProduto()
        {
            //Create a new PDF document.
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.Pages.Add();
            PdfGrid pdfGrid = new PdfGrid();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("Preço");
            dataTable.Columns.Add("Preço de Compra");
            dataTable.Columns.Add("Quantidade");
            dataTable.Columns.Add("Hotel");

            foreach (var item in ProjetoHotelSerranoSenac.Controllers.Produto.GetAllProdutos())
            {
                ProjetoHotelSerranoSenac.Models.Hotel hotelProduto = ProjetoHotelSerranoSenac.Controllers.Hotel.GetHotel(item.HotelId.ToString());
                dataTable.Rows.Add(new object[] { item.Id.ToString(), item.Nome, item.Preco.ToString(), item.PrecoCompra.ToString(), item.Quantidade.ToString(), hotelProduto.Nome });
            }

            pdfGrid.DataSource = dataTable;
            pdfGrid.Draw(page, new PointF(10, 10));

            doc.Save(System.IO.Directory.GetCurrentDirectory() + @"\RelatorioProduto.pdf");
            doc.Close(true);

            var p = new Process();
            p.StartInfo = new ProcessStartInfo(System.IO.Directory.GetCurrentDirectory() + @"\RelatorioProduto.pdf")
            {
                UseShellExecute = true
            };
            p.Start();
        }
    }
}