using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sap.Bussines
{
    class agenda
    {
        Database.agenda banco = new Database.agenda();
        public void inserir(Database.Entities.agenda dados)
        {

            banco.inserir(dados);
            if (dados.nick == string.Empty)
            { throw new Exception("confira seu formulario"); }
        }
        public List<Database.Entities.agenda> btodos()
        {
            List< Database.Entities.agenda > lista = banco.btodos();
            return lista;

        }
        public List<Database.Entities.agenda> bnick(string nick)
        {
            List<Database.Entities.agenda> lista = banco.bnick(nick);
            return lista;
        }

        public void delete(string nick)
        {
            banco.deletar(nick);
        }

        public void alterar(Database.Entities.agenda dados)
        {
            banco.alterar(dados);
            if (dados == null)
            { throw new Exception("erro, por favor verifique seu formulario"); }

        }

        public Database.Entities.agenda busca(string nick)
        {
            Database.Entities.agenda lista = banco.buscar(nick);
            return lista;
        }


    }
}
