using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace site.business
{
    public class administradorbusiness
    {
        database.databaseadministrador banco = new database.databaseadministrador();
        public void inserir(model.administrador adm)
        {
            banco.inserir(adm);

        }

        public List<model.administrador> listar()
        {
            List<model.administrador> lista = banco.lista();
            return lista;

        }

        public void delete (string id_adm)
        {
            banco.remover(id_adm);

        }

        public void alterar(model.administrador adm)
        {
            banco.alterar(adm);

        }
    }
}