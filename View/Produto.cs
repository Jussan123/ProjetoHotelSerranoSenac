
namespace View
{    
	public class Produto : Form {

		Panel buttonPanel = new Panel();		

		Label lblId;
        Label lblNome;
        Label lblPreco;
        Label lblPrecoCompra;
        Label lblQuantidade;
        Label lblHotel;

        TextBox txtId;
        TextBox txtNome;
        TextBox txtPreco;
        TextBox txtPrecoCompra;
        TextBox txtQuantidade;
        ComboBox comboboxHotel;	

		Button btnConfirmar;
		Button btnVoltar;

 		List<ProjetoHotelSerranoSenac.Models.Hotel> listHotel = new List<ProjetoHotelSerranoSenac.Models.Hotel>();

        ProgressBar pbTest;

		public Produto(int? produtoId) {
			this.Text = "Cadastro de Produto";

            this.Size = new Size(600, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#748E83");

			
            lblId = new Label();
            lblId.Text = "Id:";
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 60);

            txtId = new TextBox();
            txtId.Location = new Point(140, 60);
            txtId.Size = new Size(200, 18);
            txtId.Enabled = false;

            lblNome = new Label();
            lblNome.Text = "Nome:";
            lblNome.AutoSize = true;
            lblNome.Location = new Point(20, 120);

            txtNome = new TextBox();
            txtNome.Location = new Point(140, 120);
            txtNome.Size = new Size(200, 18);

            lblPreco = new Label();
            lblPreco.Text = "Preco:";
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(20, 180);

            txtPreco = new TextBox();
            txtPreco.Location = new Point(140, 180);
            txtPreco.Size = new Size(200, 18);

            lblPrecoCompra = new Label();
            lblPrecoCompra.Text = "Preco de Compra:";
            lblPrecoCompra.AutoSize = true;
            lblPrecoCompra.Location = new Point(20, 240);

            txtPrecoCompra = new TextBox();
            txtPrecoCompra.Location = new Point(140, 240);
            txtPrecoCompra.Size = new Size(200, 18);

            lblQuantidade = new Label();
            lblQuantidade.Text = "Quantidade:";
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(20, 300);

            txtQuantidade = new TextBox();
            txtQuantidade.Location = new Point(140, 300);
            txtQuantidade.Size = new Size(200, 18);

            lblHotel = new Label();
            lblHotel.Text = "Hotel:";
            lblHotel.AutoSize = true;
            lblHotel.Location = new Point(20, 360);

            comboboxHotel = new ComboBox();
            comboboxHotel.Location = new Point(140, 360);
            comboboxHotel.Size = new Size(200, 18);
            this.adicionarHoteisCombobox();

            btnConfirmar = new Button();
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.Location = new Point(420, 10);
            btnConfirmar.Click += new EventHandler(confirmarProdutoButton_Click);

            btnVoltar = new Button();
            btnVoltar.Text = "Voltar";
            btnVoltar.Location = new Point(500, 10);
            btnVoltar.Click += new EventHandler(voltarButton_Click);

            buttonPanel.Controls.Add(btnConfirmar);
            buttonPanel.Controls.Add(btnVoltar);
            buttonPanel.Height = 50;
            buttonPanel.Dock = DockStyle.Bottom;

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPrecoCompra);
            this.Controls.Add(this.txtPrecoCompra);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.comboboxHotel);
            this.Controls.Add(this.buttonPanel);

			 if (produtoId != null)
            {
                this.setarDadosProdutoEdicao(produtoId);
            }
		}

		 private ProjetoHotelSerranoSenac.Models.Hotel buscarHotelSelecionadoCombobox()
        {
            ProjetoHotelSerranoSenac.Models.Hotel hotelSelecionado = new ProjetoHotelSerranoSenac.Models.Hotel();

            if (comboboxHotel.SelectedItem != null)
            {
                String nomeHotel = comboboxHotel.SelectedItem.ToString();

                hotelSelecionado = this.listHotel.Where(item => item.Nome.Equals(nomeHotel)).FirstOrDefault();
            }

            return hotelSelecionado;
        }

		private void confirmarProdutoButton_Click(object sender, EventArgs e) {
            try
            {
                ProjetoHotelSerranoSenac.Models.Hotel hotelSelecionado = this.buscarHotelSelecionadoCombobox();
                String nomeProduto = txtNome.Text;
                String precoProduto = txtPreco.Text;
                String quantidadeProduto = txtQuantidade.Text;
                String precoCompraProduto = txtPrecoCompra.Text;

                if (this.txtId.Text != null && Int32.TryParse(this.txtId.Text, out int idProduto))
                {
                    ProjetoHotelSerranoSenac.Controllers.Produto.AlterarProduto(this.txtId.Text, nomeProduto, precoProduto, quantidadeProduto, precoCompraProduto, hotelSelecionado.Id.ToString());
                    MessageBox.Show("Produto atualizado com sucesso!");
                } else {
                    ProjetoHotelSerranoSenac.Controllers.Produto.CadastrarProduto(nomeProduto, precoProduto, quantidadeProduto, precoCompraProduto, hotelSelecionado.Id.ToString());
                    MessageBox.Show("Produto cadastrado com sucesso!");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
		}
		private void adicionarHoteisCombobox()
        {
            comboboxHotel.Items.Clear();
            IEnumerable<ProjetoHotelSerranoSenac.Models.Hotel> collectionHotel = ProjetoHotelSerranoSenac.Controllers.Hotel.GetAllHoteis();

            if (collectionHotel != null && collectionHotel.Count() > 0)
            {
                this.listHotel.AddRange(collectionHotel.ToList());

                foreach (var hotel in collectionHotel)
                {
                    comboboxHotel.Items.Add(hotel.Nome);
                }

                comboboxHotel.SelectedIndex = 0;
            }
        }
		private void setarDadosProdutoEdicao(int? produtoId)
        {
            ProjetoHotelSerranoSenac.Models.Produto produto = ProjetoHotelSerranoSenac.Controllers.Produto.GetProduto(produtoId.ToString());
			ProjetoHotelSerranoSenac.Models.Hotel hotel = ProjetoHotelSerranoSenac.Controllers.Hotel.GetHotel(produto.HotelId.ToString());
            this.txtId.Text = produtoId.ToString();
            this.txtNome.Text = produto.Nome;
            this.txtPreco.Text = produto.Preco.ToString();
            this.txtPrecoCompra.Text = produto.PrecoCompra.ToString();
            this.txtQuantidade.Text = produto.Quantidade.ToString();
            this.comboboxHotel.SelectedItem = hotel.Nome;
        }

		private void voltarButton_Click(object sender, EventArgs e) {
			this.Close();
		}
        
    }
}