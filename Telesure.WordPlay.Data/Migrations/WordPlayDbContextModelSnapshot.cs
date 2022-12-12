﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Telesure.WordPlay.Data;

#nullable disable

namespace Telesure.WordPlay.Data.Migrations
{
    [DbContext(typeof(WordPlayDbContext))]
    partial class WordPlayDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Telesure.WordPlay.Data.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Designation")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Telesure.WordPlay.Data.Sentence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Phrase")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Sentences");
                });

            modelBuilder.Entity("Telesure.WordPlay.Data.Word", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("WordTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WordTypeId");

                    b.ToTable("Words");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "He",
                            WordTypeId = 5
                        },
                        new
                        {
                            Id = 2,
                            Name = "Grudgingly",
                            WordTypeId = 4
                        },
                        new
                        {
                            Id = 3,
                            Name = "1Life",
                            WordTypeId = 1
                        });
                });

            modelBuilder.Entity("Telesure.WordPlay.Data.WordType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("WordTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Noun"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Verb"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Adjective"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Adverb"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Pronoun"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Preposition"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Conjunction"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Determiner"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Exclamation"
                        });
                });

            modelBuilder.Entity("Telesure.WordPlay.Data.Word", b =>
                {
                    b.HasOne("Telesure.WordPlay.Data.WordType", "WordType")
                        .WithMany("Words")
                        .HasForeignKey("WordTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WordType");
                });

            modelBuilder.Entity("Telesure.WordPlay.Data.WordType", b =>
                {
                    b.Navigation("Words");
                });
#pragma warning restore 612, 618
        }
    }
}
