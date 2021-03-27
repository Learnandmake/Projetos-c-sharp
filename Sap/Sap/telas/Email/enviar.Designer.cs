namespace Sap.telas.Email
{
    partial class enviar
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
            this.txtde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtassunto = new System.Windows.Forms.TextBox();
            this.txtpara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmessage = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtanexar = new System.Windows.Forms.TextBox();
            this.picenviar = new System.Windows.Forms.PictureBox();
            this.picanexar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picenviar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picanexar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtde
            // 
            this.txtde.Location = new System.Drawing.Point(131, 2);
            this.txtde.Name = "txtde";
            this.txtde.Size = new System.Drawing.Size(100, 20);
            this.txtde.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Assunto:";
            // 
            // txtassunto
            // 
            this.txtassunto.Location = new System.Drawing.Point(131, 54);
            this.txtassunto.Name = "txtassunto";
            this.txtassunto.Size = new System.Drawing.Size(100, 20);
            this.txtassunto.TabIndex = 3;
            // 
            // txtpara
            // 
            this.txtpara.Location = new System.Drawing.Point(131, 28);
            this.txtpara.Name = "txtpara";
            this.txtpara.Size = new System.Drawing.Size(100, 20);
            this.txtpara.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "para:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "De:";
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(73, 89);
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(227, 132);
            this.txtmessage.TabIndex = 7;
            this.txtmessage.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = " Message:";
            // 
            // txtanexar
            // 
            this.txtanexar.Location = new System.Drawing.Point(73, 223);
            this.txtanexar.Name = "txtanexar";
            this.txtanexar.Size = new System.Drawing.Size(227, 20);
            this.txtanexar.TabIndex = 9;
            // 
            // picenviar
            // 
            this.picenviar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picenviar.Location = new System.Drawing.Point(131, 249);
            this.picenviar.Name = "picenviar";
            this.picenviar.Size = new System.Drawing.Size(100, 50);
            this.picenviar.TabIndex = 1;
            this.picenviar.TabStop = false;
            this.picenviar.Click += new System.EventHandler(this.picenviar_Click);
            // 
            // picanexar
            // 
            this.picanexar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picanexar.Location = new System.Drawing.Point(306, 223);
            this.picanexar.Name = "picanexar";
            this.picanexar.Size = new System.Drawing.Size(53, 20);
            this.picanexar.TabIndex = 10;
            this.picanexar.TabStop = false;
            // 
            // enviar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 311);
            this.Controls.Add(this.picanexar);
            this.Controls.Add(this.txtanexar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpara);
            this.Controls.Add(this.txtassunto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picenviar);
            this.Controls.Add(this.txtde);
            this.Name = "enviar";
            this.Text = "enviar";
            ((System.ComponentModel.ISupportInitialize)(this.picenviar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picanexar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtassunto;
        private System.Windows.Forms.TextBox txtpara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtmessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtanexar;
        private System.Windows.Forms.PictureBox picenviar;
        private System.Windows.Forms.PictureBox picanexar;
    }
}