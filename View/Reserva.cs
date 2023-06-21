
using System.Linq;
using System;
using ProjetoHotelSerranoSenac.Controllers;


namespace View
{
    public class Reserva : Form
    {

        Panel buttonPanel = new Panel();
        Label lblId;
        Label lblDataCheckIn;
        Label lblDataCheckout;
        Label lblComboboxCliente;
        Label lblComboboxQuarto;
        Label lblComboboxHotel;
        Label lblPreco;

        TextBox txtId;
        TextBox txtDataCheckIn;
        TextBox txtDataCheckOut;
        TextBox txtPreco;
        ComboBox comboboxHotel;
        ComboBox comboboxCliente;
        ComboBox comboboxQuarto;

        Button btnConfirmar;
        Button btnVoltar;

        ProgressBar pbTest;

        List<ProjetoHotelSerranoSenac.Models.Cliente> listCliente = new List<ProjetoHotelSerranoSenac.Models.Cliente>();
        List<ProjetoHotelSerranoSenac.Models.Quarto> listQuarto = new List<ProjetoHotelSerranoSenac.Models.Quarto>();
        List<ProjetoHotelSerranoSenac.Models.Hotel> listHotel = new List<ProjetoHotelSerranoSenac.Models.Hotel>();

        public Reserva(int? reservaId)
        {
            this.Text = "Cadastro de Reserva";
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

            lblComboboxCliente = new Label();
            lblComboboxCliente.Text = "Cliente:";
            lblComboboxCliente.AutoSize = true;
            lblComboboxCliente.Location = new Point(20, 120);

            comboboxCliente = new ComboBox();
            comboboxCliente.Location = new Point(80, 120);
            comboboxCliente.Size = new Size(200, 18);
            this.adicionarClientesCombobox();

            lblComboboxQuarto = new Label();
            lblComboboxQuarto.Text = "Quarto:";
            lblComboboxQuarto.AutoSize = true;
            lblComboboxQuarto.Location = new Point(20, 180);

            comboboxQuarto = new ComboBox();
            comboboxQuarto.Location = new Point(80, 180);
            comboboxQuarto.Size = new Size(200, 18);
            this.adicionarQuartosCombobox();


            lblComboboxHotel = new Label();
            lblComboboxHotel.Text = "Hotel:";
            lblComboboxHotel.AutoSize = true;
            lblComboboxHotel.Location = new Point(20, 240);

            comboboxHotel = new ComboBox();
            comboboxHotel.Location = new Point(80, 240);
            comboboxHotel.Size = new Size(200, 18);
            this.adicionarHoteisCombobox();

            lblDataCheckIn = new Label();
            lblDataCheckIn.Text = "Data Check-In:";
            lblDataCheckIn.AutoSize = true;
            lblDataCheckIn.Location = new Point(20, 300);

            txtDataCheckIn = new TextBox();
            //txtDataCheckIn.Mask = "00/00/0000";
            txtDataCheckIn.TextAlign = HorizontalAlignment.Center;
            txtDataCheckIn.Location = new Point(125, 300);
            txtDataCheckIn.Size = new Size(150, 18);

            lblDataCheckout = new Label();
            lblDataCheckout.Text = "Data Check-out:";
            lblDataCheckout.AutoSize = true;
            lblDataCheckout.Location = new Point(20, 360);

            txtDataCheckOut = new TextBox();
            //txtDataCheckOut.Mask = "00/00/0000";
            txtDataCheckOut.TextAlign = HorizontalAlignment.Center;
            txtDataCheckOut.Location = new Point(125, 360);
            txtDataCheckOut.Size = new Size(150, 18);


            lblPreco = new Label();
            lblPreco.Text = "Valor:";
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(20, 420);

            txtPreco = new TextBox();
            txtPreco.Location = new Point(80, 420);
            txtPreco.Size = new Size(200, 18);
            txtPreco.Enabled = true;



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
            this.Controls.Add(this.lblComboboxCliente);
            this.Controls.Add(this.comboboxCliente);
            this.Controls.Add(this.lblComboboxQuarto);
            this.Controls.Add(this.comboboxQuarto);
            this.Controls.Add(this.lblComboboxHotel);
            this.Controls.Add(this.comboboxHotel);
            this.Controls.Add(this.lblDataCheckIn);
            this.Controls.Add(this.txtDataCheckIn);
            this.Controls.Add(this.lblDataCheckout);
            this.Controls.Add(this.txtDataCheckOut);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.buttonPanel);


