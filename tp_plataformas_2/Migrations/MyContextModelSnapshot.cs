﻿// <auto-generated />
using System;
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

            modelBuilder.Entity("CompraProducto", b =>
                {
                    b.Property<int>("CompraProductoCompraId")
                        .HasColumnType("int");

                    b.Property<int>("productosCompraProductoId")
                        .HasColumnType("int");

                    b.HasKey("CompraProductoCompraId", "productosCompraProductoId");

                    b.HasIndex("productosCompraProductoId");

                    b.ToTable("CompraProducto");
                });

            modelBuilder.Entity("tp_plataformas_2.Carro", b =>
                {
                    b.Property<int>("CarroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.HasKey("CarroId");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Carro");
                });

            modelBuilder.Entity("tp_plataformas_2.Categoria", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(50)");

                    b.HasKey("CatId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("tp_plataformas_2.Compra", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompradorUsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("double");

                    b.HasKey("CompraId");

                    b.HasIndex("CompradorUsuarioId");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("tp_plataformas_2.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("CarroId")
                        .HasColumnType("int");

                    b.Property<int>("CatId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,0)");

                    b.HasKey("ProductoId");

                    b.HasIndex("CarroId");

                    b.HasIndex("CatId");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("tp_plataformas_2.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Cuil")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("TipoUsuario")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("CompraProducto", b =>
                {
                    b.HasOne("tp_plataformas_2.Compra", null)
                        .WithMany()
                        .HasForeignKey("CompraProductoCompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tp_plataformas_2.Producto", null)
                        .WithMany()
                        .HasForeignKey("productosCompraProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tp_plataformas_2.Carro", b =>
                {
                    b.HasOne("tp_plataformas_2.Usuario", "Usuario")
                        .WithOne("MiCarro")
                        .HasForeignKey("tp_plataformas_2.Carro", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("tp_plataformas_2.Compra", b =>
                {
                    b.HasOne("tp_plataformas_2.Usuario", "Comprador")
                        .WithMany("Compra")
                        .HasForeignKey("CompradorUsuarioId");

                    b.Navigation("Comprador");
                });

            modelBuilder.Entity("tp_plataformas_2.Producto", b =>
                {
                    b.HasOne("tp_plataformas_2.Carro", null)
                        .WithMany("productos")
                        .HasForeignKey("CarroId");

                    b.HasOne("tp_plataformas_2.Categoria", "Cat")
                        .WithMany("Productos")
                        .HasForeignKey("CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cat");
                });

            modelBuilder.Entity("tp_plataformas_2.Carro", b =>
                {
                    b.Navigation("productos");
                });

            modelBuilder.Entity("tp_plataformas_2.Categoria", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("tp_plataformas_2.Usuario", b =>
                {
                    b.Navigation("Compra");

                    b.Navigation("MiCarro");
                });
#pragma warning restore 612, 618
        }
    }
}
