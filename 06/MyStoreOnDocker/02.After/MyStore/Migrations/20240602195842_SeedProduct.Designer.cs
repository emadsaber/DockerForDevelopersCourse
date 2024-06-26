﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyStore.Data;

#nullable disable

namespace MyStore.Migrations
{
    [DbContext(typeof(MyStoreDbContext))]
    [Migration("20240602195842_SeedProduct")]
    partial class SeedProduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyStore.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "All food items",
                            Name = "Food"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Items relating to cleaning glass and floors",
                            Name = "Detergents"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Syrups and liquid items packed in bottles",
                            Name = "Drinks"
                        });
                });

            modelBuilder.Entity("MyStore.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Fresh Potatoes",
                            Name = "Potatoes",
                            Price = 40m,
                            Quantity = 5000
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Cleaning toilets",
                            Name = "Harpic",
                            Price = 20m,
                            Quantity = 1000
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Fresh Juice",
                            Name = "Orange Juice",
                            Price = 15m,
                            Quantity = 200
                        });
                });

            modelBuilder.Entity("MyStore.Entities.Product", b =>
                {
                    b.HasOne("MyStore.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
