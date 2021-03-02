using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sap.Database
{
    class login
    {
        Entities.estudoEntities banco = new Entities.estudoEntities();
        public void inserir(Entities.login dados)
        {
            banco.login.Add(dados);
            banco.SaveChanges();

        }

        public Entities.login buscar(string nick)
        {
            Entities.login lista = banco.login.FirstOrDefault(t => t.nick == nick);
            return lista;
        }

        public List<Entities.login> btodos()
        {
            List<Entities.login> lista = banco.login.ToList();
            return lista;
        }

        public List<Entities.login> bnick(string nick)
        {
            List<Entities.login> lista = banco.login.Where(t => t.nick == nick).ToList();
            return lista;

        }

        public void deletar(string nick)
        {
            Entities.login lista = banco.login.FirstOrDefault(t => t.nick == nick);
            banco.Entry(lista).State = System.Data.Entity.EntityState.Deleted;
            banco.SaveChanges();
        }

        public void alterar(Entities.login nick)
        {
            Entities.login login = banco.login.FirstOrDefault(t => t.nick == nick.nick);

            if (login != null)
            {
                login.acesso = nick.acesso;
                login.senha = nick.senha;
                login.nick = nick.nick;

                banco.SaveChanges();
            }

        }
    }
}

