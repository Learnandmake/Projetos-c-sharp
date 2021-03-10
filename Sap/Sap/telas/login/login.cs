using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
