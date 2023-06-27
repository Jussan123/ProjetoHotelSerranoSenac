using ProjetoHotelSerranoSenac;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System.Data;
using System.Diagnostics;
using System.Drawing;

namespace View
{

    public class RelatorioFuncionarios : Form
    {
        public RelatorioFuncionarios()
        {
            //Create a new PDF document.
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.Pages.Add();
            PdfGrid pdfGrid = new PdfGrid();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Função");            
            dataTable.Columns.Add("Telefone");
            dataTable.Columns.Add("Salário");

            foreach (var item in ProjetoHotelSerranoSenac.Controllers.Funcionario.GetAllFuncionarios())
            {
                //Id, Nome,Email,Senha,Role,Telefone,Salario
                dataTable.Rows.Add(new object[] { item.Id.ToString(), item.Nome, item.Email, item.Role.ToString(), item.Telefone, item.Salario.ToString() });
            }

            pdfGrid.DataSource = dataTable;
            pdfGrid.Draw(page, new PointF(10, 10));

            doc.Save(System.IO.Directory.GetCurrentDirectory() + @"\RelatorioFuncionarios.pdf");
            doc.Close(true);

            var p = new Process();
            p.StartInfo = new ProcessStartInfo(System.IO.Directory.GetCurrentDirectory() + @"\RelatorioFuncionarios.pdf")
            {
                UseShellExecute = true
            };
            p.Start();
        }
    }
}