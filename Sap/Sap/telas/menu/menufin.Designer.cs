namespace Sap.telas.menu
{
    partial class menufin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menufin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picsearch = new System.Windows.Forms.PictureBox();
            this.picadd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picadd)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 365);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // picsearch
            // 
            this.picsearch.BackColor = System.Drawing.Color.Teal;
            this.picsearch.Image = ((System.Drawing.Image)(resources.GetObject("picsearch.Image")));
            this.picsearch.Location = new System.Drawing.Point(12, 68);
            this.picsearch.Name = "picsearch";
            this.picsearch.Size = new System.Drawing.Size(62, 46);
            this.picsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picsearch.TabIndex = 14;
            this.picsearch.TabStop = false;
            // 
            // picadd
            // 
            this.picadd.BackColor = System.Drawing.Color.Teal;
            this.picadd.Image = ((System.Drawing.Image)(resources.GetObject("picadd.Image")));
            this.picadd.Location = new System.Drawing.Point(12, 12);
            this.picadd.Name = "picadd";
            this.picadd.Size = new System.Drawing.Size(62, 50);
            this.picadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picadd.TabIndex = 13;
            this.picadd.TabStop = false;
            // 
            // menufinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 361);
            this.Controls.Add(this.picsearch);
            this.Controls.Add(this.picadd);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menufinanceiro";
            this.Text = "menufinanceiro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picadd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picsearch;
        private System.Windows.Forms.PictureBox picadd;
    }
}