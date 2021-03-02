using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sap.Bussines
{
    class contato1
    { 
        Database.contato banco = new Database.contato();
        public void inserir(Database.Entities.contato dados)
        {

            banco.inserir(dados);
            if (dados.nick == string.Empty)
            { throw new Exception("confira seu formulario"); }
        }
        public List<Database.Entities.contato> btodos()
        {
            List<Database.Entities.contato> lista = banco.btodos();
            return lista;

        }
        public List<Database.Entities.contato> bnick(string nick)
        {
            List<Database.Entities.contato> lista = banco.bnick(nick);
            return lista;
        }

        public void delete(string nick)
        {
            banco.deletar(nick);
        }

        public void alterar(Database.Entities.contato dados)
        {
            banco.alterar(dados);
            if (dados == null)
            { throw new Exception("erro, por favor verifique seu formulario"); }

        }

        public Database.Entities.contato busca(string nick)
        {
            Database.Entities.contato lista = banco.buscar(nick);
            return lista;
        }
    }
}
