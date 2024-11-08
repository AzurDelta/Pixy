﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using pixy.Repository;

#nullable disable

namespace pixy.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240702143817_crew members add")]
    partial class crewmembersadd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("pixy.CrewMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("BaseAttack")
                        .HasColumnType("double precision");

                    b.Property<double>("BaseEngine")
                        .HasColumnType("double precision");

                    b.Property<double>("BasePilot")
                        .HasColumnType("double precision");

                    b.Property<double>("BaseRepair")
                        .HasColumnType("double precision");

                    b.Property<double>("BaseScience")
                        .HasColumnType("double precision");

                    b.Property<double>("BaseWeapon")
                        .HasColumnType("double precision");

                    b.Property<int>("CharacterBodyPartId")
                        .HasColumnType("integer");

                    b.Property<string>("CharacterDesignDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CharacterHeadPartId")
                        .HasColumnType("integer");

                    b.Property<int>("CharacterLegPartId")
                        .HasColumnType("integer");

                    b.Property<int>("CollectionDesignId")
                        .HasColumnType("integer");

                    b.Property<int>("EquipmentMask")
                        .HasColumnType("integer");

                    b.Property<double>("FinalAttack")
                        .HasColumnType("double precision");

                    b.Property<double>("FinalEngine")
                        .HasColumnType("double precision");

                    b.Property<int>("FinalHp")
                        .HasColumnType("integer");

                    b.Property<double>("FinalPilot")
                        .HasColumnType("double precision");

                    b.Property<double>("FinalRepair")
                        .HasColumnType("double precision");

                    b.Property<double>("FinalScience")
                        .HasColumnType("double precision");

                    b.Property<double>("FinalWeapon")
                        .HasColumnType("double precision");

                    b.Property<int>("FireResistance")
                        .HasColumnType("integer");

                    b.Property<int>("Hp")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Rarity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RunSpeed")
                        .HasColumnType("integer");

                    b.Property<double>("SpecialAbilityBaseArgument")
                        .HasColumnType("double precision");

                    b.Property<double>("SpecialAbilityFinalArgument")
                        .HasColumnType("double precision");

                    b.Property<string>("SpecialAbilityType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TrainingCapacity")
                        .HasColumnType("integer");

                    b.Property<int>("WalkingSpeed")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("CrewMembers");
                });

            modelBuilder.Entity("pixy.Prestige", b =>
                {
                    b.Property<int>("PrestigeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PrestigeID"));

                    b.Property<int>("MemberOneId")
                        .HasColumnType("integer");

                    b.Property<int>("MemberTwoId")
                        .HasColumnType("integer");

                    b.Property<double?>("PrestigeValue")
                        .HasColumnType("double precision");

                    b.Property<int>("ResultMemberId")
                        .HasColumnType("integer");

                    b.HasKey("PrestigeID");

                    b.ToTable("Prestiges");
                });
#pragma warning restore 612, 618
        }
    }
}
