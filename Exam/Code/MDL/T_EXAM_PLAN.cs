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
    
    public partial class T_EXAM_PLAN
    {
        public T_EXAM_PLAN()
        {
            this.T_AUTHORIZED_EXAM = new HashSet<T_AUTHORIZED_EXAM>();
            this.T_AUTHORIZED_READ_PAPERS_USER = new HashSet<T_AUTHORIZED_READ_PAPERS_USER>();
            this.T_EXAM_PLAN_ANSWER = new HashSet<T_EXAM_PLAN_ANSWER>();
            this.T_SCORES = new HashSet<T_SCORES>();
        }
    
        public System.Guid ID { get; set; }
        public string EXAM_PLAN_NAME { get; set; }
        public Nullable<System.Guid> PERFORMANCE_RULES_ID { get; set; }
        public Nullable<int> TOTAL_TIME { get; set; }
        public Nullable<int> JOIN_COUNTS { get; set; }
        public Nullable<decimal> TOTAL_SCORE { get; set; }
        public Nullable<decimal> PASSING_SCORE { get; set; }
        public Nullable<System.DateTime> BEGIN_TIME { get; set; }
        public Nullable<System.DateTime> END_TIME { get; set; }
        public string ARRANGEMENT_OPTIONS { get; set; }
        public Nullable<System.DateTime> EXAM_SCORE_PUBLIC_DATE { get; set; }
        public string PAPER_MODEL { get; set; }
        public string MUL_CHOICE_GRADING_RULES { get; set; }
        public string REMARK { get; set; }
        public Nullable<System.Guid> PAPER_ID { get; set; }
        public Nullable<System.Guid> CREATE_USER_ID { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public string EXAM_AFTER_ALLOW_VIEW { get; set; }
    
        public virtual ICollection<T_AUTHORIZED_EXAM> T_AUTHORIZED_EXAM { get; set; }
        public virtual ICollection<T_AUTHORIZED_READ_PAPERS_USER> T_AUTHORIZED_READ_PAPERS_USER { get; set; }
        public virtual ICollection<T_EXAM_PLAN_ANSWER> T_EXAM_PLAN_ANSWER { get; set; }
        public virtual T_PAPER T_PAPER { get; set; }
        public virtual T_PERFORMANCE_RULES T_PERFORMANCE_RULES { get; set; }
        public virtual ICollection<T_SCORES> T_SCORES { get; set; }
    }
}
