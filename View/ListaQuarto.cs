using System;
using System.Drawing;
using System.Windows.Forms;
using ProjetoHotelSerranoSenac;
using View;

namespace View 
{
    public class ListaQuarto : Form
    {
        private Panel buttonPanel = new Panel();
        private DataGridView quartoGridView = new DataGridView();
        private Button adicionarQuartoButton = new Button();
        private Button atualizarQuartoButton = new Button();
        private Button deletarQuartoButton = new Button();
        private Button voltarButton = new Button();

        public ListaQuarto()
        {
            this.Text = "Listagem de Quarto";
            this.Load += new EventHandler(ListaQuarto_Load);
        }

        private void ListaQuarto_Load(System.Object sender, System.EventArgs e)
        {
            SetupLayout();
            SetupDataGridView();
            PopulateDataGridView();
        }

        private void quartoGridView_CellFormatting(object sender,
            System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (e != null)
            {
                if (this.quartoGridView.Columns[e.ColumnIndex].Name == "Release Date")
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
            adicionarQuartoButton.Text = "Novo";
            adicionarQuartoButton.Location = new Point(270, 10);
            adicionarQuartoButton.Click += new EventHandler(adicionarQuartoButton_Click);

            atualizarQuartoButton.Text = "Editar";
            atualizarQuartoButton.Location = new Point(350, 10);
            atualizarQuartoButton.Click += new EventHandler(atualizarQuartoButton_Click);

            deletarQuartoButton.Text = "Excluir";
            deletarQuartoButton.Location = new Point(430, 10);
            deletarQuartoButton.Click += new EventHandler(deletarQuartoButton_Click);

            voltarButton.Text = "Voltar";
            voltarButton.Location = new Point(510, 10);
            voltarButton.Click += new EventHandler(voltarButton_Click);

            buttonPanel.Controls.Add(adicionarQuartoButton);
            buttonPanel.Controls.Add(atualizarQuartoButton);
            buttonPanel.Controls.Add(deletarQuartoButton);
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
            this.Controls.Add(quartoGridView);

            quartoGridView.ColumnCount = 6;

            quartoGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            quartoGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            quartoGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(quartoGridView.Font, FontStyle.Bold);

            quartoGridView.Name = "quartoGridView";
            quartoGridView.Location = new Point(8, 8);
            quartoGridView.Size = new Size(600, 400);
            quartoGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            quartoGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            quartoGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            quartoGridView.GridColor = Color.Black;
            quartoGridView.RowHeadersVisible = false;

            quartoGridView.Columns[0].Name = "Id";
            quartoGridView.Columns[1].Name = "Número do Quarto";
            quartoGridView.Columns[2].Name = "Descrição";
            quartoGridView.Columns[3].Name = "Disponível";
            quartoGridView.Columns[4].Name = "Valor";
            quartoGridView.Columns[5].Name = "Hotel";
           
            quartoGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            quartoGridView.MultiSelect = false;
            quartoGridView.Dock = DockStyle.Fill;

            quartoGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(quartoGridView_CellFormatting);
        }

        private void PopulateDataGridView()
        {


            quartoGridView.Rows.Clear();

            IEnumerable<ProjetoHotelSerranoSenac.Models.Quarto> collectionClientes = ProjetoHotelSerranoSenac.Controllers.Quarto.GetAllQuartos();

            if (collectionClientes != null && collectionClientes.Count() > 0)
            {
                foreach (var item in collectionClientes)
                {
                    ProjetoHotelSerranoSenac.Models.Hotel hotelCliente = ProjetoHotelSerranoSenac.Controllers.Hotel.GetHotel(item.HotelId.ToString());
                    string[] linhaCliente = { item.Id.ToString(), item.NumeroQuarto.ToString(), item.Descricao.ToString(), item.booleanToString(), item.Valor.ToString(), hotelCliente.Nome };

                    quartoGridView.Rows.Add(linhaCliente);
                }
            }
        }

        private void adicionarQuartoButton_Click(object sender, EventArgs e)
        {
            Quarto telaQuarto = new Quarto(null);
            telaQuarto.FormClosed += new FormClosedEventHandler(recarregarDadosGrid);
            telaQuarto.ShowDialog();
        }

        private void atualizarQuartoButton_Click(object sender, EventArgs e)
        {
            if (this.quartoGridView.SelectedRows.Count > 0 &&
                this.quartoGridView.SelectedRows[0].Index !=
                this.quartoGridView.Rows.Count - 1)
            {
                string idQuartoSelecionado = quartoGridView.Rows[this.quartoGridView.SelectedRows[0].Index].Cells[0].Value.ToString();
                Quarto telaCliente = new Quarto(Int32.Parse(idQuartoSelecionado));
                telaCliente.FormClosed += new FormClosedEventHandler(recarregarDadosGrid);
                telaCliente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum Quarto foi selecionado!");
            }
        }

        private void deletarQuartoButton_Click(object sender, EventArgs e)
        {
            if (this.quartoGridView.SelectedRows.Count > 0 &&
                this.quartoGridView.SelectedRows[0].Index !=
                this.quartoGridView.Rows.Count - 1)
            {
                var confirmResult = MessageBox.Show("Tem certeza que deseja excluir o item?", "Exclusão de Item", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    MessageBox.Show(this.quartoGridView.SelectedRows[0].Index.ToString());
                    this.quartoGridView.Refresh();
                }
                else
                {
                    MessageBox.Show("Operação cancelada");
                }

            }
        }
        private void recarregarDadosGrid(object sender, FormClosedEventArgs e)
        {
            PopulateDataGridView();
            this.quartoGridView.Refresh();
        }
        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}