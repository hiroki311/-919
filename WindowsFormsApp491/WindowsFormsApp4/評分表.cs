//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp4
{
    using System;
    using System.Collections.Generic;
    
    public partial class 評分表
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 評分表()
        {
            this.action報表 = new HashSet<action報表>();
        }
    
        public int 評分表ID { get; set; }
        public Nullable<byte> 評分 { get; set; }
        public string 評論 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<action報表> action報表 { get; set; }
    }
}
