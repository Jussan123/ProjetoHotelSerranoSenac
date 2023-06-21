using ProjetoHotelSerranoSenac;

namespace View
{

    public class TelaPrincipal : Form
    {
        Label lblMenu;
        PictureBox pictureBox;
        Button btnProdutoExemplo;

        Button btnReservas;
        Button btnFuncionarios;
        Button btnCliente;
        Button btnQuarto;
        Button btnProduto;
        Button btnRelatorios;

        Button btnSair;
        Panel contentPanel;

        public TelaPrincipal()
        {
            this.Text = "Hotel Serrano";

            lblMenu = new Label();
            lblMenu.Text = "AQUI VAI A LOGO";
            lblMenu.Location = new Point(20, 20);
            lblMenu.Size = new Size(120, 30);
            
            pictureBox = new PictureBox();
            pictureBox.Location = new Point(300, 100);
            pictureBox.Size = new Size(400, 300);
            pictureBox.Image = Image.FromFile(@"Logo\Captura de tela de 2021-07-01 20-02-55.png");

            btnProdutoExemplo = new Button();
            btnProdutoExemplo.Text = "Btn Exemplo";
            btnProdutoExemplo.Size = new Size(100, 30);
            btnProdutoExemplo.Location = new Point(20, 60);
            btnProdutoExemplo.Click += new EventHandler(this.btnProdutoExemploClick);

            btnReservas = new Button();
            btnReservas.Text = "Reservas";
            btnReservas.Size = new Size(100, 30);
            btnReservas.Location = new Point(20, 100);
            btnReservas.Click += new EventHandler(this.btnReservasClick);

            btnFuncionarios = new Button();
            btnFuncionarios.Text = "Funcionários";
            btnFuncionarios.Size = new Size(100, 30);
            btnFuncionarios.Location = new Point(20, 140);
            btnFuncionarios.Click += new EventHandler(this.btnFuncionariosClick);

            btnCliente = new Button();
            btnCliente.Text = "Cliente";
            btnCliente.Size = new Size(100, 30);
            btnCliente.Location = new Point(20, 180);
            btnCliente.Click += new EventHandler(this.btnClienteClick);

            btnQuarto = new Button();
            btnQuarto.Text = "Quarto";
            btnQuarto.Size = new Size(100, 30);
            btnQuarto.Location = new Point(20, 220);
            btnQuarto.Click += new EventHandler(this.btnQuartoClick);

            btnProduto = new Button();
            btnProduto.Text = "Produto";
            btnProduto.Size = new Size(100, 30);
            btnProduto.Location = new Point(20, 260);
            btnProduto.Click += new EventHandler(this.btnProdutoClick);

            btnRelatorios = new Button();
            btnRelatorios.Text = "Relatórios";
            btnRelatorios.Size = new Size(100, 30);
            btnRelatorios.Location = new Point(20, 360);
            btnRelatorios.Click += new EventHandler(this.btnRelatoriosClick);

            btnSair = new Button();
            btnSair.Text = "Sair";
            btnSair.Size = new Size(100, 30);
            btnSair.Location = new Point(20, 460);
            btnSair.Click += new EventHandler(this.btnSairClick);

            contentPanel = new Panel();
            contentPanel.Size = new Size(600, 400);
            contentPanel.Location = new Point(160, 60);
            contentPanel.BorderStyle = BorderStyle.Fixed3D;

            this.Controls.Add(lblMenu);
            this.Controls.Add(pictureBox);
            this.Controls.Add(btnProdutoExemplo);
            this.Controls.Add(btnReservas);
            this.Controls.Add(btnFuncionarios);
            this.Controls.Add(btnCliente);
            this.Controls.Add(btnQuarto);
            this.Controls.Add(btnProduto);
            this.Controls.Add(btnRelatorios);
            this.Controls.Add(btnSair);
            this.Controls.Add(contentPanel);
            this.Size = new Size(800, 600);
            this.BackColor = Color.WhiteSmoke;
        }

        private void btnProdutoExemploClick(object sender, EventArgs e)
        {
            this.Controls.Remove(pictureBox);
            this.contentPanel.Controls.Clear();

            ListaProduto listaProdutoForm = new ListaProduto();
            listaProdutoForm.TopLevel = false;
            listaProdutoForm.AutoScroll = true;
            this.contentPanel.Controls.Add(listaProdutoForm);
            listaProdutoForm.Show();
        }

        private void btnReservasClick(object sender, EventArgs e)
        {
            this.Controls.Remove(pictureBox);
            this.contentPanel.Controls.Clear();

            // ListaReservas listaReservasForm = new ListaReservas();
            // listaReservasForm.TopLevel = false;
            // listaReservasForm.AutoScroll = true;
            // this.contentPanel.Controls.Add(listaReservasForm);
            // listaReservasForm.Show();
        }

        private void btnFuncionariosClick(object sender, EventArgs e)
        {
            this.Controls.Remove(pictureBox);
            this.contentPanel.Controls.Clear();

            ListaFuncionario listaFuncionariosForm = new ListaFuncionario();
            listaFuncionariosForm.TopLevel = false;
            listaFuncionariosForm.AutoScroll = true;
            this.contentPanel.Controls.Add(listaFuncionariosForm);
            listaFuncionariosForm.Show();
        }

        private void btnClienteClick(object sender, EventArgs e)
        {
            this.Controls.Remove(pictureBox);
            this.contentPanel.Controls.Clear();

            ListaCliente listaClienteForm = new ListaCliente();
            listaClienteForm.TopLevel = false;
            listaClienteForm.AutoScroll = true;
            this.contentPanel.Controls.Add(listaClienteForm);
            listaClienteForm.Show();
        }

        private void btnQuartoClick(object sender, EventArgs e)
        {
            this.Controls.Remove(pictureBox);
            this.contentPanel.Controls.Clear();

            // ListaQuarto listaQuartoForm = new ListaQuarto();
            // listaQuartoForm.TopLevel = false;
            // listaQuartoForm.AutoScroll = true;
            // this.contentPanel.Controls.Add(listaQuartoForm);
            // listaQuartoForm.Show();
        }

        private void btnProdutoClick(object sender, EventArgs e)
        {
            this.Controls.Remove(pictureBox);
            this.contentPanel.Controls.Clear();

            // ListaProduto listaProdutoForm = new ListaProduto();
            // listaProdutoForm.TopLevel = false;
            // listaProdutoForm.AutoScroll = true;
            // this.contentPanel.Controls.Add(listaProdutoForm);
            // listaProdutoForm.Show();
        }

        private void btnRelatoriosClick(object sender, EventArgs e)
        {
            this.Controls.Remove(pictureBox);
            this.contentPanel.Controls.Clear();

            TelaRelatorios telaRelatoriosForm = new TelaRelatorios();
            telaRelatoriosForm.TopLevel = false;
            telaRelatoriosForm.AutoScroll = true;
            this.contentPanel.Controls.Add(telaRelatoriosForm);
            telaRelatoriosForm.Show();
        }

        private void btnSairClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}