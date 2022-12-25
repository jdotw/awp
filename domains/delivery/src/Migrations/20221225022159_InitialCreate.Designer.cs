﻿// <auto-generated />
using System;
using Delivery.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Delivery.Migrations
{
  [DbContext(typeof(DeliveryDbContext))]
  [Migration("20221225022159_InitialCreate")]
  partial class InitialCreate
  {
    /// <inheritdoc />
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
          .HasAnnotation("ProductVersion", "7.0.1")
          .HasAnnotation("Relational:MaxIdentifierLength", 63);

      NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

      modelBuilder.Entity("Delivery.Entities.Squad", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("integer")
                      .HasColumnName("id");

            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

            b.Property<DateTimeOffset>("CreatedDate")
                      .HasColumnType("timestamp with time zone")
                      .HasColumnName("created_date");

            b.Property<DateTimeOffset?>("DisbandedDate")
                      .HasColumnType("timestamp with time zone")
                      .HasColumnName("disbanded_date");

            b.Property<DateTimeOffset>("FormedDate")
                      .HasColumnType("timestamp with time zone")
                      .HasColumnName("formed_date");

            b.Property<string>("Name")
                      .IsRequired()
                      .HasColumnType("text")
                      .HasColumnName("name");

            b.Property<DateTimeOffset>("UpdatedDate")
                      .HasColumnType("timestamp with time zone")
                      .HasColumnName("updated_date");

            b.HasKey("Id")
                      .HasName("pk_squads");

            b.ToTable("squads", (string)null);
          });

      modelBuilder.Entity("Delivery.Entities.SquadRole", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("integer")
                      .HasColumnName("id");

            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

            b.Property<DateTimeOffset>("CreatedDate")
                      .HasColumnType("timestamp with time zone")
                      .HasColumnName("created_date");

            b.Property<DateTimeOffset?>("EndDate")
                      .HasColumnType("timestamp with time zone")
                      .HasColumnName("end_date");

            b.Property<int>("IndividualId")
                      .HasColumnType("integer")
                      .HasColumnName("individual_id");

            b.Property<int>("SquadId")
                      .HasColumnType("integer")
                      .HasColumnName("squad_id");

            b.Property<int>("SquadRoleTypeId")
                      .HasColumnType("integer")
                      .HasColumnName("squad_role_type_id");

            b.Property<DateTimeOffset>("StartDate")
                      .HasColumnType("timestamp with time zone")
                      .HasColumnName("start_date");

            b.Property<DateTimeOffset>("UpdatedDate")
                      .HasColumnType("timestamp with time zone")
                      .HasColumnName("updated_date");

            b.HasKey("Id")
                      .HasName("pk_squad_roles");

            b.HasIndex("SquadId")
                      .HasDatabaseName("ix_squad_roles_squad_id");

            b.HasIndex("SquadRoleTypeId")
                      .HasDatabaseName("ix_squad_roles_squad_role_type_id");

            b.ToTable("squad_roles", (string)null);
          });

      modelBuilder.Entity("Delivery.Entities.SquadRoleType", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("integer")
                      .HasColumnName("id");

            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

            b.Property<DateTimeOffset>("CreatedDate")
                      .HasColumnType("timestamp with time zone")
                      .HasColumnName("created_date");

            b.Property<string>("Name")
                      .IsRequired()
                      .HasColumnType("text")
                      .HasColumnName("name");

            b.Property<DateTimeOffset>("UpdatedDate")
                      .HasColumnType("timestamp with time zone")
                      .HasColumnName("updated_date");

            b.HasKey("Id")
                      .HasName("pk_squad_role_types");

            b.ToTable("squad_role_types", (string)null);
          });

      modelBuilder.Entity("Delivery.Entities.Tribe", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("integer")
                      .HasColumnName("id");

            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

            b.Property<DateTimeOffset>("CreatedDate")
                      .HasColumnType("timestamp with time zone")
                      .HasColumnName("created_date");

            b.Property<DateTimeOffset?>("DisbandedDate")
                      .HasColumnType("timestamp with time zone")
                      .HasColumnName("disbanded_date");

            b.Property<DateTimeOffset>("FormedDate")
                      .HasColumnType("timestamp with time zone")
                      .HasColumnName("formed_date");

            b.Property<string>("Name")
                      .IsRequired()
                      .HasColumnType("text")
                      .HasColumnName("name");

            b.Property<DateTimeOffset>("UpdatedDate")
                      .HasColumnType("timestamp with time zone")
                      .HasColumnName("updated_date");

            b.HasKey("Id")
                      .HasName("pk_tribes");

            b.ToTable("tribes", (string)null);
          });

      modelBuilder.Entity("Delivery.Entities.TribeRole", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("integer")
                      .HasColumnName("id");

            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

            b.Property<DateTimeOffset>("CreatedDate")
                      .HasColumnType("timestamp with time zone")
                      .HasColumnName("created_date");

            b.Property<DateTimeOffset?>("EndDate")
                      .HasColumnType("timestamp with time zone")
                      .HasColumnName("end_date");

            b.Property<int>("IndividualId")
                      .HasColumnType("integer")
                      .HasColumnName("individual_id");

            b.Property<DateTimeOffset>("StartDate")
                      .HasColumnType("timestamp with time zone")
                      .HasColumnName("start_date");

            b.Property<int>("TribeId")
                      .HasColumnType("integer")
                      .HasColumnName("tribe_id");

            b.Property<int>("TribeRoleTypeId")
                      .HasColumnType("integer")
                      .HasColumnName("tribe_role_type_id");

            b.Property<DateTimeOffset>("UpdatedDate")
                      .HasColumnType("timestamp with time zone")
                      .HasColumnName("updated_date");

            b.HasKey("Id")
                      .HasName("pk_tribe_roles");

            b.HasIndex("TribeId")
                      .HasDatabaseName("ix_tribe_roles_tribe_id");

            b.HasIndex("TribeRoleTypeId")
                      .HasDatabaseName("ix_tribe_roles_tribe_role_type_id");

            b.ToTable("tribe_roles", (string)null);
          });

      modelBuilder.Entity("Delivery.Entities.TribeRoleType", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("integer")
                      .HasColumnName("id");

            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

            b.Property<DateTimeOffset>("CreatedDate")
                      .HasColumnType("timestamp with time zone")
                      .HasColumnName("created_date");

            b.Property<string>("Name")
                      .IsRequired()
                      .HasColumnType("text")
                      .HasColumnName("name");

            b.Property<DateTimeOffset>("UpdatedDate")
                      .HasColumnType("timestamp with time zone")
                      .HasColumnName("updated_date");

            b.HasKey("Id")
                      .HasName("pk_tribe_role_types");

            b.ToTable("tribe_role_types", (string)null);
          });

      modelBuilder.Entity("Delivery.Entities.SquadRole", b =>
          {
            b.HasOne("Delivery.Entities.Squad", "Squad")
                      .WithMany("SquadRoles")
                      .HasForeignKey("SquadId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired()
                      .HasConstraintName("fk_squad_roles_squads_squad_id");

            b.HasOne("Delivery.Entities.SquadRoleType", "SquadRoleType")
                      .WithMany("SquadRoles")
                      .HasForeignKey("SquadRoleTypeId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired()
                      .HasConstraintName("fk_squad_roles_squad_role_types_squad_role_type_id");

            b.Navigation("Squad");

            b.Navigation("SquadRoleType");
          });

      modelBuilder.Entity("Delivery.Entities.TribeRole", b =>
          {
            b.HasOne("Delivery.Entities.Tribe", "Tribe")
                      .WithMany("TribeRoles")
                      .HasForeignKey("TribeId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired()
                      .HasConstraintName("fk_tribe_roles_tribes_tribe_id");

            b.HasOne("Delivery.Entities.TribeRoleType", "TribeRoleType")
                      .WithMany("TribeRoles")
                      .HasForeignKey("TribeRoleTypeId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired()
                      .HasConstraintName("fk_tribe_roles_tribe_role_types_tribe_role_type_id");

            b.Navigation("Tribe");

            b.Navigation("TribeRoleType");
          });

      modelBuilder.Entity("Delivery.Entities.Squad", b =>
          {
            b.Navigation("SquadRoles");
          });

      modelBuilder.Entity("Delivery.Entities.SquadRoleType", b =>
          {
            b.Navigation("SquadRoles");
          });

      modelBuilder.Entity("Delivery.Entities.Tribe", b =>
          {
            b.Navigation("TribeRoles");
          });

      modelBuilder.Entity("Delivery.Entities.TribeRoleType", b =>
          {
            b.Navigation("TribeRoles");
          });
#pragma warning restore 612, 618
    }
  }
}
