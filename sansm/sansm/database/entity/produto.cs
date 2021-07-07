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
    
    public partial class produto
    {
        public produto()
        {
            this.estoque = new HashSet<estoque>();
            this.fornecedor = new HashSet<fornecedor>();
            this.troca = new HashSet<troca>();
            this.venda = new HashSet<venda>();
        }
    
        public int idproduto { get; set; }
        public string nome { get; set; }
        public string tipo { get; set; }
        public byte[] foto { get; set; }
        public Nullable<int> qtd { get; set; }
        public Nullable<System.DateTime> registro { get; set; }
    
        public virtual ICollection<estoque> estoque { get; set; }
        public virtual ICollection<fornecedor> fornecedor { get; set; }
        public virtual ICollection<troca> troca { get; set; }
        public virtual ICollection<venda> venda { get; set; }
    }
}