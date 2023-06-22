using System;
using System.Drawing;
using System.Windows.Forms;
using ProjetoHotelSerranoSenac;

namespace View
{
    public class ListaCliente : Form
    {
        private Panel buttonPanel = new Panel();
        private DataGridView clienteGridView = new DataGridView();
        private Button adicionarClienteButton = new Button();
        private Button atualizarClienteButton = new Button();
        private Button deletarClienteButton = new Button();
        private Button voltarButton = new Button();

        public ListaCliente()
        {
            this.Text = "Listagem de Cliente";
            this.Load += new EventHandler(ListaCliente_Load);
        }

        private void ListaCliente_Load(System.Object sender, System.EventArgs e)
        {
            SetupLayout();
            SetupDataGridView();
            PopulateDataGridView();
        }

        private void clienteGridView_CellFormatting(object sender,
            System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (e != null)
            {
                if (this.clienteGridView.Columns[e.ColumnIndex].Name == "Release Date")
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
            adicionarClienteButton.Text = "Novo";
            adicionarClienteButton.Location = new Point(270, 10);
            adicionarClienteButton.Click += new EventHandler(adicionarClienteButton_Click);

            atualizarClienteButton.Text = "Editar";
            atualizarClienteButton.Location = new Point(350, 10);
            atualizarClienteButton.Click += new EventHandler(atualizarClienteButton_Click);

            deletarClienteButton.Text = "Excluir";
            deletarClienteButton.Location = new Point(430, 10);
            deletarClienteButton.Click += new EventHandler(deletarClienteButton_Click);

            voltarButton.Text = "Voltar";
            voltarButton.Location = new Point(510, 10);
            voltarButton.Click += new EventHandler(voltarButton_Click);

            buttonPanel.Controls.Add(adicionarClienteButton);
            buttonPanel.Controls.Add(atualizarClienteButton);
            buttonPanel.Controls.Add(deletarClienteButton);
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
            this.Controls.Add(clienteGridView);

            clienteGridView.ColumnCount = 5;

            clienteGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            clienteGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            clienteGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(clienteGridView.Font, FontStyle.Bold);

            clienteGridView.Name = "clienteGridView";
            clienteGridView.Location = new Point(8, 8);
            clienteGridView.Size = new Size(600, 400);
            clienteGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            clienteGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            clienteGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            clienteGridView.GridColor = Color.Black;
            clienteGridView.RowHeadersVisible = false;

            clienteGridView.Columns[0].Name = "Id";
            clienteGridView.Columns[1].Name = "Nome";
            clienteGridView.Columns[2].Name = "Email";
            clienteGridView.Columns[3].Name = "Telefone";
            clienteGridView.Columns[4].Name = "Hotel";

            clienteGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clienteGridView.MultiSelect = false;
            clienteGridView.Dock = DockStyle.Fill;

            clienteGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(clienteGridView_CellFormatting);
        }

        private void PopulateDataGridView()
        {
            clienteGridView.Rows.Clear();

            IEnumerable<ProjetoHotelSerranoSenac.Models.Cliente> collectionClientes = ProjetoHotelSerranoSenac.Controllers.Cliente.GetAllClientes();

            if (collectionClientes != null && collectionClientes.Count() > 0)
            {
                foreach (var item in collectionClientes)
                {
                    ProjetoHotelSerranoSenac.Models.Hotel hotelCliente = ProjetoHotelSerranoSenac.Controllers.Hotel.GetHotel(item.HotelId.ToString());
                    string[] linhaCliente = { item.Id.ToString(), item.Nome, item.Email, item.Telefone, hotelCliente.Nome };

                    clienteGridView.Rows.Add(linhaCliente);
                }
            }
        }

        private void adicionarClienteButton_Click(object sender, EventArgs e)
        {
            Cliente telaCliente = new Cliente(null);
            telaCliente.FormClosed += new FormClosedEventHandler(recarregarDadosGrid);
            telaCliente.ShowDialog();
        }

        private void atualizarClienteButton_Click(object sender, EventArgs e)
        {
            if (this.clienteGridView.SelectedRows.Count > 0 &&
                this.clienteGridView.SelectedRows[0].Index !=
                this.clienteGridView.Rows.Count - 1)
            {
                string idClienteSelecionado = clienteGridView.Rows[this.clienteGridView.SelectedRows[0].Index].Cells[0].Value.ToString();
                Cliente telaCliente = new Cliente(Int32.Parse(idClienteSelecionado));
                telaCliente.FormClosed += new FormClosedEventHandler(recarregarDadosGrid);
                telaCliente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum cliente foi selecionado!");
            }
        }

        private void deletarClienteButton_Click(object sender, EventArgs e)
        {
            if (this.clienteGridView.SelectedRows.Count > 0 &&
                this.clienteGridView.SelectedRows[0].Index !=
                this.clienteGridView.Rows.Count - 1)
            {
                var confirmResult = MessageBox.Show("Tem certeza que deseja excluir o Cliente?", "Exclusão de Cliente", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    string idCliente = clienteGridView.Rows[this.clienteGridView.SelectedRows[0].Index].Cells[0].Value.ToString();
                    ProjetoHotelSerranoSenac.Controllers.Cliente.ExcluirCliente(idCliente);
                    MessageBox.Show("Cliente excluído com sucesso!");
                    PopulateDataGridView();
                    this.clienteGridView.Refresh();
                }
                else
                {
                    MessageBox.Show("Operação cancelada");
                }

            }
            else
            {
                MessageBox.Show("Nenhum cliente foi selecionado!");
            }
        }

        private void recarregarDadosGrid(object sender, FormClosedEventArgs e)
        {
            PopulateDataGridView();
            this.clienteGridView.Refresh();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}