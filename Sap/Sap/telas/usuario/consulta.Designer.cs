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
            ((System.ComponentModel.ISupportInitialize)(this.picbusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnick
            // 
            this.txtnick.Location = new System.Drawing.Point(137, 14);
            this.txtnick.Name = "txtnick";
            this.txtnick.Size = new System.Drawing.Size(173, 20);
            this.txtnick.TabIndex = 0;
            // 
            // picbusca
            // 
            this.picbusca.BackColor = System.Drawing.Color.Black;
            this.picbusca.Location = new System.Drawing.Point(316, 8);
            this.picbusca.Name = "picbusca";
            this.picbusca.Size = new System.Drawing.Size(60, 33);
            this.picbusca.TabIndex = 1;
            this.picbusca.TabStop = false;
            // 
            // dvg
            // 
            this.dvg.AllowUserToAddRows = false;
            this.dvg.AllowUserToDeleteRows = false;
            this.dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg.Location = new System.Drawing.Point(0, 51);
            this.dvg.Name = "dvg";
            this.dvg.ReadOnly = true;
            this.dvg.Size = new System.Drawing.Size(472, 265);
            this.dvg.TabIndex = 2;
            // 
            // consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 316);
            this.Controls.Add(this.dvg);
            this.Controls.Add(this.picbusca);
            this.Controls.Add(this.txtnick);
            this.Name = "consulta";
            this.Text = "consulta";
            ((System.ComponentModel.ISupportInitialize)(this.picbusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnick;
        private System.Windows.Forms.PictureBox picbusca;
        private System.Windows.Forms.DataGridView dvg;
    }
}