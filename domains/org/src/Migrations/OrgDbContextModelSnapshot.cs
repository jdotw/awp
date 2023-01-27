﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Org.Repository;

#nullable disable

namespace Org.Migrations
{
    [DbContext(typeof(OrgDbContext))]
    partial class OrgDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Org.Entities.FunctionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("ActiveFromDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("active_from_date");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTimeOffset?>("RetiredAtDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("retired_at_date");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_function_types");

                    b.ToTable("function_types", (string)null);
                });

            modelBuilder.Entity("Org.Entities.Level", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("ActiveFromDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("active_from_date");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<string>("IndividualContributorTitle")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("individual_contributor_title");

                    b.Property<string>("ManagerTitle")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("manager_title");

                    b.Property<DateTimeOffset>("RetiredAtDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("retired_at_date");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_levels");

                    b.ToTable("levels", (string)null);
                });

            modelBuilder.Entity("Org.Entities.LevelAssignment", b =>
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

                    b.Property<int>("LevelId")
                        .HasColumnType("integer")
                        .HasColumnName("level_id");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer")
                        .HasColumnName("role_id");

                    b.Property<DateTimeOffset>("StartDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("start_date");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_level_assignments");

                    b.HasIndex("LevelId")
                        .HasDatabaseName("ix_level_assignments_level_id");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_level_assignments_role_id");

                    b.ToTable("level_assignments", (string)null);
                });

            modelBuilder.Entity("Org.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("external_id");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<string>("MiddleNames")
                        .HasColumnType("text")
                        .HasColumnName("middle_names");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_persons");

                    b.ToTable("persons", (string)null);
                });

            modelBuilder.Entity("Org.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset?>("ClosedAtDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("closed_at_date");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<DateTimeOffset>("OpenFromDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("open_from_date");

                    b.Property<int?>("RoleTypeId")
                        .HasColumnType("integer")
                        .HasColumnName("role_type_id");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_roles");

                    b.HasIndex("RoleTypeId")
                        .HasDatabaseName("ix_roles_role_type_id");

                    b.ToTable("roles", (string)null);
                });

            modelBuilder.Entity("Org.Entities.RoleAssignment", b =>
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

                    b.Property<int>("PersonId")
                        .HasColumnType("integer")
                        .HasColumnName("person_id");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer")
                        .HasColumnName("role_id");

                    b.Property<DateTimeOffset>("StartDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("start_date");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_role_assignments");

                    b.HasIndex("PersonId")
                        .HasDatabaseName("ix_role_assignments_person_id");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_role_assignments_role_id");

                    b.ToTable("role_assignments", (string)null);
                });

            modelBuilder.Entity("Org.Entities.RoleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("ActiveFromDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("active_from_date");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<int?>("ParentRoleTypeId")
                        .HasColumnType("integer")
                        .HasColumnName("parent_role_type_id");

                    b.Property<DateTimeOffset?>("RetiredAtDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("retired_at_date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_role_types");

                    b.HasIndex("ParentRoleTypeId")
                        .HasDatabaseName("ix_role_types_parent_role_type_id");

                    b.ToTable("role_types", (string)null);
                });

            modelBuilder.Entity("Org.Entities.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

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

                    b.Property<string>("UnitType")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("unit_type");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_units");

                    b.ToTable("units", (string)null);

                    b.HasDiscriminator<string>("UnitType").HasValue("Unit");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Org.Entities.UnitAssignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("discriminator");

                    b.Property<DateTimeOffset?>("EndDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("end_date");

                    b.Property<int>("FunctionTypeId")
                        .HasColumnType("integer")
                        .HasColumnName("function_type_id");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer")
                        .HasColumnName("role_id");

                    b.Property<DateTimeOffset>("StartDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("start_date");

                    b.Property<int?>("UnitId")
                        .HasColumnType("integer")
                        .HasColumnName("unit_id");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_unit_assignments");

                    b.HasIndex("FunctionTypeId")
                        .HasDatabaseName("ix_unit_assignments_function_type_id");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_unit_assignments_role_id");

                    b.HasIndex("UnitId")
                        .HasDatabaseName("ix_unit_assignments_unit_id");

                    b.ToTable("unit_assignments", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("UnitAssignment");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Org.Entities.Chapter", b =>
                {
                    b.HasBaseType("Org.Entities.Unit");

                    b.Property<int>("PracticeId")
                        .HasColumnType("integer")
                        .HasColumnName("practice_id");

                    b.HasIndex("PracticeId")
                        .HasDatabaseName("ix_units_practice_id");

                    b.HasDiscriminator().HasValue("chapter");
                });

            modelBuilder.Entity("Org.Entities.Practice", b =>
                {
                    b.HasBaseType("Org.Entities.Unit");

                    b.HasDiscriminator().HasValue("practice");
                });

            modelBuilder.Entity("Org.Entities.Squad", b =>
                {
                    b.HasBaseType("Org.Entities.Unit");

                    b.Property<int>("TribeId")
                        .HasColumnType("integer")
                        .HasColumnName("tribe_id");

                    b.HasIndex("TribeId")
                        .HasDatabaseName("ix_units_tribe_id");

                    b.HasDiscriminator().HasValue("squad");
                });

            modelBuilder.Entity("Org.Entities.Team", b =>
                {
                    b.HasBaseType("Org.Entities.Unit");

                    b.HasDiscriminator().HasValue("team");
                });

            modelBuilder.Entity("Org.Entities.Tribe", b =>
                {
                    b.HasBaseType("Org.Entities.Unit");

                    b.HasDiscriminator().HasValue("tribe");
                });

            modelBuilder.Entity("Org.Entities.ChapterAssignment", b =>
                {
                    b.HasBaseType("Org.Entities.UnitAssignment");

                    b.Property<int>("ChapterId")
                        .HasColumnType("integer")
                        .HasColumnName("chapter_id");

                    b.HasIndex("ChapterId")
                        .HasDatabaseName("ix_unit_assignments_chapter_id");

                    b.HasDiscriminator().HasValue("ChapterAssignment");
                });

            modelBuilder.Entity("Org.Entities.PracticeAssignment", b =>
                {
                    b.HasBaseType("Org.Entities.UnitAssignment");

                    b.Property<int>("PracticeId")
                        .HasColumnType("integer")
                        .HasColumnName("practice_id");

                    b.HasIndex("PracticeId")
                        .HasDatabaseName("ix_unit_assignments_practice_id");

                    b.HasDiscriminator().HasValue("PracticeAssignment");
                });

            modelBuilder.Entity("Org.Entities.SquadAssignment", b =>
                {
                    b.HasBaseType("Org.Entities.UnitAssignment");

                    b.Property<int>("SquadId")
                        .HasColumnType("integer")
                        .HasColumnName("squad_id");

                    b.HasIndex("SquadId")
                        .HasDatabaseName("ix_unit_assignments_squad_id");

                    b.HasDiscriminator().HasValue("SquadAssignment");
                });

            modelBuilder.Entity("Org.Entities.TeamAssignment", b =>
                {
                    b.HasBaseType("Org.Entities.UnitAssignment");

                    b.Property<int>("TeamId")
                        .HasColumnType("integer")
                        .HasColumnName("team_id");

                    b.HasIndex("TeamId")
                        .HasDatabaseName("ix_unit_assignments_team_id");

                    b.HasDiscriminator().HasValue("TeamAssignment");
                });

            modelBuilder.Entity("Org.Entities.TribeAssignment", b =>
                {
                    b.HasBaseType("Org.Entities.UnitAssignment");

                    b.Property<int>("TribeId")
                        .HasColumnType("integer")
                        .HasColumnName("tribe_id");

                    b.HasIndex("TribeId")
                        .HasDatabaseName("ix_unit_assignments_tribe_id");

                    b.HasDiscriminator().HasValue("TribeAssignment");
                });

            modelBuilder.Entity("Org.Entities.LevelAssignment", b =>
                {
                    b.HasOne("Org.Entities.Level", "Level")
                        .WithMany("LevelAssignments")
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_level_assignments_levels_level_id");

                    b.HasOne("Org.Entities.Role", "Role")
                        .WithMany("LevelAssignments")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_level_assignments_roles_role_id");

                    b.Navigation("Level");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Org.Entities.Role", b =>
                {
                    b.HasOne("Org.Entities.RoleType", "RoleType")
                        .WithMany("Roles")
                        .HasForeignKey("RoleTypeId")
                        .HasConstraintName("fk_roles_role_types_role_type_id");

                    b.Navigation("RoleType");
                });

            modelBuilder.Entity("Org.Entities.RoleAssignment", b =>
                {
                    b.HasOne("Org.Entities.Person", "Person")
                        .WithMany("RoleAssignments")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_role_assignments_persons_person_id");

                    b.HasOne("Org.Entities.Role", "Role")
                        .WithMany("RoleAssignments")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_role_assignments_roles_role_id");

                    b.Navigation("Person");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Org.Entities.RoleType", b =>
                {
                    b.HasOne("Org.Entities.RoleType", "ParentRoleType")
                        .WithMany("ChildRoleTypes")
                        .HasForeignKey("ParentRoleTypeId")
                        .HasConstraintName("fk_role_types_role_types_parent_role_type_id");

                    b.Navigation("ParentRoleType");
                });

            modelBuilder.Entity("Org.Entities.UnitAssignment", b =>
                {
                    b.HasOne("Org.Entities.FunctionType", "FunctionType")
                        .WithMany("UnitAssignments")
                        .HasForeignKey("FunctionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_unit_assignments_function_types_function_type_id");

                    b.HasOne("Org.Entities.Role", "Role")
                        .WithMany("UnitAssignments")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_unit_assignments_roles_role_id");

                    b.HasOne("Org.Entities.Unit", null)
                        .WithMany("UnitAssignments")
                        .HasForeignKey("UnitId")
                        .HasConstraintName("fk_unit_assignments_units_unit_id");

                    b.Navigation("FunctionType");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Org.Entities.Chapter", b =>
                {
                    b.HasOne("Org.Entities.Practice", "Practice")
                        .WithMany("Chapters")
                        .HasForeignKey("PracticeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_units_units_practice_id");

                    b.Navigation("Practice");
                });

            modelBuilder.Entity("Org.Entities.Squad", b =>
                {
                    b.HasOne("Org.Entities.Tribe", "Tribe")
                        .WithMany("Squads")
                        .HasForeignKey("TribeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_units_units_tribe_id");

                    b.Navigation("Tribe");
                });

            modelBuilder.Entity("Org.Entities.ChapterAssignment", b =>
                {
                    b.HasOne("Org.Entities.Chapter", "Chapter")
                        .WithMany()
                        .HasForeignKey("ChapterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_unit_assignments_units_chapter_id");

                    b.Navigation("Chapter");
                });

            modelBuilder.Entity("Org.Entities.PracticeAssignment", b =>
                {
                    b.HasOne("Org.Entities.Practice", "Practice")
                        .WithMany()
                        .HasForeignKey("PracticeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_unit_assignments_units_practice_id");

                    b.Navigation("Practice");
                });

            modelBuilder.Entity("Org.Entities.SquadAssignment", b =>
                {
                    b.HasOne("Org.Entities.Squad", "Squad")
                        .WithMany()
                        .HasForeignKey("SquadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_unit_assignments_units_squad_id");

                    b.Navigation("Squad");
                });

            modelBuilder.Entity("Org.Entities.TeamAssignment", b =>
                {
                    b.HasOne("Org.Entities.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_unit_assignments_units_team_id");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Org.Entities.TribeAssignment", b =>
                {
                    b.HasOne("Org.Entities.Tribe", "Tribe")
                        .WithMany()
                        .HasForeignKey("TribeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_unit_assignments_units_tribe_id");

                    b.Navigation("Tribe");
                });

            modelBuilder.Entity("Org.Entities.FunctionType", b =>
                {
                    b.Navigation("UnitAssignments");
                });

            modelBuilder.Entity("Org.Entities.Level", b =>
                {
                    b.Navigation("LevelAssignments");
                });

            modelBuilder.Entity("Org.Entities.Person", b =>
                {
                    b.Navigation("RoleAssignments");
                });

            modelBuilder.Entity("Org.Entities.Role", b =>
                {
                    b.Navigation("LevelAssignments");

                    b.Navigation("RoleAssignments");

                    b.Navigation("UnitAssignments");
                });

            modelBuilder.Entity("Org.Entities.RoleType", b =>
                {
                    b.Navigation("ChildRoleTypes");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Org.Entities.Unit", b =>
                {
                    b.Navigation("UnitAssignments");
                });

            modelBuilder.Entity("Org.Entities.Practice", b =>
                {
                    b.Navigation("Chapters");
                });

            modelBuilder.Entity("Org.Entities.Tribe", b =>
                {
                    b.Navigation("Squads");
                });
#pragma warning restore 612, 618
        }
    }
}
