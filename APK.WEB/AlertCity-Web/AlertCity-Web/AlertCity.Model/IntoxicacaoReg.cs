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
    
    public partial class IntoxicacaoReg
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IntoxicacaoReg()
        {
            this.ConsultaRegistros01 = new HashSet<ConsultaRegistros01>();
        }
    
        public int RegistroIntoxicacao { get; set; }
        public byte[] FotoInt { get; set; }
        public System.DateTime DataInt { get; set; }
        public string RuaInt { get; set; }
        public string CidadeInt { get; set; }
        public string BairroInt { get; set; }
        public string DescricaoInt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConsultaRegistros01> ConsultaRegistros01 { get; set; }
    }
}
