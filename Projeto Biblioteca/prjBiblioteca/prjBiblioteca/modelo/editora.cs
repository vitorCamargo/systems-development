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
    
    public partial class editora
    {
        public editora()
        {
            this.livro = new HashSet<livro>();
        }
    
        public int idEditora { get; set; }
        public string descricao { get; set; }
        public string estado { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
    
        public virtual ICollection<livro> livro { get; set; }
    }
}
