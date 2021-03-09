using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sap.Functions
{
    class verificar
    {
       
        //calcular idade
        public int calcularidade(DateTime nascimento)
        {
            int idade = DateTime.Now.Year - nascimento.Year;
            if (DateTime.Now.DayOfYear < nascimento.DayOfYear)
            {
                idade--;

            }
            return idade;
        }
        public bool controlenumerico (string nusuario)//numero
        {
            int numero = 0;
            bool teste = int.TryParse(nusuario, out numero);
            return teste;
        }
       
     
        //verificacao de  idade 
        public bool verificaridade(DateTime dt_nascimento)
        {
            int idade = DateTime.Now.Year - dt_nascimento.Year;
            bool ok = false;
            if (DateTime.Now.DayOfYear < dt_nascimento.DayOfYear)
            {
                idade--;


                if (idade < 18)
                {
                    ok = false;

                }
            }
            if (idade >= 18)
            {
                ok = true;

            }
            return ok;
        }
       
        
         public bool isemail(string strEmail)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}
