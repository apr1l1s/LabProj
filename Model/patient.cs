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
    
    public partial class patient
    {
        public int patient_id { get; set; }
        public string login { get; set; }
        public string pass { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string middlename { get; set; }
        public Nullable<System.DateTime> birth_date { get; set; }
        public string passport { get; set; }
        public string phone { get; set; }
        public string emal { get; set; }
        public string polis { get; set; }
        public Nullable<int> polis_type { get; set; }
        public Nullable<int> company_id { get; set; }
        public string status { get; set; }
    
        public virtual company company { get; set; }
    }
}
