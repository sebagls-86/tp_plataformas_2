﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tp_plataformas_2;

namespace tp_plataformas_2.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("tp_plataformas_2.Carro", b =>
                {
                    b.Property<int>("CarroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("CarroId");

                    b.ToTable("carro");
                });

            modelBuilder.Entity("tp_plataformas_2.Carro_productos", b =>
                {
                    b.Property<int>("Id_Producto")
                        .HasColumnType("int");

                    b.Property<int>("Id_Carro")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("Carro_productos_Id")
                        .HasColumnType("int");

                    b.HasKey("Id_Producto", "Id_Carro");

                    b.HasIndex("Id_Carro");

                    b.ToTable("Carro_productos");
                });

            modelBuilder.Entity("tp_plataformas_2.Categoria", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CatId");

                    b.ToTable("categorias");
                });

            modelBuilder.Entity("tp_plataformas_2.Compra", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int");

                    b.HasKey("CompraId");

                    b.HasIndex("idUsuario");

                    b.ToTable("compras");
                });

            modelBuilder.Entity("tp_plataformas_2.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("CatId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("ProductoId");

                    b.HasIndex("CatId");

                    b.ToTable("productos");
                });

            modelBuilder.Entity("tp_plataformas_2.Productos_compra", b =>
                {
                    b.Property<int>("Id_producto")
                        .HasColumnType("int");

                    b.Property<int>("Id_compra")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad_producto")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("Id_producto", "Id_compra");

                    b.HasIndex("Id_compra");

                    b.ToTable("Productos_compra");
                });

            modelBuilder.Entity("tp_plataformas_2.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cuil")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MiCarro")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoUsuario")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId");

                    b.HasIndex("MiCarro")
                        .IsUnique();

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("tp_plataformas_2.Carro_productos", b =>
                {
                    b.HasOne("tp_plataformas_2.Carro", "Carro")
                        .WithMany("Carro_productos")
                        .HasForeignKey("Id_Carro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tp_plataformas_2.Producto", "Producto")
                        .WithMany("Carro_productos")
                        .HasForeignKey("Id_Producto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carro");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("tp_plataformas_2.Compra", b =>
                {
                    b.HasOne("tp_plataformas_2.Usuario", "Usuario")
                        .WithMany("Compra")
                        .HasForeignKey("idUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("tp_plataformas_2.Producto", b =>
                {
                    b.HasOne("tp_plataformas_2.Categoria", "Cat")
                        .WithMany("Productos")
                        .HasForeignKey("CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cat");
                });

            modelBuilder.Entity("tp_plataformas_2.Productos_compra", b =>
                {
                    b.HasOne("tp_plataformas_2.Compra", "Compra")
                        .WithMany("Productos_compra")
                        .HasForeignKey("Id_compra")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tp_plataformas_2.Producto", "Producto")
                        .WithMany("Productos_compras")
                        .HasForeignKey("Id_producto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compra");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("tp_plataformas_2.Usuario", b =>
                {
                    b.HasOne("tp_plataformas_2.Carro", "Carro")
                        .WithOne("Usuario")
                        .HasForeignKey("tp_plataformas_2.Usuario", "MiCarro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carro");
                });

            modelBuilder.Entity("tp_plataformas_2.Carro", b =>
                {
                    b.Navigation("Carro_productos");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("tp_plataformas_2.Categoria", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("tp_plataformas_2.Compra", b =>
                {
                    b.Navigation("Productos_compra");
                });

            modelBuilder.Entity("tp_plataformas_2.Producto", b =>
                {
                    b.Navigation("Carro_productos");

                    b.Navigation("Productos_compras");
                });

            modelBuilder.Entity("tp_plataformas_2.Usuario", b =>
                {
                    b.Navigation("Compra");
                });
#pragma warning restore 612, 618
        }
    }
}
