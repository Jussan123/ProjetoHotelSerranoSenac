using System;
using System.Drawing;
using System.Windows.Forms;
using ProjetoHotelSerranoSenac;
using View;

namespace View 
{
    public class RelatorioProduto : Form
    {
        private Panel buttonPanel = new Panel();
        private DataGridView produtoGridView = new DataGridView();
        private Button adicionarProdutoButton = new Button();
        private Button atualizarProdutoButton = new Button();
        private Button deletarProdutoButton = new Button();
        private Button voltarButton = new Button();

        public RelatorioProduto()
        {
            this.Text = "Listagem de Produto";
            this.Load += new EventHandler(RelatorioProduto_Load);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void RelatorioProduto_Load(System.Object sender, System.EventArgs e)
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
            this.Size = new Size(600, 400);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#3E5E50");

            voltarButton.Text = "Voltar";
            voltarButton.Location = new Point(510, 10);
            voltarButton.BackColor = Color.Snow;
            voltarButton.Click += new EventHandler(voltarButton_Click);
            voltarButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            buttonPanel.Controls.Add(voltarButton);
            buttonPanel.Height = 50;
            buttonPanel.Dock = DockStyle.Bottom;

            
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
                new Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           
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