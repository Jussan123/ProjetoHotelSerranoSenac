
namespace View
{    
	public class Quarto : Form {

		Panel buttonPanel = new Panel();		

		Label lblId;
        Label lblNumeroQuarto;
        Label lblDescricao;
        Label lblDisponivel;
        Label lblValor;
        Label lblHotel;

        TextBox txtId;
        TextBox txtNumeroQuarto;
        TextBox txtDescricao;
        TextBox txtValor;
        ComboBox comboboxDisponivel;
        ComboBox comboboxHotel;	

		Button btnConfirmar;
		Button btnVoltar;

 		List<ProjetoHotelSerranoSenac.Models.Hotel> listHotel = new List<ProjetoHotelSerranoSenac.Models.Hotel>();

        ProgressBar pbTest;

		public Quarto(int? quartoId) {
			this.Text = "Cadastro de Quarto";

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

            lblNumeroQuarto = new Label();
            lblNumeroQuarto.Text = "Numero do Quarto:";
            lblNumeroQuarto.AutoSize = true;
            lblNumeroQuarto.Location = new Point(20, 120);

            txtNumeroQuarto = new TextBox();
            txtNumeroQuarto.Location = new Point(140, 120);
            txtNumeroQuarto.Size = new Size(200, 18);

            lblDescricao = new Label();
            lblDescricao.Text = "Descricao:";
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(20, 180);

            txtDescricao = new TextBox();
            txtDescricao.Location = new Point(140, 180);
            txtDescricao.Size = new Size(200, 18);

            lblDisponivel = new Label();
            lblDisponivel.Text = "Disponível:";
            lblDisponivel.AutoSize = true;
            lblDisponivel.Location = new Point(20, 240);

            comboboxDisponivel = new ComboBox();
            comboboxDisponivel.Location = new Point(140, 240);
            comboboxDisponivel.Size = new Size(200, 18);
            comboboxDisponivel.Items.Add("Sim");
            comboboxDisponivel.Items.Add("Não");
            comboboxDisponivel.SelectedIndex = 0;

            lblValor = new Label();
            lblValor.Text = "Valor:";
            lblValor.AutoSize = true;
            lblValor.Location = new Point(20, 300);

            txtValor = new TextBox();
            txtValor.Location = new Point(140, 300);
            txtValor.Size = new Size(200, 18);

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
            btnConfirmar.Click += new EventHandler(confirmarQuartoButton_Click);

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
            this.Controls.Add(this.lblNumeroQuarto);
            this.Controls.Add(this.txtNumeroQuarto);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDisponivel);
            this.Controls.Add(this.comboboxDisponivel);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.comboboxHotel);
            this.Controls.Add(this.buttonPanel);

			 if (quartoId != null)
            {
                this.setarDadosQuartoEdicao(quartoId);
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

		private void confirmarQuartoButton_Click(object sender, EventArgs e) {
            try
            {
                ProjetoHotelSerranoSenac.Models.Hotel hotelSelecionado = this.buscarHotelSelecionadoCombobox();
                String disponivelText = comboboxDisponivel.SelectedItem.ToString();
                String nomeQuarto = txtNumeroQuarto.Text;
                String descricaoQuarto = txtDescricao.Text;
                String precoQuarto = txtValor.Text;

                if (this.txtId.Text != null && Int32.TryParse(this.txtId.Text, out int idQuarto))
                {
                    ProjetoHotelSerranoSenac.Controllers.Quarto.AlterarQuarto(this.txtId.Text, nomeQuarto, descricaoQuarto, precoQuarto, disponivelText, hotelSelecionado.Id.ToString());
                    MessageBox.Show("Quarto atualizado com sucesso!");
                } else {
                    ProjetoHotelSerranoSenac.Controllers.Quarto.CadastrarQuarto(nomeQuarto, descricaoQuarto, precoQuarto, disponivelText, hotelSelecionado.Id.ToString());
                    MessageBox.Show("Quarto cadastrado com sucesso!");
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
		private void setarDadosQuartoEdicao(int? quartoId)
        {
            ProjetoHotelSerranoSenac.Models.Quarto quarto = ProjetoHotelSerranoSenac.Controllers.Quarto.GetQuarto(quartoId.ToString());
			ProjetoHotelSerranoSenac.Models.Hotel hotel = ProjetoHotelSerranoSenac.Controllers.Hotel.GetHotel(quarto.HotelId.ToString());
            this.txtId.Text = quartoId.ToString();
            this.txtNumeroQuarto.Text = quarto.NumeroQuarto.ToString();
            this.txtDescricao.Text = quarto.Descricao.ToString();
            this.comboboxDisponivel.Text =quarto.booleanToString();
            this.txtValor.Text = quarto.Valor.ToString();
            this.comboboxHotel.SelectedItem = hotel.Nome;
        }

		private void voltarButton_Click(object sender, EventArgs e) {
			this.Close();
		}
        
    }
}