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
    
    public partial class Mascota
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mascota()
        {
            this.Consulta = new HashSet<Consulta>();
        }
    
        public int cod_mascota { get; set; }
        public Nullable<int> cod_esp { get; set; }
        public string nom_mascota { get; set; }
        public Nullable<int> cod_cliente { get; set; }
        public string nom_cliente { get; set; }
        public string ape_cliente { get; set; }
        public byte[] foto { get; set; }
        public string sexo { get; set; }
        public string color { get; set; }
        public Nullable<System.DateTime> fec_nacimiento { get; set; }
        public Nullable<int> est_mascota { get; set; }
        public Nullable<System.DateTime> fec_Ult_Mod { get; set; }
        public string Usu_Ult_Mod { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consulta> Consulta { get; set; }
        public virtual Esp Esp { get; set; }
    }
}