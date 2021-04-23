using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Collections;

namespace Sap.telas.Email
{
    public partial class enviar : Form
    {
        public enviar()
        {
            InitializeComponent();
        }

        private void picenviar_Click(object sender, EventArgs e)
        {
            ArrayList aAnexosEmail;

            if (String.IsNullOrEmpty(txtpara.Text))
            {
                MessageBox.Show("Endereço de email do destinatário inválido.", "Erro ");
                return;
            }
            if (String.IsNullOrEmpty(txtde.Text))
            {
                MessageBox.Show("Endereço de email do remetente inválido.", "Erro ");
                return;
            }
            if (String.IsNullOrEmpty(txtassunto.Text))
            {
                MessageBox.Show("Definição do assunto inválida.", "Erro ");
                return;
            }
            if (String.IsNullOrEmpty(txtmessage.Text))
            {
                MessageBox.Show("Mensagem inválida.", "Erro ");
                return;
            }

            string destinatario = Convert.ToString (txtpara.Text);
            string remetente = Convert.ToString(txtde.Text);
            string assunto = Convert.ToString(txtassunto.Text);
            string mensagem = Convert.ToString( txtmessage.Text);

            string[] arr = txtanexar.Text.Split(';');
          
            aAnexosEmail = new ArrayList();

            for (int i = 0; i < arr.Length; i++)
            {
            if(!String.IsNullOrEmpty(arr[i].ToString().Trim()))
                {
                    aAnexosEmail.Add(arr[i].ToString().Trim());
                }
            }


            if(aAnexosEmail.Count>0)
            {
                string resultado = Functions.enviaremail.enviar(destinatario, remetente, assunto, mensagem, aAnexosEmail);
                MessageBox.Show("Email enviado com sucesso");

            }

            else
            {
                string resultado = Functions.enviaremail.enviarsemanexo(destinatario, remetente, assunto, mensagem);
                MessageBox.Show("Email enviado com sucesso");

            }



        }

        private void picanexar_Click(object sender, EventArgs e)
        {
          if(ofd1.ShowDialog()==DialogResult.OK)
          {
                try
                {
                    ArrayList aAnexosEmail;
                    string[] arr = ofd1.FileNames;
                    aAnexosEmail = new ArrayList();
                    txtanexar.Text = string.Empty;
                    aAnexosEmail.AddRange(arr);

                    foreach (string s in aAnexosEmail)
                    {
                        txtanexar.Text += ";";
                    }

                }

                catch(Exception)
                { MessageBox.Show("error"); }


          }
        }
    }
}
