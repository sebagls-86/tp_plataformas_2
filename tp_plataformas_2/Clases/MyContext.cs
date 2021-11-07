using System;
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

        public DbSet<Carro_productos> Carro_productos { get; set; }

        public DbSet<Productos_compra> Productos_compra { get; set; }

        public MyContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Properties.Resources.SqlConnect);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //nombre de la tabla
            modelBuilder.Entity<Usuario>()
                .ToTable("Usuario")
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
                    //usr.Property(u => u.MiCarro).HasColumnType("int");
                    usr.Property(u => u.TipoUsuario).HasColumnType("int");
                });

            modelBuilder.Entity<Producto>()
               .ToTable("Producto")
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
             .ToTable("Categoria")
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
                    

                });

            modelBuilder.Entity<Compra>()
            .ToTable("Compra")
            .HasKey(u => u.CompraId);
            //propiedades de los datos
            modelBuilder.Entity<Compra>(
                usr =>
                {
                    usr.Property(u => u.CompraId).HasColumnType("int");
                   // usr.Property(u => u.Comprador).HasColumnType("varchar(50)");
                    usr.Property(u => u.IdProducto).HasColumnType("int");
                    usr.Property(u => u.Total).HasColumnType("double");

                });

            modelBuilder.Entity<Carro_productos>()
          .ToTable("Carro_productos")
          .HasKey(u => u.Carro_productos_Id);
            //propiedades de los datos
            modelBuilder.Entity<Carro_productos>(
                usr =>
                {
                    usr.Property(u => u.Carro_productos_Id).HasColumnType("int");
                    
                });


            modelBuilder.Entity<Productos_compra>()
         .ToTable("Productos_compra")
         .HasKey(u => u.Productos_compra_Id);
            //propiedades de los datos
            modelBuilder.Entity<Productos_compra>(
                usr =>
                {
                    usr.Property(u => u.Productos_compra_Id).HasColumnType("int");

                });

            modelBuilder.Entity<Producto>()
             .HasOne(u => u.Cat)
             .WithMany(p => p.Productos);

            modelBuilder.Entity<Usuario>()
            .HasOne(u => u.MiCarro)
            .WithOne(x => x.Usuario)
            .HasForeignKey<Carro>(c => c.UsuarioId);


            modelBuilder.Entity<Compra>()
              .HasOne(u => u.Comprador)
              .WithMany(x => x.Compra);

            modelBuilder.Entity<Compra>()
              .HasMany(u => u.productos)
              .WithMany(x => x.CompraProducto);

            modelBuilder.Entity<Carro>()
              .HasMany(u => u.ProductosCompra)
              .WithMany(x => x.CarroProducto)
              .UsingEntity(z => z.ToTable("Compras_Carro"));

            modelBuilder.Entity<Productos_compra>()
             .HasOne(u => u.Producto)
             .WithMany(x => x.productos_compras)
             .HasForeignKey(c => c.Id_Producto);

            modelBuilder.Entity<Productos_compra>()
             .HasOne(u => u.Compra)
             .WithMany(x => x.productos_Compras)
             .HasForeignKey(c => c.Id_Compra);

            modelBuilder.Entity<Carro_productos>()
             .HasOne(u => u.Carro)
             .WithMany(x => x.carro_productos)
             .HasForeignKey(c => c.Id_Carro);

            modelBuilder.Entity<Carro_productos>()
            .HasOne(u => u.Producto)
            .WithMany(x => x.carro_productos)
            .HasForeignKey(c => c.Id_Producto);



            //Ignoro, no agrego UsuarioManager a la base de datos
            modelBuilder.Ignore<MercadoHelper>();
            modelBuilder.Ignore<Mercado>();
            modelBuilder.Ignore<Excepciones>();
        }
    }
}
