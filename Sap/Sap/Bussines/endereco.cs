using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sap.Bussines
{
    class endereco
    {
        Database.endereco banco = new Database.endereco();
        public void inserir(Database.Entities.endereco dados)
        {

            banco.inserir(dados);
            if (dados.nick == string.Empty)
            { throw new Exception("confira seu formulario"); }
        }
    
        public Database.Entities.endereco bnick(string nick)
        {
            Database.Entities.endereco lista = banco.buscar(nick);
            return lista;
        }

        public void delete(string nick)
        {
            banco.deletar(nick);
        }

        public void alterar(Database.Entities.endereco dados)
        {
            banco.alterar(dados);
            if (dados == null)
            { throw new Exception("erro, por favor verifique seu formulario"); }

        }

        public Database.Entities.endereco busca(string nick)
        {
            Database.Entities.endereco lista = banco.buscar(nick);
            return lista;
        }


    }
}
