//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MDL
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_PERFORMANCE_RULES_INFO
    {
        public System.Guid ID { get; set; }
        public string PERFORMANCE_RULES_NAME { get; set; }
        public string REMARK { get; set; }
        public string SEQUENCE { get; set; }
        public Nullable<System.Guid> CREATE_USER_ID { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public Nullable<decimal> BEGIN_SCORE { get; set; }
        public Nullable<decimal> END_SCORE { get; set; }
        public string PERFORMANCE_RULES_ITEMS_DESC { get; set; }
        public Nullable<System.DateTime> ITEMS_CREATE_DATE { get; set; }
        public Nullable<System.Guid> ITEMS_CREATE_USER_ID { get; set; }
        public string ITEMS_SEQUENCE { get; set; }
        public Nullable<System.Guid> PERFORMANCE_RULES_ID { get; set; }
    }
}
