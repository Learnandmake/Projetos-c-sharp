using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace site.model
{
    public class venda
    {
    public int id_venda { get; set; }
    public string  id_pessoal { get; set; }
    public int id_produto { get; set; }
    public DateTime registro { get; set; }
    }
}