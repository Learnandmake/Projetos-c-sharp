using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace site.database
{
    public class databasevenda
    {
        public void inserir(model.venda venda)
        {
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;user=root;pwd=1234");
            con.Open();


            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"insert into venda(id_venda,id_pessoal,id_produto,registro)
                                  values(@id_produto,@id_venda,@id_pessoal,@id_produto,@registro)";

            comand.Parameters.Add(new MySqlParameter("id_venda", venda.id_venda));
            comand.Parameters.Add(new MySqlParameter("id_pessoal", venda.id_pessoal));
            comand.Parameters.Add(new MySqlParameter("id_produto", venda.id_produto));
            comand.Parameters.Add(new MySqlParameter("registro", venda.registro));
            comand.ExecuteNonQuery();
            con.Close();
        }
}