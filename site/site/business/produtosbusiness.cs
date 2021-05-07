using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace site.business
{
    public class produtosbusiness
    {
        database.databaseprodutos banco = new database.databaseprodutos();
        public void inserir(model.produto produto)
        {
            banco.inserir(produto);

        }

        public List<model.produto> listar()
        {
            List<model.produto> lista = banco.lista();
            return lista;

        }

        public void removerproduto(int id)
        {
            banco.removerproduto(id);

        }

    }
}