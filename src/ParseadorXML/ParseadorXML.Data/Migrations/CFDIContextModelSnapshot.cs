﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParseadorXML.Infra.Data.EFRepositories.src.context;

namespace ParseadorXML.Infra.Data.EFRepositories.Migrations
{
    [DbContext(typeof(CFDIContext))]
    partial class CFDIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParseadorXML.Domain.src.Entities.CFDI.Comprobante.Comprobante", b =>
                {
                    b.Property<string>("UUID")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime");

                    b.Property<string>("Tipo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnName("Version")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(2);

                    b.HasKey("UUID");

                    b.ToTable("Comprobantes");
                });

            modelBuilder.Entity("ParseadorXML.Domain.src.Entities.CFDI.Comprobante.Concepto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ComprobanteUUID")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Total")
                        .HasColumnType("double");

                    b.Property<string>("UUID")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ComprobanteUUID");

                    b.ToTable("Concepto");
                });

            modelBuilder.Entity("ParseadorXML.Domain.src.Entities.CFDI.Comprobante.Emisor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("RFC")
                        .IsRequired()
                        .HasColumnName("RFC")
                        .HasColumnType("varchar(13)")
                        .HasMaxLength(13);

                    b.Property<string>("RazonSocial")
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("UUID")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("UUID")
                        .IsUnique();

                    b.ToTable("Emisores");
                });

            modelBuilder.Entity("ParseadorXML.Domain.src.Entities.CFDI.Comprobante.Receptor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("RFC")
                        .IsRequired()
                        .HasColumnName("RFC")
                        .HasColumnType("varchar(13)")
                        .HasMaxLength(13);

                    b.Property<string>("RazonSocial")
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("UUID")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("UUID")
                        .IsUnique();

                    b.ToTable("Receptores");
                });

            modelBuilder.Entity("ParseadorXML.Domain.src.Entities.CFDI.Comprobante.Concepto", b =>
                {
                    b.HasOne("ParseadorXML.Domain.src.Entities.CFDI.Comprobante.Comprobante", "Comprobante")
                        .WithMany("Conceptos")
                        .HasForeignKey("ComprobanteUUID");
                });

            modelBuilder.Entity("ParseadorXML.Domain.src.Entities.CFDI.Comprobante.Emisor", b =>
                {
                    b.HasOne("ParseadorXML.Domain.src.Entities.CFDI.Comprobante.Comprobante", "Comprobante")
                        .WithOne("Emisor")
                        .HasForeignKey("ParseadorXML.Domain.src.Entities.CFDI.Comprobante.Emisor", "UUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ParseadorXML.Domain.src.Entities.CFDI.Comprobante.Receptor", b =>
                {
                    b.HasOne("ParseadorXML.Domain.src.Entities.CFDI.Comprobante.Comprobante", "Comprobante")
                        .WithOne("Receptor")
                        .HasForeignKey("ParseadorXML.Domain.src.Entities.CFDI.Comprobante.Receptor", "UUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
