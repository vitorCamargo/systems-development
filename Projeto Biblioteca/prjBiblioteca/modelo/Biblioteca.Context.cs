﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bibliotecaEntidades : DbContext
    {
        public bibliotecaEntidades()
            : base("name=bibliotecaEntidades")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<aluno> aluno { get; set; }
        public DbSet<autor> autor { get; set; }
        public DbSet<curso> curso { get; set; }
        public DbSet<editora> editora { get; set; }
        public DbSet<genero> genero { get; set; }
        public DbSet<livro> livro { get; set; }
        public DbSet<professor> professor { get; set; }
        public DbSet<tend_bairro> tend_bairro { get; set; }
        public DbSet<tend_cidade> tend_cidade { get; set; }
        public DbSet<tend_endereco> tend_endereco { get; set; }
        public DbSet<usuarios> usuarios { get; set; }
    }
}
