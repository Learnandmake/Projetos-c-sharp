using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sap.Bussines
{
    class login
    {
        Database.login banco = new Database.login();
       
        public int vlogin (string nick, string senha)
        {
          int count=  banco.vlogin(nick, senha);
            return count;
          }
         public void inserir(Database.Entities.login dados)
        {
            banco.inserir(dados);
            if (dados.nick == string.Empty)
            { throw new Exception("confira seu formulario"); }
        }
        public List<Database.Entities.login> btodos()
        {
            List<Database.Entities.login> lista = banco.btodos();
            return lista;

        }
        public List<Database.Entities.login> bnick(string nick)
        {
            List<Database.Entities.login> lista = banco.bnick(nick);
            return lista;
        }

        public void delete(string nick)
        {
            banco.deletar(nick);
        }

        public void alterar(Database.Entities.login dados)
        {
            banco.alterar(dados);
            if (dados == null)
            { throw new Exception("erro, por favor verifique seu formulario"); }

        }

        public Database.Entities.login busca(string nick)
        {
            Database.Entities.login lista = banco.buscar(nick);
            return lista;
        }
    }
}
