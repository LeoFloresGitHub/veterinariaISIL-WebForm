//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoWCF_Veterinaria
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medicamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medicamento()
        {
            this.Det_Consulta = new HashSet<Det_Consulta>();
        }
    
        public int cod_medicamento { get; set; }
        public string des_medicamento { get; set; }
        public Nullable<int> cod_tipomedicamento { get; set; }
        public decimal prec_med { get; set; }
        public decimal igv { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Det_Consulta> Det_Consulta { get; set; }
    }
}
