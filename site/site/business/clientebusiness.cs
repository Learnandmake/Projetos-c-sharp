using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace site.business
{
    public class clientebusiness
    {
        database.databasecliente banco = new database.databasecliente();
        public void inserir(model.cliente cliente)
        {
            banco.inserir(cliente);

        }

        public List<model.cliente> listar()
        {
            List<model.cliente> lista = banco.lista();
            return lista;

        }

        public void delete (string cliente)
        {
            banco.removercliente(cliente);

        }


    }
}