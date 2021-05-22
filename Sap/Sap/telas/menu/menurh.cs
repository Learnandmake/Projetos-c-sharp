using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.IO;

namespace Sap.telas.menu
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();

        }

        private string city;

        public principal(string nick)
        {
            InitializeComponent();
           lblusuario.Text=  nick;

            city = Functions.localization.GetCityname(Functions.executer.GetIp()).ToLower();

            Functions.executer m = new Functions.executer();

            string graus = m.Getgraus(city);
            lbltemperatura.Text = graus + " " + "°C";

            Bussines.usuario usuario = new Bussines.usuario();

            Database.Entities.usuario usuariodata = new Database.Entities.usuario();

            usuariodata = usuario.busca(nick);

            byte[] image = ((byte[])(usuariodata.foto));
            MemoryStream ms = new MemoryStream(image);
            picfoto.Image = System.Drawing.Image.FromStream(ms);
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();
          
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

                    using (MySqlBackup back = new MySqlBackup (cmd))
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

        private void picfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = (DateTime.Now.ToString("HH:mm:ss"));

        }

        private void picadd_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<usuario.cadastro>();
        }

        private void picsearch_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<usuario.consulta>();
        }
    }
    }