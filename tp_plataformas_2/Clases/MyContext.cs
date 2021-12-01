using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace tp_plataformas_2
{
    class MyContext : DbContext
    {
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Carro> carro { get; set; }
        public DbSet<Compra> compras { get; set; }
        public DbSet<Carro_productos> Carro_productos { get; set; }
        public DbSet<Productos_compra> Productos_compra { get; set; }

        public MyContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Properties.Resources.SqlConnect);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
          .HasKey(pk => pk.UsuarioId);

            modelBuilder.Entity<Usuario>()
           .HasOne(u => u.Carro)
           .WithOne(x => x.Usuario)
           .HasForeignKey<Carro>(x => x.UsuarioId)
           .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Carro>()
            .HasKey(pk => pk.CarroId);

            modelBuilder.Entity<Carro>()
           .HasOne(u => u.Usuario)
           .WithOne(x => x.Carro)
           .HasForeignKey<Carro>(c => c.UsuarioId)
           .OnDelete(DeleteBehavior.Cascade);

          
            modelBuilder.Entity<Categoria>()
          .HasKey(pk =>pk.CatId);

            modelBuilder.Entity<Producto>()
          .HasKey(pk => pk.ProductoId);

            modelBuilder.Entity<Producto>()
             .HasOne(u => u.Cat)
             .WithMany(p => p.Productos)
             .HasForeignKey(u => u.CatId);


            modelBuilder.Entity<Compra>()
         .HasKey(pk => pk.CompraId);

            modelBuilder.Entity<Compra>()
              .HasOne(u => u.Usuario)
              .WithMany(x => x.Compra)
              .HasForeignKey(u => u.idUsuario);


            modelBuilder.Entity<Producto>()
                .HasMany(U => U.CompraProducto)
                .WithMany(P => P.CompraProducto)
                .UsingEntity<Productos_compra>(
                    eup => eup.HasOne(up => up.Compra).WithMany(p => p.Productos_compra).HasForeignKey(u => u.Id_compra),
                    eup => eup.HasOne(up => up.Producto).WithMany(u => u.Productos_compras).HasForeignKey(u => u.Id_producto),
                    eup => eup.HasKey(k => new { k.Id_producto, k.Id_compra })
                );


            modelBuilder.Entity<Carro>()
                .HasMany(U => U.ProductosCompra)
                .WithMany(P => P.CarroProducto)
                .UsingEntity<Carro_productos>(
                    eup => eup.HasOne(up => up.Producto).WithMany(p => p.Carro_productos).HasForeignKey(u => u.Id_Producto),
                    eup => eup.HasOne(up => up.Carro).WithMany(u => u.Carro_productos).HasForeignKey(u => u.Id_Carro),
                    eup => eup.HasKey(k => new { k.Id_Producto, k.Id_Carro })
                );


            //Ignoro, no agrego UsuarioManager a la base de datos
            modelBuilder.Ignore<MercadoHelper>();
            modelBuilder.Ignore<Mercado>();
            modelBuilder.Ignore<Excepciones>();
        }
    }
}
