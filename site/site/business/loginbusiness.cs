using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace site.business
{
    public class loginbusiness
    {
        database.databaselogin banco = new database.databaselogin();
        public void inserir(model.login login)
        {
            banco.inserir(login);

        }

        public List<model.login> lista()
        {
            List<model.login> lista = banco.lista();
            return lista;

        }
        public void removeradm(string adm)
        {
            banco.removeradm(adm);

        }

        public void removercliente (string cliente)
        {
            banco.removercliente(cliente);

        }


    }
}