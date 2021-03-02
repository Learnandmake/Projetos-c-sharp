using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sap.Database
{
    class agenda
    {
        Entities.estudoEntities banco = new Entities.estudoEntities();
        public void inserir(Entities.agenda dados)
        {
            banco.agenda.Add(dados);
            banco.SaveChanges();

        }

        public Entities.agenda buscar(string nick)
        {
            Entities.agenda lista = banco.agenda.FirstOrDefault(t => t.nick == nick);
            return lista;
        }

        public List<Entities.agenda> btodos()
        {
            List<Entities.agenda> lista = banco.agenda.ToList();
            return lista;
        }

        public List<Entities.agenda> bnick(string nick)
        {
            List<Entities.agenda> lista = banco.agenda.Where(t => t.nick == nick).ToList();
            return lista;

        }

        public void deletar(string nick)
        {
            Entities.agenda lista = banco.agenda.FirstOrDefault(t => t.nick == nick);
            banco.Entry(lista).State = System.Data.Entity.EntityState.Deleted;
            banco.SaveChanges();
        }

        public void alterar(Entities.agenda nick)
        {
            Entities.agenda agenda = banco.agenda.FirstOrDefault(t => t.nick == nick.nick);

            if (agenda != null)
            {
                agenda.nick = nick.nick;
                agenda.registro = nick.registro;
                agenda.texto = nick.texto;
                agenda.titulo = nick.titulo;
                agenda.dt = nick.dt;
                agenda.usuario = agenda.usuario;

                banco.SaveChanges();
            }

        }
    }
}
