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
    
    public partial class FocosReg
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FocosReg()
        {
            this.ConsultaRegistros01 = new HashSet<ConsultaRegistros01>();
        }
    
        public int RegistroFocos { get; set; }
        public byte[] FotoFoc { get; set; }
        public System.DateTime DataFocos { get; set; }
        public string RuaFoc { get; set; }
        public string CidadeFoc { get; set; }
        public string BairroFoc { get; set; }
        public string DescricaoFoc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConsultaRegistros01> ConsultaRegistros01 { get; set; }
    }
}
