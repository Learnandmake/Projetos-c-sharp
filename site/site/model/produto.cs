using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace site.model
{
    public class produto
    { public int id_produto { get; set; }
      public string nome { get; set; }
      public string fornecedor { get; set; }
      public int qtd_estoque { get; set; }
      public int qtd_venda { get; set; }
      public decimal preco { get; set; }
      public byte foto { get; set; }
      public DateTime dt_compra { get; set; }


    }
}