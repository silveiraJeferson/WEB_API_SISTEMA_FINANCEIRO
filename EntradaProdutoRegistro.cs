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
    
    public partial class EntradaProdutoRegistro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EntradaProdutoRegistro()
        {
            this.EntradaProdutoDetalhe = new HashSet<EntradaProdutoDetalhe>();
        }
    
        public int Id { get; set; }
        public System.DateTime DataEntrada { get; set; }
        public decimal ValorTotal { get; set; }
        public bool Ativo { get; set; }
        public int FornecedorId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntradaProdutoDetalhe> EntradaProdutoDetalhe { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
    }
}
