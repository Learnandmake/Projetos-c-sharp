using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sap.telas.login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //design picturebox
            Rectangle r = new Rectangle(0, 0, picbarra.Width, picbarra.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 50;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            picbarra.Region = new Region(gp);

            //design picturebox
            Rectangle r1 = new Rectangle(0, 0, picusuario.Width, picusuario.Height);
            System.Drawing.Drawing2D.GraphicsPath gp1 = new System.Drawing.Drawing2D.GraphicsPath();
            int d1 = 50;
            gp1.AddArc(r1.X, r1.Y, d1, d1, 180, 90);
            gp1.AddArc(r1.X + r1.Width - d1, r1.Y, d1, d1, 270, 90);
            gp1.AddArc(r1.X + r1.Width - d1, r1.Y + r1.Height - d1, d1, d1, 0, 90);
            gp1.AddArc(r1.X, r1.Y + r1.Height - d1, d1, d1, 90, 90);
            picusuario.Region = new Region(gp1);

            //design picturebox
            Rectangle r2 = new Rectangle(0, 0, picsenha.Width, picsenha.Height);
            System.Drawing.Drawing2D.GraphicsPath gp2 = new System.Drawing.Drawing2D.GraphicsPath();
            int d2 = 50;
            gp2.AddArc(r2.X, r2.Y, d2, d2, 180, 90);
            gp2.AddArc(r2.X + r2.Width - d2, r2.Y, d2, d2, 270, 90);
            gp2.AddArc(r2.X + r2.Width - d2, r2.Y + r2.Height - d2, d2, d2, 0, 90);
            gp2.AddArc(r2.X, r2.Y + r2.Height - d2, d2, d2, 90, 90);
            picsenha.Region = new Region(gp2);


            //design picturebox
            Rectangle r3 = new Rectangle(0, 0, picglogin.Width, picglogin.Height);
            System.Drawing.Drawing2D.GraphicsPath gp3 = new System.Drawing.Drawing2D.GraphicsPath();
            int d3 = 50;
            gp3.AddArc(r3.X, r3.Y, d3, d3, 180, 90);
            gp3.AddArc(r3.X + r3.Width - d3, r3.Y, d3, d3, 270, 90);
            gp3.AddArc(r3.X + r3.Width - d3, r3.Y + r3.Height - d3, d3, d3, 0, 90);
            gp3.AddArc(r3.X, r3.Y + r3.Height - d3, d3, d3, 90, 90);
            picglogin.Region = new Region(gp3);

        }

        private void piclogin_Click(object sender, EventArgs e)
        {
            Bussines.login blogin = new Bussines.login();
            Functions.criptografia criptografia = new Functions.criptografia();

            string usuario =Convert.ToString(txtusuario.Text);
            string senha1 = Convert.ToString(txtsenha.Text);
            string senha =Convert.ToString(criptografia.gerarmd5(senha1));

           int count= blogin.vlogin(usuario,senha);
           
           if(count!= 0 )
           {
                menu.principal menu = new telas.menu.principal(usuario);
                menu.Show();

                this.Visible = false;

           }

           else
           { MessageBox.Show("Erro verifique seu usuário e senha"); }

        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS { public int cxLeftWidth; public int cxRightWidth; public int cyTopHeight; public int cyBottomHeight; }

        private void login_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.LightSeaGreen, 5, ButtonBorderStyle.Solid, Color.LightSeaGreen, 5, ButtonBorderStyle.Solid, Color.LightSeaGreen, 5, ButtonBorderStyle.Solid, Color.LightSeaGreen, 5, ButtonBorderStyle.Solid);
        }

        private void picfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void picglogin_Click(object sender, EventArgs e)
        {

        }

        private void picnvi_Click(object sender, EventArgs e)
        {
            txtsenha.UseSystemPasswordChar = false;
            picvi.Visible = true;
            picnvi.Visible = false;
        }

        private void picvi_Click(object sender, EventArgs e)
        {
            txtsenha.UseSystemPasswordChar = true;
            picvi.Visible = false;
            picnvi.Visible = true;
        }
    }
}
