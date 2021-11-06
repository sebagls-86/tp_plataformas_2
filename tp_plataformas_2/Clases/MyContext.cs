﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace tp_plataformas_2
{
    class MyContext : DbContext
    {
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Carro> carros { get; set; }

        public MyContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Properties.Resources.SqlConnect);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //nombre de la tabla
            modelBuilder.Entity<Usuario>()
                .ToTable("Usuarios")
                .HasKey(u => u.UsuarioId);
            //propiedades de los datos
            modelBuilder.Entity<Usuario>(
                usr =>
                {

                    usr.Property(u => u.UsuarioId).HasColumnType("int");
                    usr.Property(u => u.Cuil).HasColumnType("int");
                    usr.Property(u => u.Nombre).HasColumnType("varchar(50)");
                    usr.Property(u => u.Apellido).HasColumnType("varchar(50)");
                    usr.Property(u => u.Mail).HasColumnType("varchar(50)");
                    usr.Property(u => u.Password).HasColumnType("varchar(50)");
                    usr.Property(u => u.MiCarro).HasColumnType("int");
                    usr.Property(u => u.TipoUsuario).HasColumnType("int");
                });

            modelBuilder.Entity<Producto>()
               .ToTable("Productos")
               .HasKey(u => u.ProductoId);
            //propiedades de los datos
            modelBuilder.Entity<Producto>(
                usr =>
                {

                    usr.Property(u => u.ProductoId).HasColumnType("int");
                    usr.Property(u => u.Nombre).HasColumnType("varchar(50)");
                    usr.Property(u => u.Precio).HasColumnType("decimal(18,0)");
                    usr.Property(u => u.Cantidad).HasColumnType("int");
                    usr.Property(u => u.CatId).HasColumnType("int");
                    
                });

            modelBuilder.Entity<Categoria>()
             .ToTable("Categorias")
             .HasKey(u => u.CatId);
            
            //propiedades de los datos
            modelBuilder.Entity<Categoria>(
                usr =>
                {
                    usr.Property(u => u.CatId).HasColumnType("int");
                    usr.Property(u => u.Nombre).HasColumnType("varchar(50)");

                });

            modelBuilder.Entity<Carro>()
              .ToTable("Carro")
              .HasKey(u => u.CarroId);
            //propiedades de los datos
            modelBuilder.Entity<Carro>(
                usr =>
                {
                    usr.Property(u => u.CarroId).HasColumnType("int");
                    usr.Property(u => u.Productos).HasColumnType("varchar(50)");
                   
                });


            modelBuilder.Entity<Categoria>()
             .HasOne(u => u.Productos)
             .WithMany();

            modelBuilder.Entity<Carro>()
            .HasOne(u => u.Usuario)
            .WithOne();

            modelBuilder.Entity<Carro>()
          .HasOne(x => x.Productos)
          .WithMany();
          
          



            //Ignoro, no agrego UsuarioManager a la base de datos
            modelBuilder.Ignore<MercadoHelper>();
            modelBuilder.Ignore<Mercado>();
            modelBuilder.Ignore<Excepciones>();
        }
    }
}