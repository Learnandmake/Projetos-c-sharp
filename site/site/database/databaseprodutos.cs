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
            MySqlConnection con = new MySqlConnection("server=LocalHost;database=site;user=root;pwd=1234");
            con.Open();


            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @"insert into login(id_produto,nome,fornecedor,qtd_estoque,qtd_venda,preco,foto,dt_compra)
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
    }
}