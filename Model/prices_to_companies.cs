//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabProj.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class prices_to_companies
    {
        public int user_id { get; set; }
        public int company_id { get; set; }
        public decimal price { get; set; }
        public System.DateTime pay_date { get; set; }
    
        public virtual company company { get; set; }
        public virtual user user { get; set; }
    }
}