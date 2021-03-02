using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sap.Functions
{
    class verificar
    {  //calcular idade
        public int calcularidade(DateTime nascimento)
        {
            int idade = DateTime.Now.Year - nascimento.Year;
            if (DateTime.Now.DayOfYear < nascimento.DayOfYear)
            {
                idade--;

            }
            return idade;
        }

    }
}
