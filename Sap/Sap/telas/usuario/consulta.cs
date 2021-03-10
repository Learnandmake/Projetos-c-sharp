using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
