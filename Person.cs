//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BibliotecaN
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public int ID { get; set; }
        public string Utilizator { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Parola { get; set; }
        public int Rol { get; set; }
    
        public virtual Role Role { get; set; }
    }
}