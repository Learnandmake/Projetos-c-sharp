using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
namespace site.database
{
    public class databaselogin
    { public void inserir (model.login login)
        {
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=1234");
            con.Open();


            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"insert into login(id_login,id_adm,senha,acesso,id_pessoal)
                                  values(@id_login,@id_adm,@senha,@acesso,@id_pessoal)";

            comand.Parameters.Add(new MySqlParameter("id_login", login.id_login));
            comand.Parameters.Add(new MySqlParameter("id_adm", login.id_adm));
            comand.Parameters.Add(new MySqlParameter("senha", login.senha));
            comand.Parameters.Add(new MySqlParameter("acesso", login.acesso));
            comand.Parameters.Add(new MySqlParameter("id_pessoal", login.id_pessoal));

      

            comand.ExecuteNonQuery();
            con.Close();


        }

        public List<model.login> lista()
        {
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=");
            con.Open();

            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"select * from login";

            MySqlDataReader reader = comand.ExecuteReader();

            List<model.login> lista = new List<model.login>();
            while (reader.Read())
            {
                model.login model = new site.model.login();
                model.id_pessoal = Convert.ToString(reader["id_pessoal"]);
                model.id_login = Convert.ToInt32(reader["id_login"]);
                model.id_adm = Convert.ToString(reader["id_adm"]);
                model.senha = Convert.ToString(reader["senha"]);
                model.acesso =  Convert.ToString(reader["acesso"]);
               

                lista.Add(model);

            }

            con.Close();
            return lista;

        }

    }
}