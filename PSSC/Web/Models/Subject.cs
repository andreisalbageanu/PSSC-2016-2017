//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Credits { get; set; }
        public string Professor { get; set; }
        public string EvaluationType { get; set; }
        public Nullable<double> LaboratoryProportion { get; set; }
        public Nullable<int> CourseHours { get; set; }
    }
}