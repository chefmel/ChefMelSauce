﻿// <auto-generated />
using ChefMelSauces.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChefMelSauces.Migrations
{
    [DbContext(typeof(ChefMelSaucesContext))]
    partial class ChefMelSaucesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChefMelSauces.Models.ECommerce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("CreditCardNumber")
                        .IsRequired()
                        .HasMaxLength(16);

                    b.Property<int>("CvvCode")
                        .HasMaxLength(4);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("ExpDate")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<short>("Sales");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.HasKey("Id");

                    b.ToTable("ECommerce");
                });
#pragma warning restore 612, 618
        }
    }
}