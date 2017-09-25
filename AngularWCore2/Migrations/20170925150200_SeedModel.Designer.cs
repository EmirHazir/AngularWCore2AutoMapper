﻿// <auto-generated />
using AngularWCore2.ContextFiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AngularWCore2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20170925150200_SeedModel")]
    partial class SeedModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AngularWCore2.Models.Departman", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adi");

                    b.HasKey("Id");

                    b.ToTable("Departmanlar");
                });

            modelBuilder.Entity("AngularWCore2.Models.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adi");

                    b.Property<int?>("DepartmanId");

                    b.Property<string>("Email");

                    b.Property<string>("Soyadi");

                    b.Property<string>("TCKN");

                    b.Property<string>("Telefon");

                    b.HasKey("Id");

                    b.HasIndex("DepartmanId");

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("AngularWCore2.Models.Personel", b =>
                {
                    b.HasOne("AngularWCore2.Models.Departman", "Departman")
                        .WithMany()
                        .HasForeignKey("DepartmanId");
                });
#pragma warning restore 612, 618
        }
    }
}
