﻿using Quiron.LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    class EfDbContext: DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Administrador> Administradores { get; set; }

        public DbSet<Categoria> Categorias { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove <PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
            modelBuilder.Entity<Administrador>().ToTable("Administradores");
        }
    }
}
