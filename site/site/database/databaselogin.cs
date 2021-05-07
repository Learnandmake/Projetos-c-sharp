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
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=");
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


        public List<model.login> loginadm(string id_adm, string senha)
        {
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=");
            con.Open();

            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"select * from login where id_adm = @id_adm and senha = @senha ";

            comand.Parameters.Add(new MySqlParameter("id_adm", id_adm));
            comand.Parameters.Add(new MySqlParameter("senha", senha));

            MySqlDataReader reader = comand.ExecuteReader();

            List<model.login> lista = new List<model.login>();
            while (reader.Read())
            {
                model.login model = new site.model.login();

                model.acesso = Convert.ToString(reader["acesso"]);


                lista.Add(model);

            }

            con.Close();
            return lista;

        }

        public List<model.login> logincliente(string id_pessoal, string senha)
        {
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=");
            con.Open();

            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"select acesso from login where id_pessoal = @id_pessoal and senha = @senha ";

            comand.Parameters.Add(new MySqlParameter("id_pessoal", id_pessoal));
            comand.Parameters.Add(new MySqlParameter("senha", senha));

            MySqlDataReader reader = comand.ExecuteReader();

            List<model.login> lista = new List<model.login>();
            while (reader.Read())
            {
                model.login model = new site.model.login();
               
                model.acesso = Convert.ToString(reader["acesso"]);


                lista.Add(model);

            }

            con.Close();
            return lista;

        }
        
        public void alterarladm (model.login login)
        {
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=");
            con.Open();

            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"update login 
                                   set id_adm = @id_adm,
                                       senha= @senha,
                                       acesso=@acesso
                                        where id_adm = @id_adm";

            comand.Parameters.Add(new MySqlParameter ("id_adm", login.id_adm));
            comand.Parameters.Add(new MySqlParameter ("senha", login.senha));
            comand.Parameters.Add(new MySqlParameter ("acesso", login.acesso));

            comand.ExecuteNonQuery();
            con.Close();

        }
     
           public void alterarlcliente(model.login login)
        {
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=");
            con.Open();

            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"update login 
                                   set id_pessoal = @id_pessoal,
                                       senha= @senha,
                                       acesso=@acesso
                                        where id_pessoal = @id_pessoa";

            comand.Parameters.Add(new MySqlParameter("id_pessoal", login.id_pessoal));
            comand.Parameters.Add(new MySqlParameter("senha", login.senha));
            comand.Parameters.Add(new MySqlParameter("acesso", login.acesso));

            comand.ExecuteNonQuery();
            con.Close();

        }

        public void removeradm (string id_adm )
        {
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=");
            con.Open();

            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"delete from login 
                                 where=@id_adm";
            comand.Parameters.Add(new MySqlParameter("id_adm", id_adm));

            comand.ExecuteNonQuery();
            con.Close();
        }

        public void removercliente ( string id_pessoal)
        {
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=");
            con.Open();

            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"delete from login 
                                 where=@id_pessoal";

            comand.Parameters.Add(new MySqlParameter("id_pessoal", id_pessoal));
        
            comand.ExecuteNonQuery();
            con.Close();

        }
    }
}