            if (reservaId != null)
            {
                this.setarDadoReservaEdicao(reservaId);
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

        private void confirmarClienteButton_Click(object sender, EventArgs e)
        {
            try
            {

                ProjetoHotelSerranoSenac.Models.Cliente clienteSelecionado = this.buscarClienteSelecionadoCombobox();
                ProjetoHotelSerranoSenac.Models.Quarto quartoSelecionado = this.buscarQuartoSelecionadoCombobox();
                ProjetoHotelSerranoSenac.Models.Hotel hotelSelecionado = this.buscarHotelSelecionadoCombobox();


                if (this.txtId.Text != null && Int32.TryParse(this.txtId.Text, out int idCliente))
                {
                    // ProjetoHotelSerranoSenac.Controllers.Reserva.AlterarReserva(this.txtId.Text, hotelSelecionado.Id.ToString());
                    MessageBox.Show("Reserva atualizada com sucesso!");
                }
                else
                {
                    ProjetoHotelSerranoSenac.Controllers.Reserva.CadastrarReserva(clienteSelecionado.Id.ToString(), quartoSelecionado.Id.ToString(), txtDataCheckIn.Text, txtDataCheckOut.Text, hotelSelecionado.Id.ToString(), txtPreco.Text);
                    MessageBox.Show("Reserva cadastrada com sucesso!");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void adicionarClientesCombobox()
        {
            comboboxCliente.Items.Clear();
            IEnumerable<ProjetoHotelSerranoSenac.Models.Cliente> collectionCliente = ProjetoHotelSerranoSenac.Controllers.Cliente.GetAllClientes();

            if (collectionCliente != null && collectionCliente.Count() > 0)
            {
                this.listCliente.AddRange(collectionCliente.ToList());

                foreach (var cliente in collectionCliente)
                {
                    comboboxCliente.Items.Add(cliente.Nome);
                }

                comboboxCliente.SelectedIndex = 0;
            }
        }

        private ProjetoHotelSerranoSenac.Models.Cliente buscarClienteSelecionadoCombobox()
        {
            ProjetoHotelSerranoSenac.Models.Cliente clienteSelecionado = new ProjetoHotelSerranoSenac.Models.Cliente();

            if (comboboxCliente.SelectedItem != null)
            {
                String nomeCliente = comboboxCliente.SelectedItem.ToString();

                clienteSelecionado = this.listCliente.Where(item => item.Nome.Equals(nomeCliente)).FirstOrDefault();
            }

            return clienteSelecionado;
        }

        private ProjetoHotelSerranoSenac.Models.Quarto buscarQuartoSelecionadoCombobox()
        {
            ProjetoHotelSerranoSenac.Models.Quarto quartoSelecionado = new ProjetoHotelSerranoSenac.Models.Quarto();

            if (comboboxQuarto.SelectedItem != null)
            {
                String nomeQuarto = comboboxQuarto.SelectedItem.ToString();

                quartoSelecionado = this.listQuarto.Where(item => item.Descricao.Equals(nomeQuarto)).FirstOrDefault();
            }

            return quartoSelecionado;
        }

        private void adicionarQuartosCombobox()
        {
            comboboxQuarto.Items.Clear();
            IEnumerable<ProjetoHotelSerranoSenac.Models.Quarto> collectionQuarto = ProjetoHotelSerranoSenac.Controllers.Quarto.GetAllQuartos();

            if (collectionQuarto != null && collectionQuarto.Count() > 0)
            {
                this.listQuarto.AddRange(collectionQuarto.ToList());

                foreach (var quarto in collectionQuarto)
                {
                    comboboxQuarto.Items.Add(quarto.Descricao);
                }

                comboboxQuarto.SelectedIndex = 0;
            }
        }

        private void setarDadoReservaEdicao(int? reservaId)
        {
            ProjetoHotelSerranoSenac.Models.Cliente cliente = ProjetoHotelSerranoSenac.Controllers.Cliente.GetCliente(buscarClienteSelecionadoCombobox().ToString());
            ProjetoHotelSerranoSenac.Models.Reserva reserva = ProjetoHotelSerranoSenac.Controllers.Reserva.GetReserva(reservaId.ToString());
            ProjetoHotelSerranoSenac.Models.Hotel hotel = ProjetoHotelSerranoSenac.Controllers.Hotel.GetHotel(cliente.HotelId.ToString());
            ProjetoHotelSerranoSenac.Models.Quarto quarto = ProjetoHotelSerranoSenac.Controllers.Quarto.GetQuarto(buscarQuartoSelecionadoCombobox().ToString());

            this.txtId.Text = reservaId.ToString();
            this.txtDataCheckIn.Text = reserva.DataCheckin.ToString();
            this.txtDataCheckIn.Text = reserva.DataCheckout.ToString();
            this.comboboxCliente.SelectedItem = cliente.Nome;
            this.comboboxQuarto.SelectedItem = quarto.Descricao;
            this.comboboxHotel.SelectedItem = hotel.Nome;
        }


    }
}