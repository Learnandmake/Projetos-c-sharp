using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios;

namespace Sap.telas.usuario
{
    public partial class consulta : Form
    {
        public consulta()
        {
            InitializeComponent();
            Bussines.usuario busuario = new Bussines.usuario();
            dvg.DataSource = busuario.btodos();
        }

        private void picbusca_Click(object sender, EventArgs e)
        { try
            {
                Bussines.usuario busuario = new Bussines.usuario();

                string busca = Convert.ToString(txtnick.Text);

                busca.ToLower();
                busca.Trim();

                dvg.DataSource = busuario.bnick(busca);
            }

            catch(Exception)
            { }
        }



        private void picdelete_Click(object sender, EventArgs e)
        {
         
            Database.Entities.usuario nickselecionado= dvg.CurrentRow.DataBoundItem as Database.Entities.usuario;

            Bussines.usuario busuario = new Bussines.usuario();
           
          
            busuario.delete(nickselecionado.nick);

            dvg.DataSource = busuario.btodos();

            MessageBox.Show("concluido");     

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Database.Entities.agenda agenda = new Database.Entities.agenda();
            Database.Entities.contato contato = new Database.Entities.contato();
            Database.Entities.endereco endereco = new Database.Entities.endereco();
            Database.Entities.login login = new Database.Entities.login();
            Database.Entities.pesquisa pesquisa = new Database.Entities.pesquisa();
            Database.Entities.usuario usuario = new Database.Entities.usuario();

            Bussines.agenda bagenda = new Bussines.agenda();
            Bussines.contato1 bcontato = new Bussines.contato1();
            Bussines.endereco bendereco = new Bussines.endereco();
            Bussines.login blogin = new Bussines.login();
            Bussines.pesquisa bpesquisa = new Bussines.pesquisa();
            Bussines.usuario busuario = new Bussines.usuario();

            Database.Entities.usuario nickselecionado = dvg.CurrentRow.DataBoundItem as Database.Entities.usuario;
            string nick = nickselecionado.nick;    

            gp1.Show();

            agenda= bagenda.busca(nick);
            contato= bcontato.busca(nick);
            endereco= bendereco.busca(nick);
            login= blogin.busca(nick);
            pesquisa= bpesquisa.busca(nick);
         

            txtnome.Text = nickselecionado.nome;
            txtusuario.Text = nickselecionado.nick;
            msknascimento.Text =Convert.ToString( nickselecionado.dt_nascimento);
            cbocargo.Text = nickselecionado.cargo;
            Byte[] image = ((Byte[])(nickselecionado.foto));
            MemoryStream ms = new MemoryStream(image);
            picft.Image = System.Drawing.Image.FromStream(ms);

            txtemail.Text = contato.email;
            mskcel.Text = contato.telefonecel;
            mskre.Text = contato.telefonere;

            mskcep.Text = endereco.cep;
            txtnumero.Text = endereco.numero;
            txtcomplemento.Text = endereco.complemento2;

            txtsenha.Text = login.senha;
            cboacesso.Text = login.acesso;
        }

        private void picsend_Click(object sender, EventArgs e)
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

            bool idadeok = Function.verificaridade(nascimento);
            if (idadeok == false)
            { MessageBox.Show("É preciso ser maior de 18 para acessar esse sistema"); }

            bool emailok = Function.isemail(email);
            if (emailok == false)
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

            uusuario.alterar(usuario);
            ucontato.alterar(contato);
            uendereco.alterar(endereco);
            ulogin.alterar(login);

            MessageBox.Show("Concluido");
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

        private void picreturn_Click(object sender, EventArgs e)
        {
            gp1.Visible = false;
        }
    }
}
