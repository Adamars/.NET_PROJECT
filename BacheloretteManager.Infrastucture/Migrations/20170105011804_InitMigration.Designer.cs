using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BacheloretteManager.Infrastucture;

namespace BacheloretteManager.Infrastucture.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20170105011804_InitMigration")]
    partial class InitMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BacheloretteManager.Core.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int>("Role")
                        .HasAnnotation("MaxLength", 100);

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("BacheloretteManager.Core.Student", b =>
                {
                    b.HasBaseType("BacheloretteManager.Core.User");

                    b.Property<double>("MeanA1");

                    b.Property<double>("MeanA2");

                    b.Property<string>("Preferences")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<Guid?>("UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Student");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("BacheloretteManager.Core.Teacher", b =>
                {
                    b.HasBaseType("BacheloretteManager.Core.User");

                    b.Property<int>("Available");

                    b.Property<int>("FreeSpaces");

                    b.Property<string>("Requirements")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<Guid?>("UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Teacher");

                    b.HasDiscriminator().HasValue("Teacher");
                });

            modelBuilder.Entity("BacheloretteManager.Core.Student", b =>
                {
                    b.HasOne("BacheloretteManager.Core.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BacheloretteManager.Core.Teacher", b =>
                {
                    b.HasOne("BacheloretteManager.Core.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
        }
    }
}
