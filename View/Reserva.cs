


using ProjetoHotelSerranoSenac.Controllers;

namespace ProjetoHotelSerranoSenac
{
    public class Reserva : Form
    {
        public Reserva(int? reservaId)
        {
            InitializeComponent();
        }

        List<ProjetoHotelSerranoSenac.Models.Cliente> listCliente = new List<ProjetoHotelSerranoSenac.Models.Cliente>();
        List<ProjetoHotelSerranoSenac.Models.Quarto> listQuarto = new List<ProjetoHotelSerranoSenac.Models.Quarto>();
        List<ProjetoHotelSerranoSenac.Models.Hotel> listHotel = new List<ProjetoHotelSerranoSenac.Models.Hotel>();
        Label lblHotel;
        ComboBox comboboxHotel;
        private void InitializeComponent()
        {
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxQuarto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtCheckIn = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtCheckOut = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Valor = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.AllowDrop = true;
            this.comboBoxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(22, 45);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(217, 21);
            this.comboBoxCliente.TabIndex = 0;
            this.adicionarClientesCombobox();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            // 
            // comboBox1
            // 
            this.comboBoxQuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuarto.FormattingEnabled = true;
            this.comboBoxQuarto.Location = new System.Drawing.Point(261, 45);
            this.comboBoxQuarto.Name = "Quartos";
            this.comboBoxQuarto.Size = new System.Drawing.Size(217, 21);
            this.comboBoxQuarto.TabIndex = 2;
            this.adicionarQuartosCombobox();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quartos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtCheckIn
            // 
            this.dtCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckIn.Location = new System.Drawing.Point(26, 140);
            this.dtCheckIn.Mask = "00/00/0000";
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.Size = new System.Drawing.Size(166, 23);
            this.dtCheckIn.TabIndex = 4;
            this.dtCheckIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtCheckIn.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data do Check-in";
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckOut.Location = new System.Drawing.Point(261, 140);
            this.dtCheckOut.Mask = "00/00/0000";
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(166, 23);
            this.dtCheckOut.TabIndex = 6;
            this.dtCheckOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtCheckOut.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data do Check-out";
            // 
            // Valor
            // 
            this.Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor.Location = new System.Drawing.Point(29, 230);
            this.Valor.Mask = "$";
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(120, 23);
            this.Valor.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor";

            lblHotel = new Label();
            lblHotel.Text = "Hotel:";
            lblHotel.AutoSize = true;
            lblHotel.Location = new Point(20, 300);

            comboboxHotel = new ComboBox();
            comboboxHotel.Location = new Point(80, 300);
            comboboxHotel.Size = new Size(200, 18);
            this.adicionarHoteisCombobox();

            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(305, 304);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 30);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new EventHandler(confirmarClienteButton_Click);
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(403, 304);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 30);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // CadastroReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 360);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtCheckOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtCheckIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxQuarto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.comboboxHotel);            
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroReserva";
            this.Load += new System.EventHandler(this.CadastroReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxQuarto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox dtCheckIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox dtCheckOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Valor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CadastroReserva_Load(object sender, EventArgs e)
        {

        }

        private void confirmarClienteButton_Click(object sender, EventArgs e)
        {
            try
            {

                ProjetoHotelSerranoSenac.Models.Cliente clienteSelecionado = this.buscarClienteSelecionadoCombobox();
                ProjetoHotelSerranoSenac.Models.Quarto quartoSelecionado = this.buscarQuartoSelecionadoCombobox();
                ProjetoHotelSerranoSenac.Models.Hotel hotelSelecionado = this.buscarHotelSelecionadoCombobox();                                
                String dataCheckin = dtCheckIn.Text;
                String dataCheckout = dtCheckOut.Text;
                String telefoneCliente = Valor.Text;

                // if (this.txtId.Text != null && Int32.TryParse(this.txtId.Text, out int idCliente))
                // {
                //     ProjetoHotelSerranoSenac.Controllers.Reserva.AlterarCliente(this.txtId.Text, nomeCliente, emailCliente, telefoneCliente, hotelSelecionado.Id.ToString());
                //     MessageBox.Show("Reserva atualizada com sucesso!");
                // }
                // else
                // {
                    ProjetoHotelSerranoSenac.Controllers.Reserva.CadastrarReserva(clienteSelecionado.Id.ToString(), quartoSelecionado.Id.ToString(), dtCheckIn.Text, dtCheckOut.Text, hotelSelecionado.Id.ToString());
                    MessageBox.Show("Reserva cadastrada com sucesso!");
                // }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }        

        private void adicionarClientesCombobox()
        {
            comboBoxCliente.Items.Clear();
            IEnumerable<ProjetoHotelSerranoSenac.Models.Cliente> collectionCliente = ProjetoHotelSerranoSenac.Controllers.Cliente.GetAllClientes();

            if (collectionCliente != null && collectionCliente.Count() > 0)
            {
                this.listCliente.AddRange(collectionCliente.ToList());

                foreach (var cliente in collectionCliente)
                {
                    comboBoxCliente.Items.Add(cliente.Nome);
                }

                comboBoxCliente.SelectedIndex = 0;
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
        
        private ProjetoHotelSerranoSenac.Models.Cliente buscarClienteSelecionadoCombobox()
        {
            ProjetoHotelSerranoSenac.Models.Cliente clienteSelecionado = new ProjetoHotelSerranoSenac.Models.Cliente();

            if (comboBoxCliente.SelectedItem != null)
            {
                String nomeCliente = comboBoxCliente.SelectedItem.ToString();

                clienteSelecionado = this.listCliente.Where(item => item.Nome.Equals(nomeCliente)).FirstOrDefault();
            }

            return clienteSelecionado;
        }

        private ProjetoHotelSerranoSenac.Models.Quarto buscarQuartoSelecionadoCombobox()
        {
            ProjetoHotelSerranoSenac.Models.Quarto quartoSelecionado = new ProjetoHotelSerranoSenac.Models.Quarto();

            if (comboBoxQuarto.SelectedItem != null)
            {
                String nomeQuarto = comboBoxQuarto.SelectedItem.ToString();

                quartoSelecionado = this.listQuarto.Where(item => item.Descricao.Equals(nomeQuarto)).FirstOrDefault();
            }

            return quartoSelecionado;
        }                

        private void adicionarQuartosCombobox()
        {
            comboBoxQuarto.Items.Clear();
            IEnumerable<ProjetoHotelSerranoSenac.Models.Quarto> collectionQuarto = ProjetoHotelSerranoSenac.Controllers.Quarto.GetAllQuartos();

            if (collectionQuarto != null && collectionQuarto.Count() > 0)
            {
                this.listQuarto.AddRange(collectionQuarto.ToList());

                foreach (var quarto in collectionQuarto)
                {
                    comboBoxQuarto.Items.Add(quarto.Descricao);
                }

                comboBoxQuarto.SelectedIndex = 0;
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


    }
}