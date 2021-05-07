using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace site.model
{
    public class administrador
    {public string id_adm { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string sexo { get; set; }
        public DateTime nascimento { get; set; }
        public byte foto { get; set; }
        public string departamento { get; set; }
    public DateTime registro { get; set; }
    }
}