
using System.Linq;

namespace View
{
    public class Cliente : Form
    {

        Panel buttonPanel = new Panel();
        Label lblId;
        Label lblNome;
        Label lblEmail;
        Label lblTelefone;
        Label lblHotel;

        TextBox txtId;
        TextBox txtNome;
        TextBox txtEmail;
        TextBox txtTelefone;
        ComboBox comboboxHotel;

        Button btnConfirmar;
        Button btnVoltar;

        ProgressBar pbTest;

        List<ProjetoHotelSerranoSenac.Models.Hotel> listHotel = new List<ProjetoHotelSerranoSenac.Models.Hotel>();

        public Cliente(int? clienteId)
        {
            this.Text = "Cadastro de Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#748E83");

            this.Size = new Size(600, 600);

            lblId = new Label();
            lblId.Text = "Id:";
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 60);

            txtId = new TextBox();
            txtId.Location = new Point(80, 60);
            txtId.Size = new Size(200, 18);
            txtId.Enabled = false;

            lblNome = new Label();
            lblNome.Text = "Nome:";
            lblNome.AutoSize = true;
            lblNome.Location = new Point(20, 120);

            txtNome = new TextBox();
            txtNome.Location = new Point(80, 120);
            txtNome.Size = new Size(200, 18);

            lblEmail = new Label();
            lblEmail.Text = "Email:";
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 180);

            txtEmail = new TextBox();
            txtEmail.Location = new Point(80, 180);
            txtEmail.Size = new Size(200, 18);

            lblTelefone = new Label();
            lblTelefone.Text = "Telefone:";
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(20, 240);

            txtTelefone = new TextBox();
            txtTelefone.Location = new Point(80, 240);
            txtTelefone.Size = new Size(200, 18);

            lblHotel = new Label();
            lblHotel.Text = "Hotel:";
            lblHotel.AutoSize = true;
            lblHotel.Location = new Point(20, 300);

            comboboxHotel = new ComboBox();
            comboboxHotel.Location = new Point(80, 300);
            comboboxHotel.Size = new Size(200, 18);
            this.adicionarHoteisCombobox();

            btnConfirmar = new Button();
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.BackColor = Color.Snow;
            btnConfirmar.Location = new Point(420, 10);
            btnConfirmar.Click += new EventHandler(confirmarClienteButton_Click);

            btnVoltar = new Button();
            btnVoltar.Text = "Voltar";
            btnVoltar.BackColor = Color.Snow;
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
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.comboboxHotel);
            this.Controls.Add(this.buttonPanel);

            if (clienteId != null)
            {
                this.setarDadosClienteEdicao(clienteId);
            }
        }

        private void confirmarClienteButton_Click(object sender, EventArgs e)
        {
            try
            {
                ProjetoHotelSerranoSenac.Models.Hotel hotelSelecionado = this.buscarHotelSelecionadoCombobox();
                String nomeCliente = txtNome.Text;
                String emailCliente = txtEmail.Text;
                String telefoneCliente = txtTelefone.Text;

                if (this.txtId.Text != null && Int32.TryParse(this.txtId.Text, out int idCliente))
                {
                    ProjetoHotelSerranoSenac.Controllers.Cliente.AlterarCliente(this.txtId.Text, nomeCliente, emailCliente, telefoneCliente, hotelSelecionado.Id.ToString());
                    MessageBox.Show("Cliente atualizado com sucesso!");
                }
                else
                {
                    ProjetoHotelSerranoSenac.Controllers.Cliente.CadastrarCliente(nomeCliente, emailCliente, telefoneCliente, hotelSelecionado.Id.ToString());
                    MessageBox.Show("Cliente cadastrado com sucesso!");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void setarDadosClienteEdicao(int? clienteId)
        {
            ProjetoHotelSerranoSenac.Models.Cliente cliente = ProjetoHotelSerranoSenac.Controllers.Cliente.GetCliente(clienteId.ToString());
			ProjetoHotelSerranoSenac.Models.Hotel hotel = ProjetoHotelSerranoSenac.Controllers.Hotel.GetHotel(cliente.HotelId.ToString());
            this.txtId.Text = clienteId.ToString();
            this.txtNome.Text = cliente.Nome;
            this.txtEmail.Text = cliente.Email;
            this.txtTelefone.Text = cliente.Telefone;
            this.comboboxHotel.SelectedItem = hotel.Nome;
        }

    }
}