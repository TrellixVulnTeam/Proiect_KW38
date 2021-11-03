﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20211102160836_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Data.Device", b =>
                {
                    b.Property<int>("DeviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeviceName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DeviceOS")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("DeviceProcessor")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("DeviceRAM")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DeviceType")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("DeviceId");

                    b.HasIndex("UserId");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            DeviceId = 1,
                            DeviceName = "Smart001",
                            DeviceOS = "Android",
                            DeviceProcessor = "Exynos",
                            DeviceRAM = "6GB",
                            DeviceType = "Smartphone",
                            Manufacturer = "Samsung",
                            UserId = 0
                        },
                        new
                        {
                            DeviceId = 2,
                            DeviceName = "Smart002",
                            DeviceOS = "Android",
                            DeviceProcessor = "Snapdragon",
                            DeviceRAM = "12GB",
                            DeviceType = "Smartphone",
                            Manufacturer = "Samsung",
                            UserId = 0
                        },
                        new
                        {
                            DeviceId = 3,
                            DeviceName = "Smart003",
                            DeviceOS = "iOS",
                            DeviceProcessor = "A13 Bionic",
                            DeviceRAM = "4GB",
                            DeviceType = "Smartphone",
                            Manufacturer = "Apple",
                            UserId = 0
                        });
                });

            modelBuilder.Entity("WebApplication1.Data.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserLocation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserRole")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            UserLocation = "Cluj-Napoca",
                            UserName = "Mihai Stefanescu",
                            UserRole = "Web Developer"
                        },
                        new
                        {
                            UserId = 2,
                            UserLocation = "Cluj-Napoca",
                            UserName = "Ioana Maria",
                            UserRole = ".NET Developer"
                        },
                        new
                        {
                            UserId = 3,
                            UserLocation = "Brasov",
                            UserName = "Mos Bogdan",
                            UserRole = "Java Developer"
                        });
                });

            modelBuilder.Entity("WebApplication1.Data.Device", b =>
                {
                    b.HasOne("WebApplication1.Data.User", "User")
                        .WithMany("Devices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication1.Data.User", b =>
                {
                    b.Navigation("Devices");
                });
#pragma warning restore 612, 618
        }
    }
}