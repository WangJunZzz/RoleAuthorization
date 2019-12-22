﻿// <auto-generated />
using System;
using AuthorizationPro.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Simple.AuthorizationPro.Migrations.AuthorizationPro
{
    [DbContext(typeof(AuthProDbContext))]
    partial class AuthProDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AuthorizationPro.Entity.ApiResource", b =>
                {
                    b.Property<string>("ApiResourceId")
                        .HasColumnType("varchar(36) CHARACTER SET utf8mb4")
                        .HasMaxLength(36);

                    b.Property<string>("BaseUrl")
                        .IsRequired()
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IsDelete")
                        .HasColumnType("int");

                    b.Property<int>("IsValid")
                        .HasColumnType("int");

                    b.Property<string>("Method")
                        .IsRequired()
                        .HasColumnType("varchar(12) CHARACTER SET utf8mb4")
                        .HasMaxLength(12);

                    b.Property<string>("Parameters")
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.HasKey("ApiResourceId");

                    b.ToTable("ApiResource");
                });

            modelBuilder.Entity("AuthorizationPro.Entity.Role", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(36) CHARACTER SET utf8mb4")
                        .HasMaxLength(36);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IsDelete")
                        .HasColumnType("int");

                    b.Property<int>("IsValid")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(36) CHARACTER SET utf8mb4")
                        .HasMaxLength(36);

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("AuthorizationPro.Entity.RoleApiResourceRelation", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(36) CHARACTER SET utf8mb4");

                    b.Property<string>("ApiResourceId")
                        .HasColumnType("varchar(36) CHARACTER SET utf8mb4");

                    b.HasKey("RoleId", "ApiResourceId");

                    b.HasIndex("ApiResourceId");

                    b.ToTable("RoleApiResourceRelation");
                });

            modelBuilder.Entity("AuthorizationPro.Entity.RoleApiResourceRelation", b =>
                {
                    b.HasOne("AuthorizationPro.Entity.ApiResource", "ApiResource")
                        .WithMany("RoleApiResourceRelations")
                        .HasForeignKey("ApiResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AuthorizationPro.Entity.Role", "Role")
                        .WithMany("RoleApiResourceRelations")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
