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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consulta));
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
            this.picalterar = new System.Windows.Forms.PictureBox();
            this.gp1 = new System.Windows.Forms.GroupBox();
            this.picreturn = new System.Windows.Forms.PictureBox();
            this.cboacesso = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.mskcep = new System.Windows.Forms.MaskedTextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskre = new System.Windows.Forms.MaskedTextBox();
            this.mskcel = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtft = new System.Windows.Forms.MaskedTextBox();
            this.picft = new System.Windows.Forms.PictureBox();
            this.cbocargo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msknascimento = new System.Windows.Forms.MaskedTextBox();
            this.picsendft = new System.Windows.Forms.PictureBox();
            this.picsend = new System.Windows.Forms.PictureBox();
            this.lblnome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picalterar)).BeginInit();
            this.gp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsendft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsend)).BeginInit();
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
            this.picbusca.BackColor = System.Drawing.Color.Transparent;
            this.picbusca.Image = ((System.Drawing.Image)(resources.GetObject("picbusca.Image")));
            this.picbusca.Location = new System.Drawing.Point(316, 6);
            this.picbusca.Name = "picbusca";
            this.picbusca.Size = new System.Drawing.Size(42, 33);
            this.picbusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.dvg.Location = new System.Drawing.Point(2, 45);
            this.dvg.Name = "dvg";
            this.dvg.ReadOnly = true;
            this.dvg.Size = new System.Drawing.Size(469, 264);
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
            this.picdelete.BackColor = System.Drawing.Color.Transparent;
            this.picdelete.Image = ((System.Drawing.Image)(resources.GetObject("picdelete.Image")));
            this.picdelete.Location = new System.Drawing.Point(364, 6);
            this.picdelete.Name = "picdelete";
            this.picdelete.Size = new System.Drawing.Size(44, 33);
            this.picdelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picdelete.TabIndex = 3;
            this.picdelete.TabStop = false;
            this.picdelete.Click += new System.EventHandler(this.picdelete_Click);
            // 
            // picalterar
            // 
            this.picalterar.BackColor = System.Drawing.Color.Transparent;
            this.picalterar.Image = ((System.Drawing.Image)(resources.GetObject("picalterar.Image")));
            this.picalterar.Location = new System.Drawing.Point(414, 6);
            this.picalterar.Name = "picalterar";
            this.picalterar.Size = new System.Drawing.Size(42, 33);
            this.picalterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picalterar.TabIndex = 5;
            this.picalterar.TabStop = false;
            this.picalterar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gp1
            // 
            this.gp1.Controls.Add(this.picreturn);
            this.gp1.Controls.Add(this.cboacesso);
            this.gp1.Controls.Add(this.label11);
            this.gp1.Controls.Add(this.label10);
            this.gp1.Controls.Add(this.txtsenha);
            this.gp1.Controls.Add(this.label9);
            this.gp1.Controls.Add(this.label8);
            this.gp1.Controls.Add(this.label7);
            this.gp1.Controls.Add(this.txtcomplemento);
            this.gp1.Controls.Add(this.txtnumero);
            this.gp1.Controls.Add(this.mskcep);
            this.gp1.Controls.Add(this.txtemail);
            this.gp1.Controls.Add(this.label4);
            this.gp1.Controls.Add(this.label2);
            this.gp1.Controls.Add(this.mskre);
            this.gp1.Controls.Add(this.mskcel);
            this.gp1.Controls.Add(this.label1);
            this.gp1.Controls.Add(this.txtusuario);
            this.gp1.Controls.Add(this.txtnome);
            this.gp1.Controls.Add(this.txtft);
            this.gp1.Controls.Add(this.picft);
            this.gp1.Controls.Add(this.cbocargo);
            this.gp1.Controls.Add(this.label6);
            this.gp1.Controls.Add(this.label5);
            this.gp1.Controls.Add(this.label3);
            this.gp1.Controls.Add(this.msknascimento);
            this.gp1.Controls.Add(this.picsendft);
            this.gp1.Controls.Add(this.picsend);
            this.gp1.Controls.Add(this.lblnome);
            this.gp1.Location = new System.Drawing.Point(2, 6);
            this.gp1.Name = "gp1";
            this.gp1.Size = new System.Drawing.Size(501, 303);
            this.gp1.TabIndex = 7;
            this.gp1.TabStop = false;
            this.gp1.Visible = false;
            // 
            // picreturn
            // 
            this.picreturn.BackColor = System.Drawing.Color.Transparent;
            this.picreturn.Image = ((System.Drawing.Image)(resources.GetObject("picreturn.Image")));
            this.picreturn.Location = new System.Drawing.Point(6, 11);
            this.picreturn.Name = "picreturn";
            this.picreturn.Size = new System.Drawing.Size(30, 28);
            this.picreturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picreturn.TabIndex = 75;
            this.picreturn.TabStop = false;
            this.picreturn.Click += new System.EventHandler(this.picreturn_Click);
            // 
            // cboacesso
            // 
            this.cboacesso.FormattingEnabled = true;
            this.cboacesso.Items.AddRange(new object[] {
            "junior",
            "senior",
            "master"});
            this.cboacesso.Location = new System.Drawing.Point(63, 139);
            this.cboacesso.Name = "cboacesso";
            this.cboacesso.Size = new System.Drawing.Size(100, 21);
            this.cboacesso.TabIndex = 74;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 73;
            this.label11.Text = "Acesso:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "Senha:";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(63, 163);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(100, 20);
            this.txtsenha.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Cep:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Numero:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Complemento:";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(252, 151);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(100, 20);
            this.txtcomplemento.TabIndex = 67;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(251, 128);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(62, 20);
            this.txtnumero.TabIndex = 66;
            // 
            // mskcep
            // 
            this.mskcep.Location = new System.Drawing.Point(253, 105);
            this.mskcep.Mask = "00000-000";
            this.mskcep.Name = "mskcep";
            this.mskcep.Size = new System.Drawing.Size(60, 20);
            this.mskcep.TabIndex = 65;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(251, 82);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "TelCelular:";
            // 
            // mskre
            // 
            this.mskre.Location = new System.Drawing.Point(253, 59);
            this.mskre.Mask = "(00)0000-0000";
            this.mskre.Name = "mskre";
            this.mskre.Size = new System.Drawing.Size(75, 20);
            this.mskre.TabIndex = 61;
            // 
            // mskcel
            // 
            this.mskcel.Location = new System.Drawing.Point(253, 39);
            this.mskcel.Mask = "(00)00000-0000";
            this.mskcel.Name = "mskcel";
            this.mskcel.Size = new System.Drawing.Size(89, 20);
            this.mskcel.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Nascimento:";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(63, 69);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 58;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(63, 43);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 57;
            // 
            // txtft
            // 
            this.txtft.Location = new System.Drawing.Point(384, 200);
            this.txtft.Name = "txtft";
            this.txtft.Size = new System.Drawing.Size(100, 20);
            this.txtft.TabIndex = 56;
            this.txtft.Visible = false;
            // 
            // picft
            // 
            this.picft.BackColor = System.Drawing.Color.Transparent;
            this.picft.Image = ((System.Drawing.Image)(resources.GetObject("picft.Image")));
            this.picft.Location = new System.Drawing.Point(372, 19);
            this.picft.Name = "picft";
            this.picft.Size = new System.Drawing.Size(121, 109);
            this.picft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picft.TabIndex = 55;
            this.picft.TabStop = false;
            // 
            // cbocargo
            // 
            this.cbocargo.FormattingEnabled = true;
            this.cbocargo.Items.AddRange(new object[] {
            "developer",
            "dba",
            "designer"});
            this.cbocargo.Location = new System.Drawing.Point(63, 117);
            this.cbocargo.Name = "cbocargo";
            this.cbocargo.Size = new System.Drawing.Size(100, 21);
            this.cbocargo.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Cargo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "TelResidencial:";
            // 
            // msknascimento
            // 
            this.msknascimento.Location = new System.Drawing.Point(63, 95);
            this.msknascimento.Mask = "00/00/0000";
            this.msknascimento.Name = "msknascimento";
            this.msknascimento.Size = new System.Drawing.Size(60, 20);
            this.msknascimento.TabIndex = 50;
            // 
            // picsendft
            // 
            this.picsendft.BackColor = System.Drawing.Color.Transparent;
            this.picsendft.Image = ((System.Drawing.Image)(resources.GetObject("picsendft.Image")));
            this.picsendft.Location = new System.Drawing.Point(399, 141);
            this.picsendft.Name = "picsendft";
            this.picsendft.Size = new System.Drawing.Size(76, 50);
            this.picsendft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picsendft.TabIndex = 49;
            this.picsendft.TabStop = false;
            this.picsendft.Click += new System.EventHandler(this.picsendft_Click);
            // 
            // picsend
            // 
            this.picsend.BackColor = System.Drawing.Color.Transparent;
            this.picsend.Image = ((System.Drawing.Image)(resources.GetObject("picsend.Image")));
            this.picsend.Location = new System.Drawing.Point(211, 221);
            this.picsend.Name = "picsend";
            this.picsend.Size = new System.Drawing.Size(89, 61);
            this.picsend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picsend.TabIndex = 48;
            this.picsend.TabStop = false;
            this.picsend.Click += new System.EventHandler(this.picsend_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(23, 43);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 47;
            this.lblnome.Text = "Nome:";
            // 
            // consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 316);
            this.Controls.Add(this.gp1);
            this.Controls.Add(this.picalterar);
            this.Controls.Add(this.picdelete);
            this.Controls.Add(this.dvg);
            this.Controls.Add(this.picbusca);
            this.Controls.Add(this.txtnick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "consulta";
            this.Text = "consulta";
            ((System.ComponentModel.ISupportInitialize)(this.picbusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picalterar)).EndInit();
            this.gp1.ResumeLayout(false);
            this.gp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsendft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsend)).EndInit();
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
        private System.Windows.Forms.PictureBox picalterar;
        private System.Windows.Forms.GroupBox gp1;
        private System.Windows.Forms.ComboBox cboacesso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.MaskedTextBox mskcep;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskre;
        private System.Windows.Forms.MaskedTextBox mskcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.MaskedTextBox txtft;
        private System.Windows.Forms.PictureBox picft;
        private System.Windows.Forms.ComboBox cbocargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msknascimento;
        private System.Windows.Forms.PictureBox picsendft;
        private System.Windows.Forms.PictureBox picsend;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.PictureBox picreturn;
    }
}