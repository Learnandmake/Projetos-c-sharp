using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sap.Database
{
    class endereco
    {
        Database.Entities.estudoEntities banco = new  Database.Entities.estudoEntities();


        public void inserir(Entities.endereco dados)
        {
            banco.endereco.Add(dados);
            banco.SaveChanges();

        }
        public void deletar(string nick)
        {
            Entities.endereco lista = banco.endereco.FirstOrDefault(t => t.nick == nick);
            banco.Entry(lista).State = System.Data.Entity.EntityState.Deleted;
            banco.SaveChanges();
        }

        public void alterar(Entities.endereco  nick)
        {
            Entities.endereco  endereco = banco.endereco.FirstOrDefault(t => t.nick == nick.nick);

            if (endereco != null)
            {
                endereco.cep = nick.cep;
                endereco.complemento1 = nick.complemento1;
                endereco.id = endereco.id;
                endereco.numero = nick.numero;
                endereco.rua = nick.rua;
                endereco.nick = nick.nick;
                endereco.nick = endereco.nick;
                endereco.usuario = endereco.usuario;

                banco.SaveChanges();
            }
        }
        public Entities.endereco  buscar(string nick)
        {
            Entities.endereco  lista = banco.endereco.FirstOrDefault(t => t.nick == nick);
            return lista;


        }
    }
}
