using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
namespace site.database
{
    public class databasecliente
    {
        public void inserir(model.cliente cliente)
        {
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=1234");
            con.Open();

            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"insert into cliente(id_pessoal,nome,idade,sexo,dt_nascimento,foto,registro)
                                  values(@id_pessoal,@nome,@idade,@sexo,@dt_nascimento,@foto,@registro)";

            comand.Parameters.Add(new MySqlParameter("id_pessoal", cliente.id_pessoal));
            comand.Parameters.Add(new MySqlParameter("nome", cliente.nome));
            comand.Parameters.Add(new MySqlParameter("idade", cliente.idade));
            comand.Parameters.Add(new MySqlParameter("sexo", cliente.sexo));
            comand.Parameters.Add(new MySqlParameter("dt_nascimento", cliente.nascimento));
            comand.Parameters.Add(new MySqlParameter("foto", cliente.foto));
            comand.Parameters.Add(new MySqlParameter("registro", cliente.registro));

            comand.ExecuteNonQuery();
            con.Close();

        }



          }
}