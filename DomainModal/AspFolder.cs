//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SignaturePad.DomainModal
{
    using System;
    using System.Collections.Generic;
    
    public partial class AspFolder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspFolder()
        {
            this.AspStoreDocuments = new HashSet<AspStoreDocument>();
        }
    
        public long IdFoder { get; set; }
        public string NameFolder { get; set; }
        public Nullable<int> OderSort { get; set; }
        public Nullable<long> SessionId { get; set; }
        public Nullable<long> SeesionRemove { get; set; }
        public Nullable<bool> IsDeleate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspStoreDocument> AspStoreDocuments { get; set; }
    }
}
