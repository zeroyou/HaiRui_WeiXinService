//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Goods
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Goods()
        {
            this.Goods_Order = new HashSet<Goods_Order>();
        }
    
        public System.Guid GoodID { get; set; }
        public string GoodName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.Guid> AccountID { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> CostScore { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<System.Guid> UserID { get; set; }
        public Nullable<System.Guid> SendWayID { get; set; }
        public string GetAddress { get; set; }
        public string ContactPhone { get; set; }
        public string GoodLink { get; set; }
        public Nullable<System.Guid> CategoryID { get; set; }
        public Nullable<bool> IsSelling { get; set; }
    
        public virtual Goods_Category Goods_Category { get; set; }
        public virtual OfficialAccount OfficialAccount { get; set; }
        public virtual Goods_SendWay Goods_SendWay { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Goods_Order> Goods_Order { get; set; }
    }
}
