//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_ModelFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public Student()
        {
            this.Books = new HashSet<Book>();
        }
    
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Discipline { get; set; }
        public string AdmissionYear { get; set; }
    
        public virtual ICollection<Book> Books { get; set; }
    }
}
