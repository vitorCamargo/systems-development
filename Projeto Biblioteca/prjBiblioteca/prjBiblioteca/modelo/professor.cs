//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjBiblioteca.modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class professor
    {
        public int idprofessor { get; set; }
        public string nome { get; set; }
        public int idcurso { get; set; }
        public string fone { get; set; }
        public string email { get; set; }
    
        public virtual curso curso { get; set; }
    }
}