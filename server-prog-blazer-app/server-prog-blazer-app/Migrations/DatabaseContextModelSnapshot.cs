﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using server_prog_blazer_app.Data;

#nullable disable

namespace server_prog_blazer_app.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("server_prog_blazer_app.models.Hashed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("HashedData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dato")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("hasheds");
                });

            modelBuilder.Entity("server_prog_blazer_app.models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("StackSize")
                        .HasColumnType("int");

                    b.Property<string>("TodoTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmailId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
