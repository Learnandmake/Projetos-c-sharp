using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace site.database
{
    public class databaseprodutos
    {
        public void inserir(model.produto produtos)
        {
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=");
            con.Open();


            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"insert into produtos(id_produto,nome,fornecedor,qtd_estoque,qtd_venda,preco,foto,dt_compra)
                                  values(@id_produto,@nome,@fornecedor,@qtd_estoque,@qtd_venda,@preco,@foto,@dt_compra)";

            comand.Parameters.Add(new MySqlParameter("id_produto", produtos.id_produto));
            comand.Parameters.Add(new MySqlParameter("nome", produtos.nome));
            comand.Parameters.Add(new MySqlParameter("fornecedor", produtos.fornecedor));
            comand.Parameters.Add(new MySqlParameter("qtd_estoque", produtos.qtd_estoque));
            comand.Parameters.Add(new MySqlParameter("qtd_venda", produtos.qtd_venda));
            comand.Parameters.Add(new MySqlParameter("preco", produtos.preco));
            comand.Parameters.Add(new MySqlParameter("foto", produtos.foto));
            comand.Parameters.Add(new MySqlParameter("dt_compra", produtos.dt_compra));

            comand.ExecuteNonQuery();
            con.Close();


        }

        public List<model.produto> lista()
        {
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=");
            con.Open();

            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"select * from produtos";

            MySqlDataReader reader = comand.ExecuteReader();

            List<model.produto> lista = new List<model.produto> ();
            while (reader.Read())
            {
                model.produto  model = new site.model.produto ();
                model.id_produto = Convert.ToInt32(reader["id_produto"]);
                model.fornecedor = Convert.ToString(reader["fornecedor"]);
                model.qtd_estoque = Convert.ToInt32(reader["qtd_estoque"]);
                model.qtd_venda = Convert.ToInt32(reader["qtd_venda"]);
                model.preco = Convert.ToDecimal(reader["preco"]);
                model.foto = Convert.ToByte(reader["foto"]);
                model.dt_compra = Convert.ToDateTime(reader["dt_compra"]);

                lista.Add(model);

            }

            con.Close();
            return lista;

        }

    }
}