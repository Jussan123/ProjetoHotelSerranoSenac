using System;
using System.Drawing;
using System.Windows.Forms;
using ProjetoHotelSerranoSenac;

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

            produtoGridView.ColumnCount = 3;

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
            produtoGridView.Columns[2].DefaultCellStyle.Font =
                new Font(produtoGridView.DefaultCellStyle.Font, FontStyle.Italic);

            produtoGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            produtoGridView.MultiSelect = false;
            produtoGridView.Dock = DockStyle.Fill;

            produtoGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(produtoGridView_CellFormatting);
        }

        private void PopulateDataGridView()
        {

            string[] row0 = { "1", "Carro", "10" };
            string[] row1 = { "2", "Bicicleta", "20" };
            string[] row2 = { "3", "Moto", "30" };

            produtoGridView.Rows.Add(row0);
            produtoGridView.Rows.Add(row1);
            produtoGridView.Rows.Add(row2);
        }

        private void adicionarProdutoButton_Click(object sender, EventArgs e)
        {
            Produto telaProduto = new Produto();
            telaProduto.ShowDialog();
        }

        private void atualizarProdutoButton_Click(object sender, EventArgs e)
        {
            //aqui na atualização/edição vai pegar o id da linha selecionada e passar por parâmetro o idSelecionado
            // Produto telaProduto = new Produto(idSelecionado);
            // telaProduto.ShowDialog();
            this.produtoGridView.Rows.Add();
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

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}