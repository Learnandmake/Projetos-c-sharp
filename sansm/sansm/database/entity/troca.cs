//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sansm.database.entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class troca
    {
        public int idtroca { get; set; }
        public string razao { get; set; }
        public Nullable<int> idprodutodevolvido { get; set; }
        public Nullable<System.DateTime> registro { get; set; }
        public string idcliente { get; set; }
        public Nullable<int> idproduto { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual produto produto { get; set; }
    }
}
