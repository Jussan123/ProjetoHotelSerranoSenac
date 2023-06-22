using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoHotelSerranoSenac
{
    public class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(142)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 530);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // ;
            this.pictureBox1.Image = Image.FromFile("View/Resources/LogoBranco-Verde.png");
            this.pictureBox1.Location = new System.Drawing.Point(70, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Hotelaria";
            // 
            // panel2
            //
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnEntrar);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblLogin);
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 530);
            this.panel2.TabIndex = 1;
            // 
            // txtLogin
            // 
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(142)))), ((int)(((byte)(131)))));
            this.txtEmail.Location = new System.Drawing.Point(51, 8);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(370, 27);
            this.txtEmail.TabIndex = 6;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(142)))), ((int)(((byte)(131)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(30, 316);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(148, 35);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.txtSenha);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Location = new System.Drawing.Point(0, 243);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(450, 45);
            this.panel7.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            this.txtSenha.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(51, 9);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(370, 26);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(3, 48);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(450, 45);
            this.panel8.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(3, 51);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(450, 45);
            this.panel9.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(3, 51);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(450, 45);
            this.panel10.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 185);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 45);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(3, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(450, 45);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(3, 51);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(450, 45);
            this.panel6.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(3, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 45);
            this.panel4.TabIndex = 4;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(54)))));
            this.lblLogin.Location = new System.Drawing.Point(38, 135);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(236, 24);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login to your account";
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(142)))), ((int)(((byte)(131)))));
            this.btnFechar.Location = new System.Drawing.Point(409, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 40);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);


        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.PictureBox pictureBox1;



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //condicional para efetuar login
            try
            {
                if (Controllers.Login.GetLogin(txtEmail.Text, txtSenha.Text))
                {
                    TelaPrincipal telaPrincipal = new TelaPrincipal();
                    telaPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}