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
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=");
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
        public List<model.administrador> lista()
        {
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=");
            con.Open();

            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"select * from administrador";

            MySqlDataReader reader = comand.ExecuteReader();

            List<model.administrador> lista = new List<model.administrador>();
            while (reader.Read())
            {
                model.administrador model = new model.administrador();
                model.id_adm = Convert.ToString(reader["id_adm"]);
                model.nome = Convert.ToString(reader["nome"]);
                model.departamento = Convert.ToString(reader["departamento"]);
                model.registro = Convert.ToDateTime(reader["registro"]);
     


                lista.Add(model);

            }

            con.Close();
            return lista;

        }

        public void removeradm(string id_adm)
        {
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=");
            con.Open();

            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"delete from administrador
                                 where=@id_adm";
            comand.Parameters.Add(new MySqlParameter("id_adm", id_adm));

            comand.ExecuteNonQuery();
            con.Close();
        }
    }
}