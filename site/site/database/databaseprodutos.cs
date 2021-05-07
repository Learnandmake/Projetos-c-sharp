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
            comand.CommandText = @"insert into produto(id_produto,nome,fornecedor,qtd_estoque,qtd_venda,preco,foto,dt_compra)
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
            comand.CommandText = @"select * from produto";

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

        public void alterarproduto(model.produto produto)
        {
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=");
            con.Open();

            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"update produto
                                   set id_produto = @id_produto,
                                   fornecedor = @fornecedor,
                                  qtd_estoque = @qtd_estoque,
                                    qtd_venda = @qtd_venda,
                                    preco = @preco,
                                    foto = @foto,
                                    dt_compra = @dt_compra
                                    
                                    where id_produto = @id_produto";

            comand.Parameters.Add(new MySqlParameter("id_produto", produto.id_produto));
            comand.Parameters.Add(new MySqlParameter("fornecedor", produto.fornecedor));
            comand.Parameters.Add(new MySqlParameter("qtd_estoque",produto.qtd_estoque));
            comand.Parameters.Add(new MySqlParameter("qtd_venda", produto.qtd_venda));
            comand.Parameters.Add(new MySqlParameter("preco", produto.preco));
            comand.Parameters.Add(new MySqlParameter("foto", produto.foto));
            comand.Parameters.Add(new MySqlParameter("dt_compra", produto.dt_compra));

            comand.ExecuteNonQuery();
            con.Close();

        }

        public void removerproduto (int id)
        {
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;uid=root;pwd=");
            con.Open();

            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"delete from produto
                                 where=@id_produto";
            comand.Parameters.Add(new MySqlParameter("id_produto", id));

            comand.ExecuteNonQuery();
            con.Close();

        }

       
    }
}