//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlertCity.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BuracoReg
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BuracoReg()
        {
            this.ConsultaRegistros01 = new HashSet<ConsultaRegistros01>();
        }
    
        public int RegistroBuraco { get; set; }
        public byte[] FotoBur { get; set; }
        public string DescricaoBur { get; set; }
        public string RuaBur { get; set; }
        public string CidadeBur { get; set; }
        public string BairroBur { get; set; }
        public System.DateTime DataBuracoBur { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConsultaRegistros01> ConsultaRegistros01 { get; set; }
    }
}