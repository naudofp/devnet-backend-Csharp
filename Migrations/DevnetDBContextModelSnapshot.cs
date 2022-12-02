﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using devnet_Csharp_backend.api.Data;

#nullable disable

namespace devnet_Csharp_backend.Migrations
{
    [DbContext(typeof(DevnetDBContext))]
    partial class DevnetDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Course", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("addScore")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("varchar(35)");

                    b.HasKey("id");

                    b.ToTable("course");
                });

            modelBuilder.Entity("CourseDeveloper", b =>
                {
                    b.Property<long>("coursesid")
                        .HasColumnType("bigint");

                    b.Property<long>("developersid")
                        .HasColumnType("bigint");

                    b.HasKey("coursesid", "developersid");

                    b.HasIndex("developersid");

                    b.ToTable("CourseDeveloper");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("id");

                    b.HasIndex("username")
                        .IsUnique();

                    b.ToTable("user");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("devnet_Csharp_backend.api.Models.Developer", b =>
                {
                    b.HasBaseType("User");

                    b.HasDiscriminator().HasValue("Developer");
                });

            modelBuilder.Entity("CourseDeveloper", b =>
                {
                    b.HasOne("Course", null)
                        .WithMany()
                        .HasForeignKey("coursesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("devnet_Csharp_backend.api.Models.Developer", null)
                        .WithMany()
                        .HasForeignKey("developersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
