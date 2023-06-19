
namespace View
{    
	public class Produto : Form {

		Panel buttonPanel = new Panel();		

		Label lblNome;
		Label lblPreco;

		TextBox txtNome;
		TextBox txtPreco;		

		Button btnConfirmar;
		Button btnVoltar;

        ProgressBar pbTest;

		public Produto() {
			this.Text = "Cadastro de Produto";

            this.Size = new Size(600, 500);

			lblNome = new Label();
			lblNome.Text = "Nome:";
			lblNome.AutoSize = true;
			lblNome.Location = new Point(20,60);

			txtNome = new TextBox();
			txtNome.Location = new Point(80, 60);
			txtNome.Size = new Size(100, 18);

			lblPreco = new Label();
			lblPreco.Text = "Preço:";
			lblPreco.AutoSize = true;
			lblPreco.Location = new Point(20,120);

			txtPreco = new TextBox();
			txtPreco.Location = new Point(80, 120);
			txtPreco.Size = new Size(100, 18);			

			btnConfirmar = new Button();
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.Location = new Point(10, 10);
            btnConfirmar.Click += new EventHandler(adicionarProdutoButton_Click);

			btnVoltar = new Button();
            btnVoltar.Text = "Voltar";
            btnVoltar.Location = new Point(400, 10);
            btnVoltar.Click += new EventHandler(voltarButton_Click);            

            buttonPanel.Controls.Add(btnConfirmar);
            buttonPanel.Controls.Add(btnVoltar);
            buttonPanel.Height = 50;
            buttonPanel.Dock = DockStyle.Bottom;

            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtPreco);			
            this.Controls.Add(this.buttonPanel);
		}

		private void adicionarProdutoButton_Click(object sender, EventArgs e) {
            //aqui vai pegar os dados do produto informado, chamar a controller e salvar no banco através do model de Produto
		}

		private void voltarButton_Click(object sender, EventArgs e) {
			this.Close();
		}
        
    }
}