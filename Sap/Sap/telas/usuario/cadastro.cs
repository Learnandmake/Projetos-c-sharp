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
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
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
            Bussines.usuario ubussines = new Bussines.usuario();
            Database.Entities.usuario usuario = new Database.Entities.usuario();
            Database.Entities.contato contato = new Database.Entities.contato();
            Database.Entities.endereco endereco = new Database.Entities.endereco();
            Database.Entities.login login = new Database.Entities.login();
            Functions.verificar Function = new Functions.verificar();
            Functions.criptografia Criptografia = new Functions.criptografia();
            CorreiosApi correios = new CorreiosApi();

            string nome = Convert.ToString( txtnome.Text);
            string nick =Convert.ToString ( txtusuario.Text);
            DateTime nascimento = Convert.ToDateTime( msknascimento.Text);
            string cargo =Convert.ToString(cbocargo.SelectedItem);
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
            string numero = txtnumero.Text;
            string complemento1 = txtcomplemento.Text;
            string complemento2 = api.complemento;

            

            string senha = Criptografia.gerarmd5( Convert.ToString(txtsenha.Text));
            string acesso = Convert.ToString(cboacesso.SelectedItem);

            usuario.nome = nome;
            usuario.nick = nick;
            usuario.dt_nascimento = nascimento;
            usuario.idade = idade;
            usuario.registro = DateTime.Now;
            usuario.foto = imagebyte;
            usuario.cargo = cargo;

            contato.nick = nick;
            contato.telefonecel = celular;
            contato.telefonere = residencial;

            endereco.rua = rua;
            endereco.complemento1 = complemento1;
            endereco.complemento2 = complemento2;
            endereco.numero = numero;
            endereco.cep = cep;

            login.acesso = acesso;
            login.senha = senha;

           ubussines.inserir(usuario);

            MessageBox.Show("deu certo");

        }
    }
}