//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace e_commerce2
{
    using System;
    using System.Collections.Generic;
    
    public partial class ARTICLEE
    {
        public string AR_Ref { get; set; }
        public string AR_Design { get; set; }
        public string FA_CodeFamille { get; set; }
        public Nullable<int> AR_UniteVen { get; set; }
        public Nullable<decimal> AR_PrixAch { get; set; }
        public Nullable<decimal> AR_PrixVen { get; set; }
        public Nullable<int> AR_PrixTTC { get; set; }
        public Nullable<int> AR_SuiviStock { get; set; }
        public Nullable<int> AR_Publie { get; set; }
        public string AR_Photo { get; set; }
    
        public virtual FAMILLE FAMILLE { get; set; }
    }
}
