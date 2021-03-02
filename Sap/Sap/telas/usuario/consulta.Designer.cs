namespace Sap.telas.usuario
{
    partial class consulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnick = new System.Windows.Forms.TextBox();
            this.picbusca = new System.Windows.Forms.PictureBox();
            this.dvg = new System.Windows.Forms.DataGridView();
            this.Usuário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesquisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picdelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdelete)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnick
            // 
            this.txtnick.Location = new System.Drawing.Point(137, 12);
            this.txtnick.Name = "txtnick";
            this.txtnick.Size = new System.Drawing.Size(173, 20);
            this.txtnick.TabIndex = 0;
            // 
            // picbusca
            // 
            this.picbusca.BackColor = System.Drawing.Color.Black;
            this.picbusca.Location = new System.Drawing.Point(316, 6);
            this.picbusca.Name = "picbusca";
            this.picbusca.Size = new System.Drawing.Size(60, 33);
            this.picbusca.TabIndex = 1;
            this.picbusca.TabStop = false;
            this.picbusca.Click += new System.EventHandler(this.picbusca_Click);
            // 
            // dvg
            // 
            this.dvg.AllowUserToAddRows = false;
            this.dvg.AllowUserToDeleteRows = false;
            this.dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuário,
            this.Nome,
            this.Idade,
            this.Cargo,
            this.Nacimento,
            this.Registro,
            this.Foto,
            this.Contato,
            this.Login,
            this.pesquisa,
            this.endereco,
            this.agenda});
            this.dvg.Location = new System.Drawing.Point(-2, 45);
            this.dvg.Name = "dvg";
            this.dvg.ReadOnly = true;
            this.dvg.Size = new System.Drawing.Size(473, 264);
            this.dvg.TabIndex = 2;
            // 
            // Usuário
            // 
            this.Usuário.DataPropertyName = "Nick";
            this.Usuário.HeaderText = "Usuário";
            this.Usuário.Name = "Usuário";
            this.Usuário.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Idade
            // 
            this.Idade.DataPropertyName = "idade";
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "cargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // Nacimento
            // 
            this.Nacimento.DataPropertyName = "dt_nascimento";
            this.Nacimento.HeaderText = "Data de nascimento";
            this.Nacimento.Name = "Nacimento";
            this.Nacimento.ReadOnly = true;
            // 
            // Registro
            // 
            this.Registro.DataPropertyName = "registro";
            this.Registro.HeaderText = "Registro";
            this.Registro.Name = "Registro";
            this.Registro.ReadOnly = true;
            // 
            // Foto
            // 
            this.Foto.DataPropertyName = "foto";
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Visible = false;
            // 
            // Contato
            // 
            this.Contato.DataPropertyName = "contato";
            this.Contato.HeaderText = "Contato";
            this.Contato.Name = "Contato";
            this.Contato.ReadOnly = true;
            this.Contato.Visible = false;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "login";
            this.Login.HeaderText = "login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.Visible = false;
            // 
            // pesquisa
            // 
            this.pesquisa.DataPropertyName = "pesquisa";
            this.pesquisa.HeaderText = "pesquisa";
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.ReadOnly = true;
            this.pesquisa.Visible = false;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "endereco";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Visible = false;
            // 
            // agenda
            // 
            this.agenda.DataPropertyName = "agenda";
            this.agenda.HeaderText = "agenda";
            this.agenda.Name = "agenda";
            this.agenda.ReadOnly = true;
            this.agenda.Visible = false;
            // 
            // picdelete
            // 
            this.picdelete.BackColor = System.Drawing.Color.DimGray;
            this.picdelete.Location = new System.Drawing.Point(382, 6);
            this.picdelete.Name = "picdelete";
            this.picdelete.Size = new System.Drawing.Size(60, 33);
            this.picdelete.TabIndex = 3;
            this.picdelete.TabStop = false;
            this.picdelete.Click += new System.EventHandler(this.picdelete_Click);
            // 
            // consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 316);
            this.Controls.Add(this.picdelete);
            this.Controls.Add(this.dvg);
            this.Controls.Add(this.picbusca);
            this.Controls.Add(this.txtnick);
            this.Name = "consulta";
            this.Text = "consulta";
            ((System.ComponentModel.ISupportInitialize)(this.picbusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnick;
        private System.Windows.Forms.PictureBox picbusca;
        private System.Windows.Forms.DataGridView dvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuário;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn agenda;
        private System.Windows.Forms.PictureBox picdelete;
    }
}