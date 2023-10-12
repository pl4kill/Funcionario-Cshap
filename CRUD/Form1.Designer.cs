namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbIdade = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LimparCampos = new System.Windows.Forms.Button();
            this.btnTesteConnectBanco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(44, 88);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(213, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(44, 169);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(213, 20);
            this.txtIdade.TabIndex = 1;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(44, 257);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(213, 20);
            this.txtTelefone.TabIndex = 2;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(39, 20);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(218, 25);
            this.lbTitulo.TabIndex = 3;
            this.lbTitulo.Text = "Cadastro Funcionario";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(40, 65);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(51, 20);
            this.lbNome.TabIndex = 4;
            this.lbNome.Text = "Nome";
            // 
            // lbIdade
            // 
            this.lbIdade.AutoSize = true;
            this.lbIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdade.Location = new System.Drawing.Point(40, 146);
            this.lbIdade.Name = "lbIdade";
            this.lbIdade.Size = new System.Drawing.Size(50, 20);
            this.lbIdade.TabIndex = 5;
            this.lbIdade.Text = "Idade";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.Location = new System.Drawing.Point(40, 234);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(71, 20);
            this.lbTelefone.TabIndex = 6;
            this.lbTelefone.Text = "Telefone";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(53, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonCadastrar_Click);
            // 
            // LimparCampos
            // 
            this.LimparCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimparCampos.Location = new System.Drawing.Point(53, 350);
            this.LimparCampos.Name = "LimparCampos";
            this.LimparCampos.Size = new System.Drawing.Size(195, 34);
            this.LimparCampos.TabIndex = 8;
            this.LimparCampos.Text = "Limpar Campos";
            this.LimparCampos.UseVisualStyleBackColor = true;
            this.LimparCampos.Click += new System.EventHandler(this.LimparCampo_Click);
            // 
            // btnTesteConnectBanco
            // 
            this.btnTesteConnectBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTesteConnectBanco.Location = new System.Drawing.Point(53, 399);
            this.btnTesteConnectBanco.Name = "btnTesteConnectBanco";
            this.btnTesteConnectBanco.Size = new System.Drawing.Size(195, 34);
            this.btnTesteConnectBanco.TabIndex = 9;
            this.btnTesteConnectBanco.Text = "Testar Conexão";
            this.btnTesteConnectBanco.UseVisualStyleBackColor = true;
            this.btnTesteConnectBanco.Click += new System.EventHandler(this.btnTesteConnectBanco_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 456);
            this.Controls.Add(this.btnTesteConnectBanco);
            this.Controls.Add(this.LimparCampos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.lbIdade);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Cadastro Funcionarios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbIdade;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LimparCampos;
        private System.Windows.Forms.Button btnTesteConnectBanco;
    }
}

