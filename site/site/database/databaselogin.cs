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
    }
}