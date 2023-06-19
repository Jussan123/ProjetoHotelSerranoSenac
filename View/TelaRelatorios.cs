
using ProjetoHotelSerranoSenac;

namespace View
{

    public class TelaRelatorios : Form
    {
        Button btnRelatorioDespesas;
        Button btnRelatorioReservas;
        Button btnRelatorioProdutos;
        Button btnRelatorioHospedes;
        Button btnRelatorioLimpeza;
        Button btnRelatorioFuncionarios;
        public TelaRelatorios()
        {
            this.Text = "Hotel Serrano";

            btnRelatorioDespesas = new Button();
            btnRelatorioDespesas.Text = "Despesas";
            btnRelatorioDespesas.Size = new Size(100, 30);
            btnRelatorioDespesas.Location = new Point(120, 100);
            btnRelatorioDespesas.Click += new EventHandler(this.btnRelatorioDespesasClick);

            btnRelatorioReservas = new Button();
            btnRelatorioReservas.Text = "Reservas";
            btnRelatorioReservas.Size = new Size(100, 30);
            btnRelatorioReservas.Location = new Point(220, 100);
            btnRelatorioReservas.Click += new EventHandler(this.btnRelatorioReservasClick);

            btnRelatorioProdutos = new Button();
            btnRelatorioProdutos.Text = "Produtos";
            btnRelatorioProdutos.Size = new Size(100, 30);
            btnRelatorioProdutos.Location = new Point(320, 100);
            btnRelatorioProdutos.Click += new EventHandler(this.btnRelatorioProdutosClick);

            btnRelatorioHospedes = new Button();
            btnRelatorioHospedes.Text = "Hóspedes";
            btnRelatorioHospedes.Size = new Size(100, 30);
            btnRelatorioHospedes.Location = new Point(420, 100);
            btnRelatorioHospedes.Click += new EventHandler(this.btnRelatorioHospedesClick);

            btnRelatorioLimpeza = new Button();
            btnRelatorioLimpeza.Text = "Limpeza";
            btnRelatorioLimpeza.Size = new Size(100, 30);
            btnRelatorioLimpeza.Location = new Point(220, 200);
            btnRelatorioLimpeza.Click += new EventHandler(this.btnRelatorioLimpezaClick);

            btnRelatorioFuncionarios = new Button();
            btnRelatorioFuncionarios.Text = "Funcionários";
            btnRelatorioFuncionarios.Size = new Size(100, 30);
            btnRelatorioFuncionarios.Location = new Point(320, 200);
            btnRelatorioFuncionarios.Click += new EventHandler(this.btnRelatorioFuncionariosClick);

            this.Controls.Add(btnRelatorioDespesas);
            this.Controls.Add(btnRelatorioReservas);
            this.Controls.Add(btnRelatorioProdutos);
            this.Controls.Add(btnRelatorioHospedes);
            this.Controls.Add(btnRelatorioLimpeza);
            this.Controls.Add(btnRelatorioFuncionarios);
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(600, 400);
            this.BackColor = Color.AliceBlue;
        }

        private void btnRelatorioDespesasClick(object sender, EventArgs e)
        {
            //Aqui vai chamar a classe para gerar o relatório de Despesas
        }

        private void btnRelatorioReservasClick(object sender, EventArgs e)
        {
            //Aqui vai chamar a classe para gerar o relatório de Reservas
        }

        private void btnRelatorioProdutosClick(object sender, EventArgs e)
        {
            //Aqui vai chamar a classe para gerar o relatório de Produtos
        }

        private void btnRelatorioHospedesClick(object sender, EventArgs e)
        {
            //Aqui vai chamar a classe para gerar o relatório de Quarto
        }

        private void btnRelatorioLimpezaClick(object sender, EventArgs e)
        {
            //Aqui vai chamar a classe para gerar o relatório de Limpeza
        }

        private void btnRelatorioFuncionariosClick(object sender, EventArgs e)
        {
            //Aqui vai chamar a classe para gerar o relatório de Funcionarios
        }
    }
}