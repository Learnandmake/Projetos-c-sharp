namespace Sap.telas.usuario
{
    partial class cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro));
            this.lblnome = new System.Windows.Forms.Label();
            this.picsend = new System.Windows.Forms.PictureBox();
            this.picsendft = new System.Windows.Forms.PictureBox();
            this.msknascimento = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picft = new System.Windows.Forms.PictureBox();
            this.txtft = new System.Windows.Forms.MaskedTextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbocargo = new System.Windows.Forms.ComboBox();
            this.mskcel = new System.Windows.Forms.MaskedTextBox();
            this.mskre = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.mskcep = new System.Windows.Forms.MaskedTextBox();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.cboacesso = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picsend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsendft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picft)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(39, 12);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome:";
            // 
            // picsend
            // 
            this.picsend.BackColor = System.Drawing.Color.Transparent;
            this.picsend.Image = ((System.Drawing.Image)(resources.GetObject("picsend.Image")));
            this.picsend.Location = new System.Drawing.Point(211, 236);
            this.picsend.Name = "picsend";
            this.picsend.Size = new System.Drawing.Size(89, 61);
            this.picsend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picsend.TabIndex = 2;
            this.picsend.TabStop = false;
            this.picsend.Click += new System.EventHandler(this.picsend_Click);
            // 
            // picsendft
            // 
            this.picsendft.BackColor = System.Drawing.Color.Transparent;
            this.picsendft.Image = ((System.Drawing.Image)(resources.GetObject("picsendft.Image")));
            this.picsendft.Location = new System.Drawing.Point(409, 132);
            this.picsendft.Name = "picsendft";
            this.picsendft.Size = new System.Drawing.Size(76, 50);
            this.picsendft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picsendft.TabIndex = 5;
            this.picsendft.TabStop = false;
            this.picsendft.Click += new System.EventHandler(this.picsendft_Click);
            // 
            // msknascimento
            // 
            this.msknascimento.Location = new System.Drawing.Point(79, 64);
            this.msknascimento.Mask = "00/00/0000";
            this.msknascimento.Name = "msknascimento";
            this.msknascimento.Size = new System.Drawing.Size(60, 20);
            this.msknascimento.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "TelResidencial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cargo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "usuario:";
            // 
            // picft
            // 
            this.picft.BackColor = System.Drawing.Color.Transparent;
            this.picft.Image = ((System.Drawing.Image)(resources.GetObject("picft.Image")));
            this.picft.Location = new System.Drawing.Point(382, 10);
            this.picft.Name = "picft";
            this.picft.Size = new System.Drawing.Size(121, 109);
            this.picft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picft.TabIndex = 22;
            this.picft.TabStop = false;
            // 
            // txtft
            // 
            this.txtft.Location = new System.Drawing.Point(394, 191);
            this.txtft.Name = "txtft";
            this.txtft.Size = new System.Drawing.Size(100, 20);
            this.txtft.TabIndex = 23;
            this.txtft.Visible = false;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(79, 12);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 24;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(79, 38);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nascimento:";
            // 
            // cbocargo
            // 
            this.cbocargo.FormattingEnabled = true;
            this.cbocargo.Items.AddRange(new object[] {
            "developer",
            "dba",
            "designer"});
            this.cbocargo.Location = new System.Drawing.Point(79, 86);
            this.cbocargo.Name = "cbocargo";
            this.cbocargo.Size = new System.Drawing.Size(100, 21);
            this.cbocargo.TabIndex = 20;
            // 
            // mskcel
            // 
            this.mskcel.Location = new System.Drawing.Point(269, 8);
            this.mskcel.Mask = "(00)00000-0000";
            this.mskcel.Name = "mskcel";
            this.mskcel.Size = new System.Drawing.Size(89, 20);
            this.mskcel.TabIndex = 29;
            // 
            // mskre
            // 
            this.mskre.Location = new System.Drawing.Point(269, 28);
            this.mskre.Mask = "(00)0000-0000";
            this.mskre.Name = "mskre";
            this.mskre.Size = new System.Drawing.Size(75, 20);
            this.mskre.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "TelCelular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Email:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(267, 51);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 34;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(267, 97);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(62, 20);
            this.txtnumero.TabIndex = 36;
            // 
            // mskcep
            // 
            this.mskcep.Location = new System.Drawing.Point(269, 74);
            this.mskcep.Mask = "00000-000";
            this.mskcep.Name = "mskcep";
            this.mskcep.Size = new System.Drawing.Size(60, 20);
            this.mskcep.TabIndex = 35;
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(268, 120);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(100, 20);
            this.txtcomplemento.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Complemento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Numero:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Cep:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Senha:";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(79, 132);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(100, 20);
            this.txtsenha.TabIndex = 41;
            // 
            // cboacesso
            // 
            this.cboacesso.FormattingEnabled = true;
            this.cboacesso.Items.AddRange(new object[] {
            "junior",
            "senior",
            "master"});
            this.cboacesso.Location = new System.Drawing.Point(79, 108);
            this.cboacesso.Name = "cboacesso";
            this.cboacesso.Size = new System.Drawing.Size(100, 21);
            this.cboacesso.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Acesso:";
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 327);
            this.Controls.Add(this.cboacesso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcomplemento);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.mskcep);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskre);
            this.Controls.Add(this.mskcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtft);
            this.Controls.Add(this.picft);
            this.Controls.Add(this.cbocargo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.msknascimento);
            this.Controls.Add(this.picsendft);
            this.Controls.Add(this.picsend);
            this.Controls.Add(this.lblnome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastro";
            this.Text = "cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.picsend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsendft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.PictureBox picsend;
        private System.Windows.Forms.PictureBox picsendft;
        private System.Windows.Forms.MaskedTextBox msknascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picft;
        private System.Windows.Forms.MaskedTextBox txtft;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbocargo;
        private System.Windows.Forms.MaskedTextBox mskcel;
        private System.Windows.Forms.MaskedTextBox mskre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.MaskedTextBox mskcep;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.ComboBox cboacesso;
        private System.Windows.Forms.Label label11;
    }
}