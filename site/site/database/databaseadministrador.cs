using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
namespace site.database
{
    public class databaseadministrador
    { public void inserir(model.administrador adm)
        {
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=1234");
            con.Open();


            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"insert into administrador(id_adm,nome,departamento,registro)
                                  values(@id_adm,@nome,@departamento,@registro)";

            comand.Parameters.Add(new MySqlParameter("id_adm", adm.id_adm));
            comand.Parameters.Add(new MySqlParameter("nome", adm.nome));
            comand.Parameters.Add(new MySqlParameter("departamento", adm.departamento));   
            comand.Parameters.Add(new MySqlParameter("registro", adm.registro));

            comand.ExecuteNonQuery();
            con.Close();

        }
    }
}