using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace site.model
{
    public class cliente
    { public string id_pessoal { get; set; }
      public string nome { get; set; }
      public int idade { get; set; }
      public string sexo { get; set; }
      public DateTime nascimento { get; set; }
      public byte[] foto { get; set; }
      public DateTime registro { get; set; }

      }
}