//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityProjeUrun
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblmusteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblmusteri()
        {
            this.tblsatis = new HashSet<tblsatis>();
        }
    
        public int MUSTERIID { get; set; }
        public string MUSTERIAD { get; set; }
        public string MUSTERISOYAD { get; set; }
        public string SEHIR { get; set; }
        public Nullable<bool> DURUM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblsatis> tblsatis { get; set; }
    }
}