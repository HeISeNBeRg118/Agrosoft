﻿// <auto-generated />
using System;
using Agrosoft.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Agrosoft.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("Agrosoft.Models.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Balance")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("LimiteCredito")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            ClienteId = 1,
                            Apellidos = "ocasional",
                            Balance = 0m,
                            Cedula = "00000000000",
                            Celular = "0000000000",
                            Direccion = "xxxxxxxxxxxxx",
                            Email = "clienteOcasional@hotmail.com",
                            Fecha = new DateTime(2020, 7, 29, 2, 46, 21, 67, DateTimeKind.Local).AddTicks(3113),
                            LimiteCredito = 0m,
                            Nombres = "Cliente",
                            Telefono = "0000000000",
                            UsuarioId = 1
                        });
                });

            modelBuilder.Entity("Agrosoft.Models.Cobros", b =>
                {
                    b.Property<int>("CobrosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Deposito")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CobrosId");

                    b.ToTable("Cobros");
                });

            modelBuilder.Entity("Agrosoft.Models.CompraProductos", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Total")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CompraId");

                    b.ToTable("CompraProductos");
                });

            modelBuilder.Entity("Agrosoft.Models.CompraProductosDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompraId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Precio")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CompraId");

                    b.ToTable("CompraProductosDetalle");
                });

            modelBuilder.Entity("Agrosoft.Models.Marcas", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MarcaId");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("Agrosoft.Models.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadExistente")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadMinima")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Costo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Precio")
                        .HasColumnType("TEXT");

                    b.Property<int>("UnidadMedida")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Agrosoft.Models.Proveedores", b =>
                {
                    b.Property<int>("ProveedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Rnc")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProveedorId");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("Agrosoft.Models.UnidadesMedida", b =>
                {
                    b.Property<int>("UnidadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("UnidadId");

                    b.ToTable("UnidadesMedida");

                    b.HasData(
                        new
                        {
                            UnidadId = 1,
                            Descripcion = "Saco 25 Lbs"
                        },
                        new
                        {
                            UnidadId = 2,
                            Descripcion = "Saco 50 Lbs"
                        },
                        new
                        {
                            UnidadId = 3,
                            Descripcion = "Saco 100 Lbs"
                        },
                        new
                        {
                            UnidadId = 4,
                            Descripcion = "Saco 125 Lbs"
                        },
                        new
                        {
                            UnidadId = 5,
                            Descripcion = "Saco 200 Lbs"
                        });
                });

            modelBuilder.Entity("Agrosoft.Models.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaveUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            Apellidos = "Admin",
                            Celular = "0123456789",
                            ClaveUsuario = "admin",
                            Direccion = "Admin",
                            Email = "Admin@hotmail.com",
                            Fecha = new DateTime(2020, 7, 29, 2, 46, 21, 65, DateTimeKind.Local).AddTicks(1971),
                            NombreUsuario = "Admin",
                            Nombres = "Admin",
                            Telefono = "0123456789",
                            TipoUsuario = "Administrador"
                        });
                });

            modelBuilder.Entity("Agrosoft.Models.VentaProductos", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("TipoFactura")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Total")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("VentaId");

                    b.ToTable("VentaProductos");
                });

            modelBuilder.Entity("Agrosoft.Models.VentaProductosDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Importe")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VentaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("VentaId");

                    b.ToTable("VentaProductosDetalle");
                });

            modelBuilder.Entity("Agrosoft.Models.CompraProductosDetalle", b =>
                {
                    b.HasOne("Agrosoft.Models.CompraProductos", null)
                        .WithMany("CompraProductosDetalle")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Agrosoft.Models.VentaProductosDetalle", b =>
                {
                    b.HasOne("Agrosoft.Models.VentaProductos", null)
                        .WithMany("VentaProductosDetalle")
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
