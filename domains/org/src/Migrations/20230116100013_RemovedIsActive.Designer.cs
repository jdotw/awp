﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Org.Repository;

#nullable disable

namespace Org.Migrations
{
    [DbContext(typeof(OrgDbContext))]
    [Migration("20230116100013_RemovedIsActive")]
    partial class RemovedIsActive
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Org.Entities.Chapter", b =>
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

                    b.Property<int>("PracticeId")
                        .HasColumnType("integer")
                        .HasColumnName("practice_id");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_chapters");

                    b.HasIndex("PracticeId")
                        .HasDatabaseName("ix_chapters_practice_id");

                    b.ToTable("chapters", (string)null);
                });

            modelBuilder.Entity("Org.Entities.Function", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ChapterId")
                        .HasColumnType("integer")
                        .HasColumnName("chapter_id");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<DateTimeOffset?>("EndDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("end_date");

                    b.Property<int?>("FunctionTypeId")
                        .HasColumnType("integer")
                        .HasColumnName("function_type_id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int?>("PracticeId")
                        .HasColumnType("integer")
                        .HasColumnName("practice_id");

                    b.Property<int?>("RoleId")
                        .HasColumnType("integer")
                        .HasColumnName("role_id");

                    b.Property<int?>("SquadId")
                        .HasColumnType("integer")
                        .HasColumnName("squad_id");

                    b.Property<DateTimeOffset>("StartDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("start_date");

                    b.Property<int?>("TeamId")
                        .HasColumnType("integer")
                        .HasColumnName("team_id");

                    b.Property<int?>("TribeId")
                        .HasColumnType("integer")
                        .HasColumnName("tribe_id");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_functions");

                    b.HasIndex("ChapterId")
                        .HasDatabaseName("ix_functions_chapter_id");

                    b.HasIndex("FunctionTypeId")
                        .HasDatabaseName("ix_functions_function_type_id");

                    b.HasIndex("PracticeId")
                        .HasDatabaseName("ix_functions_practice_id");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_functions_role_id");

                    b.HasIndex("SquadId")
                        .HasDatabaseName("ix_functions_squad_id");

                    b.HasIndex("TeamId")
                        .HasDatabaseName("ix_functions_team_id");

                    b.HasIndex("TribeId")
                        .HasDatabaseName("ix_functions_tribe_id");

                    b.ToTable("functions", (string)null);
                });

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

            modelBuilder.Entity("Org.Entities.Practice", b =>
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

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_practices");

                    b.ToTable("practices", (string)null);
                });

            modelBuilder.Entity("Org.Entities.Role", b =>
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

                    b.Property<int?>("RoleTypeId")
                        .HasColumnType("integer")
                        .HasColumnName("role_type_id");

                    b.Property<DateTimeOffset>("StartDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("start_date");

                    b.Property<string>("Title")
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_roles");

                    b.HasIndex("PersonId")
                        .HasDatabaseName("ix_roles_person_id");

                    b.HasIndex("RoleTypeId")
                        .HasDatabaseName("ix_roles_role_type_id");

                    b.ToTable("roles", (string)null);
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

                    b.ToTable("role_types", (string)null);
                });

            modelBuilder.Entity("Org.Entities.Squad", b =>
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

                    b.Property<int>("TribeId")
                        .HasColumnType("integer")
                        .HasColumnName("tribe_id");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_squads");

                    b.HasIndex("TribeId")
                        .HasDatabaseName("ix_squads_tribe_id");

                    b.ToTable("squads", (string)null);
                });

            modelBuilder.Entity("Org.Entities.Team", b =>
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

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_teams");

                    b.ToTable("teams", (string)null);
                });

            modelBuilder.Entity("Org.Entities.Tribe", b =>
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

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_tribes");

                    b.ToTable("tribes", (string)null);
                });

            modelBuilder.Entity("Org.Entities.Chapter", b =>
                {
                    b.HasOne("Org.Entities.Practice", "Practice")
                        .WithMany("Chapters")
                        .HasForeignKey("PracticeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_chapters_practices_practice_id");

                    b.Navigation("Practice");
                });

            modelBuilder.Entity("Org.Entities.Function", b =>
                {
                    b.HasOne("Org.Entities.Chapter", "Chapter")
                        .WithMany("Functions")
                        .HasForeignKey("ChapterId")
                        .HasConstraintName("fk_functions_chapters_chapter_id");

                    b.HasOne("Org.Entities.FunctionType", "FunctionType")
                        .WithMany("Functions")
                        .HasForeignKey("FunctionTypeId")
                        .HasConstraintName("fk_functions_function_types_function_type_id");

                    b.HasOne("Org.Entities.Practice", "Practice")
                        .WithMany("Functions")
                        .HasForeignKey("PracticeId")
                        .HasConstraintName("fk_functions_practices_practice_id");

                    b.HasOne("Org.Entities.Role", "Role")
                        .WithMany("Functions")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("fk_functions_roles_role_id");

                    b.HasOne("Org.Entities.Squad", "Squad")
                        .WithMany("Functions")
                        .HasForeignKey("SquadId")
                        .HasConstraintName("fk_functions_squads_squad_id");

                    b.HasOne("Org.Entities.Team", "Team")
                        .WithMany("Functions")
                        .HasForeignKey("TeamId")
                        .HasConstraintName("fk_functions_teams_team_id");

                    b.HasOne("Org.Entities.Tribe", "Tribe")
                        .WithMany("Functions")
                        .HasForeignKey("TribeId")
                        .HasConstraintName("fk_functions_tribes_tribe_id");

                    b.Navigation("Chapter");

                    b.Navigation("FunctionType");

                    b.Navigation("Practice");

                    b.Navigation("Role");

                    b.Navigation("Squad");

                    b.Navigation("Team");

                    b.Navigation("Tribe");
                });

            modelBuilder.Entity("Org.Entities.Role", b =>
                {
                    b.HasOne("Org.Entities.Person", "Person")
                        .WithMany("Roles")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_roles_persons_person_id");

                    b.HasOne("Org.Entities.RoleType", "RoleType")
                        .WithMany("Roles")
                        .HasForeignKey("RoleTypeId")
                        .HasConstraintName("fk_roles_role_types_role_type_id");

                    b.Navigation("Person");

                    b.Navigation("RoleType");
                });

            modelBuilder.Entity("Org.Entities.Squad", b =>
                {
                    b.HasOne("Org.Entities.Tribe", "Tribe")
                        .WithMany("Squads")
                        .HasForeignKey("TribeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_squads_tribes_tribe_id");

                    b.Navigation("Tribe");
                });

            modelBuilder.Entity("Org.Entities.Chapter", b =>
                {
                    b.Navigation("Functions");
                });

            modelBuilder.Entity("Org.Entities.FunctionType", b =>
                {
                    b.Navigation("Functions");
                });

            modelBuilder.Entity("Org.Entities.Person", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Org.Entities.Practice", b =>
                {
                    b.Navigation("Chapters");

                    b.Navigation("Functions");
                });

            modelBuilder.Entity("Org.Entities.Role", b =>
                {
                    b.Navigation("Functions");
                });

            modelBuilder.Entity("Org.Entities.RoleType", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Org.Entities.Squad", b =>
                {
                    b.Navigation("Functions");
                });

            modelBuilder.Entity("Org.Entities.Team", b =>
                {
                    b.Navigation("Functions");
                });

            modelBuilder.Entity("Org.Entities.Tribe", b =>
                {
                    b.Navigation("Functions");

                    b.Navigation("Squads");
                });
#pragma warning restore 612, 618
        }
    }
}
