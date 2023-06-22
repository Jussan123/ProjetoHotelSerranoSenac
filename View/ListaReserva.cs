using System;
using System.Drawing;
using System.Windows.Forms;
using ProjetoHotelSerranoSenac;

namespace View
{
    public class ListaReserva : Form
    {
        private Panel buttonPanel = new Panel();
        private DataGridView reservaGridView = new DataGridView();
        private Button adicionarReservaButton = new Button();
        private Button atualizarReservaButton = new Button();
        private Button deletarReservaButton = new Button();
        private Button voltarButton = new Button();

        public ListaReserva()
        {
            this.Text = "Listagem de Reserva";
            this.Load += new EventHandler(listaReserva_Load);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#748E83");
        }

        private void listaReserva_Load(System.Object sender, System.EventArgs e)
        {
            SetupLayout();
            SetupDataGridView();
            PopulateDataGridView();
        }

        private void reservaGridView_CellFormatting(object sender,
            System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (e != null)
            {
                if (this.reservaGridView.Columns[e.ColumnIndex].Name == "Release Date")
                {
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = DateTime.Parse(e.Value.ToString())
                                .ToLongDateString();
                            e.FormattingApplied = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("{0} is not a valid date.", e.Value.ToString());
                        }
                    }
                }
            }
        }

        private void SetupLayout()
        {
            adicionarReservaButton.Text = "Novo";
            adicionarReservaButton.Location = new Point(270, 10);
            adicionarReservaButton.Click += new EventHandler(adicionarReservaButton_Click);

            atualizarReservaButton.Text = "Editar";
            atualizarReservaButton.Location = new Point(350, 10);
            atualizarReservaButton.Click += new EventHandler(atualizarReservaButton_Click);

            deletarReservaButton.Text = "Excluir";
            deletarReservaButton.Location = new Point(430, 10);
            deletarReservaButton.Click += new EventHandler(deletarReservaButton_Click);

            voltarButton.Text = "Voltar";
            voltarButton.Location = new Point(510, 10);
            voltarButton.Click += new EventHandler(voltarButton_Click);

            buttonPanel.Controls.Add(adicionarReservaButton);
            buttonPanel.Controls.Add(atualizarReservaButton);
            buttonPanel.Controls.Add(deletarReservaButton);
            buttonPanel.Controls.Add(voltarButton);
            buttonPanel.Height = 50;
            buttonPanel.Dock = DockStyle.Bottom;

            this.BackColor = Color.AliceBlue;
            this.Size = new Size(600, 400);
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(this.buttonPanel);
        }

        private void SetupDataGridView()
        {
            this.Controls.Add(reservaGridView);

            reservaGridView.ColumnCount = 7;

            reservaGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            reservaGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            reservaGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(reservaGridView.Font, FontStyle.Bold);

            reservaGridView.Name = "reservaGridView";
            reservaGridView.Location = new Point(8, 8);
            reservaGridView.Size = new Size(650, 400);
            reservaGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            reservaGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            reservaGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            reservaGridView.GridColor = Color.Black;
            reservaGridView.RowHeadersVisible = false;

            reservaGridView.Columns[0].Name = "Id";
            reservaGridView.Columns[1].Name = "Cliente";
            reservaGridView.Columns[2].Name = "Quarto";
            reservaGridView.Columns[3].Name = "Data Checkin";
            reservaGridView.Columns[4].Name = "Data Checkout";
            reservaGridView.Columns[5].Name = "Preço";
            reservaGridView.Columns[6].Name = "Hotel";

            reservaGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reservaGridView.MultiSelect = false;
            reservaGridView.Dock = DockStyle.Fill;

            reservaGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(reservaGridView_CellFormatting);
        }

        private void PopulateDataGridView()
        {
            reservaGridView.Rows.Clear();

            IEnumerable<ProjetoHotelSerranoSenac.Models.Reserva> collectionReservas = ProjetoHotelSerranoSenac.Controllers.Reserva.GetAllReservas();

            if (collectionReservas != null && collectionReservas.Count() > 0)
            {
                foreach (var item in collectionReservas)
                {
                    ProjetoHotelSerranoSenac.Models.Cliente clienteReserva = ProjetoHotelSerranoSenac.Controllers.Cliente.GetCliente(item.ClienteId.ToString());
                    ProjetoHotelSerranoSenac.Models.Quarto quartoReserva = ProjetoHotelSerranoSenac.Controllers.Quarto.GetQuarto(item.QuartoId.ToString());
                    ProjetoHotelSerranoSenac.Models.Hotel hotelReserva = ProjetoHotelSerranoSenac.Controllers.Hotel.GetHotel(item.HotelId.ToString());

                    String quartoNroDescricao = String.Concat(quartoReserva.NumeroQuarto, " - ", quartoReserva.Descricao);
                    string[] linhaReserva = { item.Id.ToString(), clienteReserva.Nome, quartoNroDescricao, item.DataCheckin.ToString(), item.DataCheckout.ToString(), item.Preco.ToString(), hotelReserva.Nome};

                    reservaGridView.Rows.Add(linhaReserva);
                }
            }
        }

        private void adicionarReservaButton_Click(object sender, EventArgs e)
        {
            Reserva telaReserva = new Reserva(null);
            telaReserva.FormClosed += new FormClosedEventHandler(recarregarDadosGrid);            
            telaReserva.ShowDialog();
        }

        private void atualizarReservaButton_Click(object sender, EventArgs e)
        {
            if (this.reservaGridView.SelectedRows.Count > 0 &&
                this.reservaGridView.SelectedRows[0].Index !=
                this.reservaGridView.Rows.Count - 1)
            {
                string idReservaSelecionado = reservaGridView.Rows[this.reservaGridView.SelectedRows[0].Index].Cells[0].Value.ToString();
                Reserva telaReserva = new Reserva(Int32.Parse(idReservaSelecionado));
                telaReserva.FormClosed += new FormClosedEventHandler(recarregarDadosGrid);
                telaReserva.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhuma reserva foi selecionado!");
            }
        }

        private void deletarReservaButton_Click(object sender, EventArgs e)
        {
            if (this.reservaGridView.SelectedRows.Count > 0 &&
                this.reservaGridView.SelectedRows[0].Index !=
                this.reservaGridView.Rows.Count - 1)
            {
                var confirmResult = MessageBox.Show("Tem certeza que deseja excluir o Reserva?", "Exclusão de Reserva", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    string idReserva = reservaGridView.Rows[this.reservaGridView.SelectedRows[0].Index].Cells[0].Value.ToString();
                    ProjetoHotelSerranoSenac.Controllers.Reserva.ExcluirReserva(idReserva);
                    MessageBox.Show("Reserva excluída com sucesso!");
                    PopulateDataGridView();
                    this.reservaGridView.Refresh();
                }
                else
                {
                    MessageBox.Show("Operação cancelada");
                }
            }
            else
            {
                MessageBox.Show("Nenhum reserva foi selecionado!");
            }
        }

        private void recarregarDadosGrid(object sender, FormClosedEventArgs e)
        {
            PopulateDataGridView();
            this.reservaGridView.Refresh();
        }        

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}