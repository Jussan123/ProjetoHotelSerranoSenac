using ProjetoHotelSerranoSenac;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System.Data;
using System.Diagnostics;
using System.Drawing;

namespace View
{

    public class RelatorioDespesas : Form
    {
        Panel buttonPanel = new Panel();
        Label lblTotalSalarios;
        Label lblTotalProdutos;

        TextBox txtTotalSalarios;
        TextBox txtTotalProdutos;

        Button btnConfirmar;
        Button btnVoltar;

        public RelatorioDespesas()
        {
            this.Text = "Relatório de Despesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#748E83");

            this.Size = new Size(600, 600);

            lblTotalSalarios = new Label();
            lblTotalSalarios.Text = "Total Salários:";
            lblTotalSalarios.AutoSize = true;
            lblTotalSalarios.Location = new Point(20, 60);

            txtTotalSalarios = new TextBox();
            txtTotalSalarios.Location = new Point(120, 60);
            txtTotalSalarios.Size = new Size(200, 18);
            txtTotalSalarios.ReadOnly = true;

            lblTotalProdutos = new Label();
            lblTotalProdutos.Text = "Total Produtos:";
            lblTotalProdutos.AutoSize = true;
            lblTotalProdutos.Location = new Point(20, 120);

            txtTotalProdutos = new TextBox();
            txtTotalProdutos.Location = new Point(120, 120);
            txtTotalProdutos.Size = new Size(200, 18);
            txtTotalProdutos.ReadOnly = true;

            btnVoltar = new Button();
            btnVoltar.Text = "Voltar";
            btnVoltar.BackColor = Color.Snow;
            btnVoltar.Location = new Point(500, 10);
            btnVoltar.Click += new EventHandler(voltarButton_Click);

            buttonPanel.Controls.Add(btnConfirmar);
            buttonPanel.Controls.Add(btnVoltar);
            buttonPanel.Height = 50;
            buttonPanel.Dock = DockStyle.Bottom;

            this.Controls.Add(this.lblTotalSalarios);
            this.Controls.Add(this.txtTotalSalarios);
            this.Controls.Add(this.lblTotalProdutos);
            this.Controls.Add(this.txtTotalProdutos);
            this.Controls.Add(this.buttonPanel);

            this.buscarTotais();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buscarTotais()
        {
            double totalSalarios = ProjetoHotelSerranoSenac.Controllers.Funcionario.CalcularValorSalarioFuncionarios();
            double totalProdutos = ProjetoHotelSerranoSenac.Controllers.Produto.CalcularValorProdutos();

            this.txtTotalSalarios.Text = String.Concat("R$ ", totalSalarios.ToString());
            this.txtTotalProdutos.Text = String.Concat("R$ ", totalProdutos.ToString());
        }
    }
}