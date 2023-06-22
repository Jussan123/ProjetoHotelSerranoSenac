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

            reservaGridView.ColumnCount = 3;

            reservaGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            reservaGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            reservaGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(reservaGridView.Font, FontStyle.Bold);

            reservaGridView.Name = "reservaGridView";
            reservaGridView.Location = new Point(8, 8);
            reservaGridView.Size = new Size(600, 400);
            reservaGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            reservaGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            reservaGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            reservaGridView.GridColor = Color.Black;
            reservaGridView.RowHeadersVisible = false;

            reservaGridView.Columns[0].Name = "Id";
            reservaGridView.Columns[1].Name = "Nome";
            reservaGridView.Columns[2].Name = "Preço";
            reservaGridView.Columns[2].DefaultCellStyle.Font =
                new Font(reservaGridView.DefaultCellStyle.Font, FontStyle.Italic);

            reservaGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reservaGridView.MultiSelect = false;
            reservaGridView.Dock = DockStyle.Fill;

            reservaGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(reservaGridView_CellFormatting);
        }

        private void PopulateDataGridView()
        {

            string[] row0 = { "1", "Carro", "10" };
            string[] row1 = { "2", "Bicicleta", "20" };
            string[] row2 = { "3", "Moto", "30" };

            reservaGridView.Rows.Add(row0);
            reservaGridView.Rows.Add(row1);
            reservaGridView.Rows.Add(row2);
        }

        private void adicionarReservaButton_Click(object sender, EventArgs e)
        {
            Reserva telaReserva = new Reserva();
            telaReserva.ShowDialog();
        }

        private void atualizarReservaButton_Click(object sender, EventArgs e)
        {
            //aqui na atualização/edição vai pegar o id da linha selecionada e passar por parâmetro o idSelecionado
            // Produto telaProduto = new Produto(idSelecionado);
            // telaProduto.ShowDialog();
            this.reservaGridView.Rows.Add();
        }

        private void deletarReservaButton_Click(object sender, EventArgs e)
        {
            if (this.reservaGridView.SelectedRows.Count > 0 &&
                this.reservaGridView.SelectedRows[0].Index !=
                this.reservaGridView.Rows.Count - 1)
            {
                var confirmResult = MessageBox.Show("Tem certeza que deseja excluir o item?", "Exclusão de Item", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    MessageBox.Show(this.reservaGridView.SelectedRows[0].Index.ToString());
                    this.reservaGridView.Refresh();
                }
                else
                {
                    MessageBox.Show("Operação cancelada");
                }

            }
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}