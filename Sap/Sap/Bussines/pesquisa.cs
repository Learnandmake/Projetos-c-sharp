using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sap.Bussines
{
    class pesquisa
    {
        Database.pesquisa banco = new Database.pesquisa();
        public void inserir(Database.Entities.pesquisa dados)
        {

            banco.inserir(dados);
            if (dados.nick == string.Empty)
            { throw new Exception("confira seu formulario"); }
        }
        public List<Database.Entities.pesquisa> btodos()
        {
            List<Database.Entities.pesquisa> lista = banco.btodos();
            return lista;

        }
        public List<Database.Entities.pesquisa > bnick(string nick)
        {
            List<Database.Entities.pesquisa> lista = banco.bnick(nick);
            return lista;
        }

        public void delete(string nick)
        {
            banco.deletar(nick);
        }

        public void alterar(Database.Entities.pesquisa dados)
        {
            banco.alterar(dados);
            if (dados == null)
            { throw new Exception("erro, por favor verifique seu formulario"); }

        }

        public Database.Entities.pesquisa busca(string nick)
        {
            Database.Entities.pesquisa  lista = banco.buscar(nick);
            return lista;
        }
    }
}
