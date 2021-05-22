using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios;
namespace Sap.telas.usuario
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();

            //design picturebox
            Rectangle r = new Rectangle(0, 0, picnome.Width, picnome.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 50;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            picnome.Region = new Region(gp);

            Rectangle r1 = new Rectangle(0, 0, picusuario.Width, picusuario.Height);
            System.Drawing.Drawing2D.GraphicsPath gp1 = new System.Drawing.Drawing2D.GraphicsPath();
            int d1 = 50;
            gp1.AddArc(r1.X, r1.Y, d1, d1, 180, 90);
            gp1.AddArc(r1.X + r1.Width - d1, r1.Y, d1, d1, 270, 90);
            gp1.AddArc(r1.X + r1.Width - d1, r1.Y + r1.Height - d1, d1, d1, 0, 90);
            gp1.AddArc(r1.X, r1.Y + r1.Height - d1, d1, d1, 90, 90);
            picusuario.Region = new Region(gp1);

            Rectangle r2 = new Rectangle(0, 0, picnascimento.Width, picnascimento.Height);
            System.Drawing.Drawing2D.GraphicsPath gp2 = new System.Drawing.Drawing2D.GraphicsPath();
            int d2 = 50;
            gp2.AddArc(r2.X, r2.Y, d2, d2, 180, 90);
            gp2.AddArc(r2.X + r2.Width - d2, r2.Y, d2, d2, 270, 90);
            gp2.AddArc(r2.X + r2.Width - d2, r2.Y + r2.Height - d2, d2, d2, 0, 90);
            gp2.AddArc(r2.X, r2.Y + r2.Height - d2, d2, d2, 90, 90);
            picnascimento.Region = new Region(gp2);


            Rectangle r3 = new Rectangle(0, 0, picsenha.Width, picsenha.Height);
            System.Drawing.Drawing2D.GraphicsPath gp3 = new System.Drawing.Drawing2D.GraphicsPath();
            int d3 = 50;
            gp3.AddArc(r3.X, r3.Y, d3, d3, 180, 90);
            gp3.AddArc(r3.X + r3.Width - d3, r3.Y, d3, d3, 270, 90);
            gp3.AddArc(r3.X + r3.Width - d3, r3.Y + r3.Height - d3, d3, d3, 0, 90);
            gp3.AddArc(r3.X, r3.Y + r3.Height - d3, d3, d3, 90, 90);
            picsenha.Region = new Region(gp3);

            Rectangle r4 = new Rectangle(0, 0, pictelcelular.Width, pictelcelular.Height);
            System.Drawing.Drawing2D.GraphicsPath gp4 = new System.Drawing.Drawing2D.GraphicsPath();
            int d4 = 50;
            gp4.AddArc(r4.X, r4.Y, d4, d4, 180, 90);
            gp4.AddArc(r4.X + r4.Width - d4, r4.Y, d4, d4, 270, 90);
            gp4.AddArc(r4.X + r4.Width - d4, r4.Y + r4.Height - d4, d4, d4, 0, 90);
            gp4.AddArc(r4.X, r4.Y + r4.Height - d4, d4, d4, 90, 90);
            pictelcelular.Region = new Region(gp4);

            Rectangle r5 = new Rectangle(0, 0, pictelresidencial.Width, pictelresidencial.Height);
            System.Drawing.Drawing2D.GraphicsPath gp5 = new System.Drawing.Drawing2D.GraphicsPath();
            int d5 = 50;
            gp5.AddArc(r5.X, r5.Y, d5, d5, 180, 90);
            gp5.AddArc(r5.X + r5.Width - d5, r5.Y, d5, d5, 270, 90);
            gp5.AddArc(r5.X + r5.Width - d5, r5.Y + r5.Height - d5, d5, d5, 0, 90);
            gp5.AddArc(r5.X, r5.Y + r5.Height - d5, d5, d5, 90, 90);
            pictelresidencial.Region = new Region(gp5);


            Rectangle r6 = new Rectangle(0, 0, picemail.Width, picemail.Height);
            System.Drawing.Drawing2D.GraphicsPath gp6 = new System.Drawing.Drawing2D.GraphicsPath();
            int d6  = 50;
            gp6.AddArc(r6.X, r6.Y, d6, d6, 180, 90);
            gp6.AddArc(r6.X + r6.Width - d6, r6.Y, d6, d6, 270, 90);
            gp6.AddArc(r6.X + r6.Width - d6, r6.Y + r6.Height - d6, d6, d6, 0, 90);
            gp6.AddArc(r6.X, r6.Y + r6.Height - d6, d6, d6, 90, 90);
            picemail.Region = new Region(gp6);

            Rectangle r7 = new Rectangle(0, 0, piccep.Width, piccep.Height);
            System.Drawing.Drawing2D.GraphicsPath gp7 = new System.Drawing.Drawing2D.GraphicsPath();
            int d7 = 50;
            gp7.AddArc(r7.X, r7.Y, d7, d7, 180, 90);
            gp7.AddArc(r7.X + r7.Width - d7, r7.Y, d7, d7, 270, 90);
            gp7.AddArc(r7.X + r7.Width - d7, r7.Y + r7.Height - d7, d7, d7, 0, 90);
            gp7.AddArc(r7.X, r7.Y + r7.Height - d7, d7, d7, 90, 90);
            piccep.Region = new Region(gp7);

            Rectangle r8 = new Rectangle(0, 0, picnumero.Width, picnumero.Height);
            System.Drawing.Drawing2D.GraphicsPath gp8 = new System.Drawing.Drawing2D.GraphicsPath();
            int d8 = 50;
            gp8.AddArc(r8.X, r8.Y, d8, d8, 180, 90);
            gp8.AddArc(r8.X + r8.Width - d8, r8.Y, d8, d8, 270, 90);
            gp8.AddArc(r8.X + r8.Width - d8, r8.Y + r8.Height - d8, d8, d8, 0, 90);
            gp8.AddArc(r8.X, r8.Y + r8.Height - d8, d8, d8, 90, 90);
            picnumero.Region = new Region(gp8);

            Rectangle r9 = new Rectangle(0, 0, piccomplemento.Width, piccomplemento.Height);
            System.Drawing.Drawing2D.GraphicsPath gp9 = new System.Drawing.Drawing2D.GraphicsPath();
            int d9 = 50;
            gp9.AddArc(r9.X, r9.Y, d9, d9, 180, 90);
            gp9.AddArc(r9.X + r9.Width - d9, r9.Y, d9, d9, 270, 90);
            gp9.AddArc(r9.X + r9.Width - d9, r9.Y + r9.Height - d9, d9, d9, 0, 90);
            gp9.AddArc(r9.X, r9.Y + r9.Height - d9, d9, d9, 90, 90);
            piccomplemento.Region = new Region(gp9);
        }


        private void picsendft_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Selecione a Foto da pessoa") == DialogResult.OK)
            {
                OpenFileDialog dialogo = new OpenFileDialog();

                dialogo.Filter = "Arquivos De Imagem (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Foto carregada com sucesso");
                    string foto = dialogo.FileName.ToString();
                    txtft.Text = foto;
                    picft.Image = Image.FromFile(dialogo.FileName);
                }
            }
        }

        private void picsend_Click(object sender, EventArgs e)
        {
            try
            {
                Bussines.usuario uusuario = new Bussines.usuario();
                Bussines.contato1 ucontato = new Bussines.contato1();
                Bussines.endereco uendereco = new Bussines.endereco();
                Bussines.login ulogin = new Bussines.login();
                Bussines.pesquisa upesquisa = new Bussines.pesquisa();
                Bussines.agenda uagenda = new Bussines.agenda();

                Database.Entities.usuario usuario = new Database.Entities.usuario();
                Database.Entities.contato contato = new Database.Entities.contato();
                Database.Entities.endereco endereco = new Database.Entities.endereco();
                Database.Entities.login login = new Database.Entities.login();

                Functions.verificar Function = new Functions.verificar();
                Functions.criptografia Criptografia = new Functions.criptografia();
                CorreiosApi correios = new CorreiosApi();

                string nome = Convert.ToString(txtnome.Text);
                string nick = Convert.ToString(txtusuario.Text);
                DateTime nascimento = Convert.ToDateTime(msknascimento.Text);
                string cargo = Convert.ToString(cbocargo.SelectedItem);
                int idade = Function.calcularidade(nascimento);

                byte[] imagebyte = null;//coverter imagem em bytes
                FileStream fs = new FileStream(this.txtft.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                imagebyte = br.ReadBytes((int)fs.Length);

                string celular = Convert.ToString(mskcel.Text);
                string residencial = Convert.ToString(mskre.Text);
                string email = Convert.ToString(txtemail.Text);

                string cep = mskcep.Text;
                var api = correios.consultaCEP(cep);
                string rua = api.end;
                string numero = Convert.ToString(txtnumero.Text);
                string complemento1 = txtcomplemento.Text;
                string complemento2 = api.complemento2;

               bool idadeok= Function.verificaridade(nascimento);
               if(idadeok==false)
               { MessageBox.Show("É preciso ser maior de 18 para acessar esse sistema"); }

                bool emailok = Function.isemail(email);
                if(emailok ==false)
                { MessageBox.Show("erro verifique seu email"); }

                string senha = Criptografia.gerarmd5(Convert.ToString(txtsenha.Text));
                string acesso = Convert.ToString(cboacesso.SelectedItem);

                usuario.nome = nome;
                usuario.nick = nick;
                usuario.dt_nascimento = nascimento;
                usuario.idade = idade;
                usuario.registro = DateTime.Now;
                usuario.foto = imagebyte;
                usuario.cargo = cargo;

                contato.nick = nick;
                contato.email = email;
                contato.telefonecel = celular;
                contato.telefonere = residencial;

                endereco.nick = nick;
                endereco.rua = rua;
                endereco.complemento1 = complemento1;
                endereco.complemento2 = complemento2;
                endereco.numero = numero;
                endereco.cep = cep;

                login.nick = nick;
                login.acesso = acesso;
                login.senha = senha;

                uusuario.inserir(usuario);
                ucontato.inserir(contato);
                uendereco.inserir(endereco);
                ulogin.inserir(login);


                MessageBox.Show("concluído");
            }
        
            catch(Exception)
            { MessageBox.Show("erro, verifique o formulário e tente novamente"); }
            }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS { public int cxLeftWidth; public int cxRightWidth; public int cyTopHeight; public int cyBottomHeight; }

        private void lblnome_Click(object sender, EventArgs e)
        {
            lblnome.Visible = false;
        }

        private void lblusuario_Click(object sender, EventArgs e)
        {
            lblusuario.Visible = false;
        }

        private void lblnascimento_Click(object sender, EventArgs e)
        {
            lblnascimento.Visible = false;
            msknascimento.Visible = true;
        }

        private void lblcargo_Click(object sender, EventArgs e)
        {
            lblcargo.Visible = false;
        }

        private void lblacesso_Click(object sender, EventArgs e)
        {
            lblacesso.Visible = false;
        }

        private void lblsenha_Click(object sender, EventArgs e)
        {
            lblsenha.Visible = false;
        }

        private void lbltelcelular_Click(object sender, EventArgs e)
        {
            lbltelcelular.Visible = false;
            mskcel.Visible = true;
        }

        private void lblresidencial_Click(object sender, EventArgs e)
        {
            lblresidencial.Visible = false;
            mskre.Visible = true;
        }

        private void lblemail_Click(object sender, EventArgs e)
        {
            lblemail.Visible = false;
        }

        private void lblcep_Click(object sender, EventArgs e)
        {
            lblcep.Visible = false;
            mskcep.Visible = true;
        }

        private void lblnumero_Click(object sender, EventArgs e)
        {
            lblnumero.Visible = false;
        }

        private void lblcomplemento_Click(object sender, EventArgs e)
        {
            lblcomplemento.Visible = false;
        }

        private void picsend_Click_1(object sender, EventArgs e)
        {

        }

        private void cbocargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}