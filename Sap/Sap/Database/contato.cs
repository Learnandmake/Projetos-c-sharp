using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sap.Database
{
    class contato
    {
        Entities.estudoEntities banco = new Entities.estudoEntities();
        public void inserir(Entities.contato dados)
        {
            banco.contato.Add(dados);
            banco.SaveChanges();

        }

        public Entities.contato buscar(string nick)
        {
            Entities.contato lista = banco.contato.FirstOrDefault(t => t.nick == nick);
            return lista;
        }

        public List<Entities.contato> btodos()
        {
            List<Entities.contato> lista = banco.contato.ToList();
            return lista;
        }

        public List<Entities.contato> bnick(string nick)
        {
            List<Entities.contato> lista = banco.contato.Where(t => t.nick == nick).ToList();
            return lista;

        }

        public void deletar(string nick)
        {
            Entities.contato lista = banco.contato.FirstOrDefault(t => t.nick == nick);
            banco.Entry(lista).State = System.Data.Entity.EntityState.Deleted;
            banco.SaveChanges();
        }

        public void alterar(Entities.contato nick)
        {
            Entities.contato contato = banco.contato.FirstOrDefault(t => t.nick == nick.nick);

            if (contato != null)
            {
                contato.email = nick.email;
                contato.telefonecel = nick.telefonecel;
                contato.telefonere = nick.telefonere;
                contato.nick = nick.nick;
                contato.usuario = contato.usuario;
                banco.SaveChanges();
            }

        }
    }

}