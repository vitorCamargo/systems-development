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
    
    public partial class livro
    {
        public int idLivro { get; set; }
        public string titulo { get; set; }
        public int idAutor { get; set; }
        public int idEditora { get; set; }
        public int nrpaginas { get; set; }
        public int edicao { get; set; }
        public System.DateTime publicacao { get; set; }
        public string resumo { get; set; }
        public string codisbn { get; set; }
        public int idGenero { get; set; }
    
        public virtual autor autor { get; set; }
        public virtual editora editora { get; set; }
        public virtual genero genero { get; set; }
    }
}
