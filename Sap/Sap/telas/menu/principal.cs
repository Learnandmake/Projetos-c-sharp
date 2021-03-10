using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sap.telas.menu
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        public principal(string nick )
        {
            InitializeComponent();
        }

        private void picadd_Click(object sender, EventArgs e)
        {
            AbrirFormulario < usuario.cadastro>();
        }

        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
           
    }
       
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form1"] == null)
              picadd.BackColor = Color.FromArgb(4, 41, 68);
           
        }

        private void picsearch_Click(object sender, EventArgs e)
        {
            AbrirFormulario<usuario.consulta>();
        }

        private void picrestore_Click(object sender, EventArgs e)
        {
            string file = "C:\\backupestudo.sql";
            string conection = "server=LocalHost;PORT=3306;user=root;pwd= ;database=estudo; Convert Zero Datetime=True;";
            using (MySqlConnection con = new MySqlConnection(conection))

            {
                using (MySqlCommand cmd = new MySqlCommand())
                {

                    using (MySqlBackup back = new MySqlBackup())
                    {
                        cmd.Connection = con;
                        con.Open();

                        back.ImportFromFile(file);
                        con.Close();

                        MessageBox.Show("complete!!");

                    }
                }
    }
}

        private void picbackup_Click(object sender, EventArgs e)
        {
            //backup
            string file = "C:\\backupestudo.sql";
            string conection = "server=LocalHost;PORT=3306;user=root;pwd= ;database=estudo; Convert Zero Datetime=True;";
            using (MySqlConnection con = new MySqlConnection(conection))

            {
                using (MySqlCommand cmd = new MySqlCommand())
                {

                    using (MySqlBackup back = new MySqlBackup(cmd))
                    {
                        cmd.Connection = con;
                        con.Open();

                        back.ExportToFile(file);
                        con.Close();

                        MessageBox.Show("complete!!");

                    }
                }


            }


        }