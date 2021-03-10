using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sap.Database
{
    class usuario
    {
        Entities.estudoEntities banco = new Entities.estudoEntities();
        public void inserir(Entities.usuario dados)
        {
            banco.usuario.Add(dados);
            banco.SaveChanges();

        }

     

        public Entities.usuario buscar(string nick)
        {
            Entities.usuario lista = banco.usuario.FirstOrDefault(t => t.nick == nick);
            return lista;
        }

        public List<Entities.usuario> btodos()
        {
            List<Entities.usuario> lista = banco.usuario.OrderByDescending(t => t.registro).ToList();
            return lista;
        }

        public List<Entities.usuario> bnick(string nick)
        {
            List<Entities.usuario> lista = banco.usuario.Where(t => t.nick == nick).ToList();
            return lista;

        }

        public void deletar(string nick)
        {
            Entities.usuario lista = banco.usuario.FirstOrDefault(t => t.nick == nick);
            banco.Entry(lista).State = System.Data.Entity.EntityState.Deleted;
            banco.SaveChanges();
        }

        public void alterar(Entities.usuario nick)
        {
            Entities.usuario usuario = banco.usuario.FirstOrDefault(t => t.nick == nick.nick);

            if (usuario != null)
            {
                usuario.cargo = nick.cargo;

                usuario.dt_nascimento = nick.dt_nascimento;

                usuario.foto = nick.foto;
                usuario.idade = nick.idade;

                usuario.nome = nick.nome;
                usuario.registro = nick.registro;
                usuario.nick = nick.nick;

                banco.SaveChanges();
            }

        }
    }
}

