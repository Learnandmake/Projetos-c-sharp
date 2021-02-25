using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sap.Bussines
{
    class usuario
    {

        Database.usuario banco = new Database.usuario();
        public void inserir(Database.Entities.usuario dados)
       {
            
            banco.inserir(dados);
            if (dados.nick == string.Empty)
            { throw new Exception("confira seu formulario"); }
        }
        public List<Database.Entities.usuario> btodos()
        {
            List<Database.Entities.usuario> lista = banco.btodos();
            return lista;

        }
        public List<Database.Entities.usuario> bnick(string nick)
        {
            List<Database.Entities.usuario> lista = banco.bnick(nick);
            return lista;
        }

        public void delete(string nick)
        {
            banco.deletar(nick);
        }

        public void alterar(Database.Entities.usuario dados)
        {
            banco.alterar(dados);
            if (dados == null)
            { throw new Exception("erro, por favor verifique seu formulario"); }

        }

        public
        Database.Entities.usuario busca(string nick)
        {

            Database.Entities.usuario lista = banco.buscar(nick);
            return lista;
        }

    }
}
