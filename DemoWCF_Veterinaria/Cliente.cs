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
    
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Mascota = new HashSet<Mascota>();
        }
    
        public int cod_cliente { get; set; }
        public string nom_cliente { get; set; }
        public string ape_cliente { get; set; }
        public Nullable<int> dni_cli { get; set; }
        public string id_Ubigeo { get; set; }
        public string dirección { get; set; }
        public string tel_cliente { get; set; }
        public string Usu_Registro { get; set; }
        public Nullable<int> est_cli { get; set; }
        public string sexo { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> fec_registro { get; set; }
        public string num_registro { get; set; }
        public Nullable<System.DateTime> fec_Ult_Mod { get; set; }
        public string Usu_Ult_Mod { get; set; }
    
        public virtual Ubigeo Ubigeo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mascota> Mascota { get; set; }
    }
}
