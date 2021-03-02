using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sap.Database
{
    class pesquisa
    {
        Entities.estudoEntities banco = new Entities.estudoEntities();
        public void inserir(Entities.pesquisa dados)
        {
            banco.pesquisa.Add(dados);
            banco.SaveChanges();

        }

        public Entities.pesquisa buscar(string nick)
        {
            Entities.pesquisa lista = banco.pesquisa.FirstOrDefault(t => t.nick == nick);
            return lista;
        }

        public List<Entities.pesquisa> btodos()
        {
            List<Entities.pesquisa> lista = banco.pesquisa.ToList();
            return lista;
        }

        public List<Entities.pesquisa> bnick(string nick)
        {
            List<Entities.pesquisa> lista = banco.pesquisa.Where(t => t.nick == nick).ToList();
            return lista;

        }

        public void deletar(string nick)
        {
            Entities.pesquisa lista = banco.pesquisa.FirstOrDefault(t => t.nick == nick);
            banco.Entry(lista).State = System.Data.Entity.EntityState.Deleted;
            banco.SaveChanges();
        }

        public void alterar(Entities.pesquisa nick)
        {
            Entities.pesquisa pesquisa = banco.pesquisa.FirstOrDefault(t => t.nick == nick.nick);

            if (pesquisa != null)
            {
                pesquisa.navegador = nick.navegador;
                pesquisa.nick = nick.nick;
                pesquisa.registro = nick.registro;
                pesquisa.url = nick.url;
                pesquisa.usuario = pesquisa.usuario;

                banco.SaveChanges();
            }

        }
    }
}
