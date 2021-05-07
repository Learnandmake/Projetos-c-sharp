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
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=");
            con.Open();


            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"insert into venda(id_venda,id_pessoal,id_produto,registro)
                                  values(@id_venda,@id_pessoal,@id_produto,@registro)";

            comand.Parameters.Add(new MySqlParameter("id_venda", venda.id_venda));
            comand.Parameters.Add(new MySqlParameter("id_pessoal", venda.id_pessoal));
            comand.Parameters.Add(new MySqlParameter("id_produto", venda.id_produto));
            comand.Parameters.Add(new MySqlParameter("registro", venda.registro));
            comand.ExecuteNonQuery();
            con.Close();
        }

        public List <model.venda> listar ()
        {
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=");
            con.Open();

            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"select * from venda";

            MySqlDataReader reader = comand.ExecuteReader();

            List<model.venda> lista = new List<model.venda>();
            while(reader.Read())
            {
                model.venda model = new site.model.venda();
                model.id_pessoal = Convert.ToString(reader["id_pessoal"]);
                model.id_produto = Convert.ToInt32( reader["id_produto"]);
                model.id_venda = Convert.ToInt32( reader["id_venda"]);
                model.registro = Convert.ToDateTime(reader["registro"]);

                lista.Add(model);
            }
            con.Close();

            return lista;
        }
      
          public void removervenda(int id_venda)
        {
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=");
            con.Open();

            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"delete from venda
                                 where=@id_venda";
            comand.Parameters.Add(new MySqlParameter("id_venda", id_venda));

            comand.ExecuteNonQuery();
            con.Close();
        }


        public void alterar(model.venda venda)
        {
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=");
            con.Open();


            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"update venda
                                         set id_venda = @id_venda,
                                         id_pessoal = @id_pessoal,
                                         id_produto = @id_produto
                                         registro = @registro
                                         where id_venda = @id_venda";

            comand.Parameters.Add(new MySqlParameter("id_venda", venda.id_venda));
            comand.Parameters.Add(new MySqlParameter("id_pessoal", venda.id_pessoal));
            comand.Parameters.Add(new MySqlParameter("id_produto", venda.id_produto));
            comand.Parameters.Add(new MySqlParameter("registro", venda.registro));
            comand.ExecuteNonQuery();
            con.Close();
        }
    }
}