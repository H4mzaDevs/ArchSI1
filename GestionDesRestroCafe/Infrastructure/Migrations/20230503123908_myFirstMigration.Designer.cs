﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(myDbContext))]
    [Migration("20230503123908_myFirstMigration")]
    partial class myFirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApplicationCore.Domain.Commande", b =>
                {
                    b.Property<string>("NumCmd")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCmd")
                        .HasColumnType("datetime2")
                        .HasColumnName("Date Commande");

                    b.Property<bool>("Livree")
                        .HasColumnType("bit");

                    b.Property<int>("LivreurId")
                        .HasColumnType("int");

                    b.HasKey("NumCmd");

                    b.HasIndex("LivreurId");

                    b.ToTable("Commandes");
                });

            modelBuilder.Entity("ApplicationCore.Domain.LigneCommande", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NumCmd")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PlatId")
                        .HasColumnType("int");

                    b.Property<int>("Quantite")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NumCmd");

                    b.HasIndex("PlatId");

                    b.ToTable("LigneCommande");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Livreur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Livreurs");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateMenu")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Plat", b =>
                {
                    b.Property<int>("IdPlat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPlat"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhotoPlat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Prix")
                        .HasColumnType("float");

                    b.Property<string>("TypePlat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPlat");

                    b.ToTable("Plats");
                });

            modelBuilder.Entity("CommandePlat", b =>
                {
                    b.Property<string>("CommandesNumCmd")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PlatsIdPlat")
                        .HasColumnType("int");

                    b.HasKey("CommandesNumCmd", "PlatsIdPlat");

                    b.HasIndex("PlatsIdPlat");

                    b.ToTable("CommandePlat", (string)null);
                });

            modelBuilder.Entity("MenuPlat", b =>
                {
                    b.Property<int>("MenusId")
                        .HasColumnType("int");

                    b.Property<int>("PlatsIdPlat")
                        .HasColumnType("int");

                    b.HasKey("MenusId", "PlatsIdPlat");

                    b.HasIndex("PlatsIdPlat");

                    b.ToTable("MenuPlat", (string)null);
                });

            modelBuilder.Entity("ApplicationCore.Domain.Commande", b =>
                {
                    b.HasOne("ApplicationCore.Domain.Livreur", "Livreur")
                        .WithMany("Commandes")
                        .HasForeignKey("LivreurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livreur");
                });

            modelBuilder.Entity("ApplicationCore.Domain.LigneCommande", b =>
                {
                    b.HasOne("ApplicationCore.Domain.Commande", "Commande")
                        .WithMany("LignesCommande")
                        .HasForeignKey("NumCmd")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Domain.Plat", "Plat")
                        .WithMany("LignesCommande")
                        .HasForeignKey("PlatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Commande");

                    b.Navigation("Plat");
                });

            modelBuilder.Entity("CommandePlat", b =>
                {
                    b.HasOne("ApplicationCore.Domain.Commande", null)
                        .WithMany()
                        .HasForeignKey("CommandesNumCmd")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Domain.Plat", null)
                        .WithMany()
                        .HasForeignKey("PlatsIdPlat")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MenuPlat", b =>
                {
                    b.HasOne("ApplicationCore.Domain.Menu", null)
                        .WithMany()
                        .HasForeignKey("MenusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Domain.Plat", null)
                        .WithMany()
                        .HasForeignKey("PlatsIdPlat")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationCore.Domain.Commande", b =>
                {
                    b.Navigation("LignesCommande");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Livreur", b =>
                {
                    b.Navigation("Commandes");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Plat", b =>
                {
                    b.Navigation("LignesCommande");
                });
#pragma warning restore 612, 618
        }
    }
}