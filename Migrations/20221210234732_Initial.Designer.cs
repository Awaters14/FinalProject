﻿// <auto-generated />
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProject.Migrations
{
    [DbContext(typeof(ResponseContext))]
    [Migration("20221210234732_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalProject.Models.Priority", b =>
                {
                    b.Property<string>("priorityId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("priorityValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("priorityId");

                    b.ToTable("Priorities");

                    b.HasData(
                        new
                        {
                            priorityId = "1",
                            priorityValue = "A"
                        },
                        new
                        {
                            priorityId = "2",
                            priorityValue = "B"
                        },
                        new
                        {
                            priorityId = "3",
                            priorityValue = "C"
                        },
                        new
                        {
                            priorityId = "4",
                            priorityValue = "D"
                        },
                        new
                        {
                            priorityId = "5",
                            priorityValue = "E"
                        },
                        new
                        {
                            priorityId = "6",
                            priorityValue = "F"
                        });
                });

            modelBuilder.Entity("FinalProject.Models.Response", b =>
                {
                    b.Property<int>("ResponseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("priorityId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("problem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zipcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResponseId");

                    b.HasIndex("priorityId");

                    b.ToTable("Respones");

                    b.HasData(
                        new
                        {
                            ResponseId = 1,
                            address = "123 main st.",
                            name = "Bob",
                            priorityId = "2",
                            problem = "Broken Window",
                            state = "IA",
                            zipcode = "55555"
                        },
                        new
                        {
                            ResponseId = 2,
                            address = "456 downtown ave.",
                            name = "Frank",
                            priorityId = "1",
                            problem = "Missing roof",
                            state = "IA",
                            zipcode = "44444"
                        },
                        new
                        {
                            ResponseId = 3,
                            address = "5533 86th st.",
                            name = "Phil",
                            priorityId = "1",
                            problem = "Tree fell into house",
                            state = "IA",
                            zipcode = "333"
                        });
                });

            modelBuilder.Entity("FinalProject.Models.Response", b =>
                {
                    b.HasOne("FinalProject.Models.Priority", "priority")
                        .WithMany()
                        .HasForeignKey("priorityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("priority");
                });
#pragma warning restore 612, 618
        }
    }
}
