using System;
using System.Drawing;
using System.Windows.Forms;
using ProjetoHotelSerranoSenac;
using View;

namespace View 
{
    public class ListaProduto : Form
    {
        private Panel buttonPanel = new Panel();
        private DataGridView produtoGridView = new DataGridView();
        private Button adicionarProdutoButton = new Button();
        private Button atualizarProdutoButton = new Button();
        private Button deletarProdutoButton = new Button();
        private Button voltarButton = new Button();

        public ListaProduto()
        {
            this.Text = "Listagem de Produto";
            this.Load += new EventHandler(ListaProduto_Load);
        }

        private void ListaProduto_Load(System.Object sender, System.EventArgs e)
        {
            SetupLayout();
            SetupDataGridView();
            PopulateDataGridView();
        }

        private void produtoGridView_CellFormatting(object sender,
            System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (e != null)
            {
                if (this.produtoGridView.Columns[e.ColumnIndex].Name == "Release Date")
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
            adicionarProdutoButton.Text = "Novo";
            adicionarProdutoButton.Location = new Point(270, 10);
            adicionarProdutoButton.Click += new EventHandler(adicionarProdutoButton_Click);

            atualizarProdutoButton.Text = "Editar";
            atualizarProdutoButton.Location = new Point(350, 10);
            atualizarProdutoButton.Click += new EventHandler(atualizarProdutoButton_Click);

            deletarProdutoButton.Text = "Excluir";
            deletarProdutoButton.Location = new Point(430, 10);
            deletarProdutoButton.Click += new EventHandler(deletarProdutoButton_Click);

            voltarButton.Text = "Voltar";
            voltarButton.Location = new Point(510, 10);
            voltarButton.Click += new EventHandler(voltarButton_Click);

            buttonPanel.Controls.Add(adicionarProdutoButton);
            buttonPanel.Controls.Add(atualizarProdutoButton);
            buttonPanel.Controls.Add(deletarProdutoButton);
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
            this.Controls.Add(produtoGridView);

            produtoGridView.ColumnCount = 6;

            produtoGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            produtoGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            produtoGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(produtoGridView.Font, FontStyle.Bold);

            produtoGridView.Name = "produtoGridView";
            produtoGridView.Location = new Point(8, 8);
            produtoGridView.Size = new Size(600, 400);
            produtoGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            produtoGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            produtoGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            produtoGridView.GridColor = Color.Black;
            produtoGridView.RowHeadersVisible = false;

            produtoGridView.Columns[0].Name = "Id";
            produtoGridView.Columns[1].Name = "Nome";
            produtoGridView.Columns[2].Name = "Preço";
            produtoGridView.Columns[3].Name = "Preço de Compra";
            produtoGridView.Columns[4].Name = "Quantidade";
            produtoGridView.Columns[5].Name = "Hotel";
           
            produtoGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            produtoGridView.MultiSelect = false;
            produtoGridView.Dock = DockStyle.Fill;

            produtoGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(produtoGridView_CellFormatting);
        }

        private void PopulateDataGridView()
        {


            produtoGridView.Rows.Clear();

            IEnumerable<ProjetoHotelSerranoSenac.Models.Produto> collectionClientes = ProjetoHotelSerranoSenac.Controllers.Produto.GetAllProdutos();

            if (collectionClientes != null && collectionClientes.Count() > 0)
            {
                foreach (var item in collectionClientes)
                {
                    ProjetoHotelSerranoSenac.Models.Hotel hotelCliente = ProjetoHotelSerranoSenac.Controllers.Hotel.GetHotel(item.HotelId.ToString());
                    string[] linhaCliente = { item.Id.ToString(), item.Nome, item.Preco.ToString(), item.PrecoCompra.ToString(), item.Quantidade.ToString(), hotelCliente.Nome };

                    produtoGridView.Rows.Add(linhaCliente);
                }
            }
        }

        private void adicionarProdutoButton_Click(object sender, EventArgs e)
        {
            Produto telaProduto = new Produto(null);
            telaProduto.FormClosed += new FormClosedEventHandler(recarregarDadosGrid);
            telaProduto.ShowDialog();
        }

        private void atualizarProdutoButton_Click(object sender, EventArgs e)
        {
            if (this.produtoGridView.SelectedRows.Count > 0 &&
                this.produtoGridView.SelectedRows[0].Index !=
                this.produtoGridView.Rows.Count - 1)
            {
                string idProdutoSelecionado = produtoGridView.Rows[this.produtoGridView.SelectedRows[0].Index].Cells[0].Value.ToString();
                Produto telaCliente = new Produto(Int32.Parse(idProdutoSelecionado));
                telaCliente.FormClosed += new FormClosedEventHandler(recarregarDadosGrid);
                telaCliente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum cliente foi selecionado!");
            }
        }

        private void deletarProdutoButton_Click(object sender, EventArgs e)
        {
            if (this.produtoGridView.SelectedRows.Count > 0 &&
                this.produtoGridView.SelectedRows[0].Index !=
                this.produtoGridView.Rows.Count - 1)
            {
                var confirmResult = MessageBox.Show("Tem certeza que deseja excluir o item?", "Exclusão de Item", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    MessageBox.Show(this.produtoGridView.SelectedRows[0].Index.ToString());
                    this.produtoGridView.Refresh();
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
            this.produtoGridView.Refresh();
        }
        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}