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
    
    public partial class patrimonio
    {
        public int idpatrimonio { get; set; }
        public string tipo { get; set; }
        public string mlcarro { get; set; }
        public string placa { get; set; }
        public string mlequipamento { get; set; }
        public string mlmateria { get; set; }
        public string mlmovel { get; set; }
        public Nullable<int> idfornecedor { get; set; }
        public Nullable<int> idendereco { get; set; }
        public Nullable<int> idcontato { get; set; }
    
        public virtual contato contato { get; set; }
        public virtual endereco endereco { get; set; }
        public virtual fornecedor fornecedor { get; set; }
    }
}
