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
    
    public partial class tend_endereco
    {
        public string cep { get; set; }
        public string endereco { get; set; }
        public int id_cidade { get; set; }
        public Nullable<int> id_bairro { get; set; }
    
        public virtual tend_bairro tend_bairro { get; set; }
        public virtual tend_cidade tend_cidade { get; set; }
    }
}