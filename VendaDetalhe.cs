//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEB_API_TAREFAS
{
    using System;
    using System.Collections.Generic;
    
    public partial class VendaDetalhe
    {
        public int VendaRegistroId { get; set; }
        public int ProdutoId { get; set; }
        public int Qtd { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
        public bool Ativo { get; set; }
    
        public virtual Produto Produto { get; set; }
        public virtual VendaRegistro VendaRegistro { get; set; }
    }
}
