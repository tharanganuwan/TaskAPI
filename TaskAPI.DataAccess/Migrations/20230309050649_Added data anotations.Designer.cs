// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskAPI.DataAccess;

namespace TaskAPI.DataAccess.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    [Migration("20230309050649_Added data anotations")]
    partial class Addeddataanotations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressNo = "45",
                            City = "Colombo",
                            Fullname = "Nuwan",
                            Street = "Street 1"
                        },
                        new
                        {
                            Id = 2,
                            AddressNo = "55",
                            City = "Kandy",
                            Fullname = "Kasun",
                            Street = "Street 3"
                        },
                        new
                        {
                            Id = 3,
                            AddressNo = "65",
                            City = "Gampaha",
                            Fullname = "Kamal",
                            Street = "Street 9"
                        },
                        new
                        {
                            Id = 4,
                            AddressNo = "75",
                            City = "Galla",
                            Fullname = "Nimal",
                            Street = "Street 7"
                        },
                        new
                        {
                            Id = 5,
                            AddressNo = "80",
                            City = "Trinco",
                            Fullname = "Amal",
                            Street = "Street 5"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Created = new DateTime(2023, 3, 9, 10, 36, 49, 385, DateTimeKind.Local).AddTicks(256),
                            Description = "Get Some text Books for school",
                            Due = new DateTime(2023, 3, 14, 10, 36, 49, 385, DateTimeKind.Local).AddTicks(9001),
                            Status = 1,
                            Title = "Get books for School from DB"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Created = new DateTime(2023, 3, 9, 10, 36, 49, 386, DateTimeKind.Local).AddTicks(35),
                            Description = "Get Some text Books for school",
                            Due = new DateTime(2023, 3, 14, 10, 36, 49, 386, DateTimeKind.Local).AddTicks(41),
                            Status = 1,
                            Title = "Get books for School from DB"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 1,
                            Created = new DateTime(2023, 3, 9, 10, 36, 49, 386, DateTimeKind.Local).AddTicks(51),
                            Description = "Get Some text Books for school",
                            Due = new DateTime(2023, 3, 14, 10, 36, 49, 386, DateTimeKind.Local).AddTicks(52),
                            Status = 1,
                            Title = "Get books for School from DB"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.HasOne("TaskAPI.Models.Author", "Author")
                        .WithMany("Todos")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
