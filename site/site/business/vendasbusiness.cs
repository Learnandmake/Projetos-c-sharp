using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace site.business
{
    public class vendasbusiness
    {
        database.databasevenda banco = new database.databasevenda();
    public void inserir (model.venda venda)
    {
            banco.inserir(venda);
   
    }

    public List<model.venda> listar ()
    {
            List<model.venda> lista = banco.listar();
            return lista;

    }
    
    
    }
}