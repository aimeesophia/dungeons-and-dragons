﻿// <auto-generated />
using System;
using DungeonsAndDragons.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DungeonsAndDragons.Migrations
{
    [DbContext(typeof(DungeonsAndDragonsContext))]
    partial class DungeonsAndDragonsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DungeonsAndDragons.Models.Battle", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("gameid");

                    b.Property<int>("npc");

                    b.HasKey("id");

                    b.ToTable("battles");
                });

            modelBuilder.Entity("DungeonsAndDragons.Models.Game", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("dm");

                    b.Property<string>("name")
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.ToTable("games");
                });

            modelBuilder.Entity("DungeonsAndDragons.Models.GameUser", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("gameid");

                    b.Property<int?>("playablecharacterid");

                    b.Property<int>("userid");

                    b.HasKey("id");

                    b.ToTable("gamesusers");
                });

            modelBuilder.Entity("DungeonsAndDragons.Models.NonPlayableCharacter", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("attack");

                    b.Property<int>("gameid");

                    b.Property<int>("hp");

                    b.Property<string>("name")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("species_id");

                    b.HasKey("id");

                    b.ToTable("nonplayablecharacters");
                });

            modelBuilder.Entity("DungeonsAndDragons.Models.PlayableCharacter", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("attack");

                    b.Property<int>("hp");

                    b.Property<string>("name")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("species_id");

                    b.Property<int>("userid");

                    b.HasKey("id");

                    b.ToTable("playablecharacters");
                });

            modelBuilder.Entity("DungeonsAndDragons.Models.Species", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("base_attack");

                    b.Property<int>("base_hp");

                    b.Property<string>("image_path")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("species_type")
                        .HasColumnType("varchar(20)");

                    b.HasKey("id");

                    b.ToTable("species");
                });

            modelBuilder.Entity("DungeonsAndDragons.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("password")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("username")
                        .HasColumnType("varchar(20)");

                    b.HasKey("id");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
