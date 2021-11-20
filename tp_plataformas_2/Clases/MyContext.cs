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
          .HasKey(pk => new { pk.UsuarioId });

            modelBuilder.Entity<Usuario>()
           .HasOne(u => u.Carro)
           .WithOne(x => x.Usuario)
           .HasForeignKey<Carro>(c => c.UsuarioId)
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


            modelBuilder.Entity<Productos_compra>()
             .HasKey(pk => new { pk.Id });

            modelBuilder.Entity<Productos_compra>()
             .HasOne(u => u.Producto)
             .WithMany(x => x.Productos_compras)
             .HasForeignKey(c => c.Id_producto);

            modelBuilder.Entity<Productos_compra>()
             .HasOne(u => u.Compra)
             .WithMany(x => x.Productos_compra)
             .HasForeignKey(c => c.Id_compra);

            modelBuilder.Entity<Carro_productos>()
             .HasKey(pk => new { pk.Carro_productos_Id });

            modelBuilder.Entity<Carro_productos>()
             .HasOne(u => u.Carro)
             .WithMany(x => x.Carro_productos)
             .HasForeignKey(c => c.Id_Carro);

            modelBuilder.Entity<Carro_productos>()
            .HasOne(u => u.Producto)
            .WithMany(x => x.Carro_productos)
            .HasForeignKey(c => c.Id_Producto);


            //Ignoro, no agrego UsuarioManager a la base de datos
            modelBuilder.Ignore<MercadoHelper>();
            modelBuilder.Ignore<Mercado>();
            modelBuilder.Ignore<Excepciones>();
        }
    }
}
