﻿// <auto-generated />
using System;
using CMRWebApi.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CMRWebApi.Migrations
{
    [DbContext(typeof(CMRDbContext))]
    [Migration("20221204151823_ComposerHasPieces")]
    partial class ComposerHasPieces
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CMRWebApi.Models.AudioRecording", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("AudioPath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImagePath")
                        .HasColumnType("longtext");

                    b.Property<string>("Performers")
                        .HasColumnType("longtext");

                    b.Property<Guid>("PieceId")
                        .HasColumnType("char(36)");

                    b.Property<string>("RecordLabel")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("PieceId");

                    b.ToTable("AudioRecordings");
                });

            modelBuilder.Entity("CMRWebApi.Models.Composer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Birth")
                        .HasColumnType("longtext");

                    b.Property<string>("Death")
                        .HasColumnType("longtext");

                    b.Property<string>("History")
                        .HasMaxLength(5000)
                        .HasColumnType("varchar(5000)");

                    b.Property<string>("ImgPath")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nationality")
                        .HasColumnType("longtext");

                    b.Property<string>("Period")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Composers");
                });

            modelBuilder.Entity("CMRWebApi.Models.Instrument", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Instruments");
                });

            modelBuilder.Entity("CMRWebApi.Models.InstrumentPiece", b =>
                {
                    b.Property<Guid>("InstrumentId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PieceId")
                        .HasColumnType("char(36)");

                    b.HasKey("InstrumentId", "PieceId");

                    b.HasIndex("PieceId");

                    b.ToTable("InstrumentPieces");
                });

            modelBuilder.Entity("CMRWebApi.Models.Piece", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Catalog")
                        .HasColumnType("longtext");

                    b.Property<Guid>("ComposerId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Movements")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("TonalityId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Year")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ComposerId");

                    b.HasIndex("TonalityId");

                    b.ToTable("Pieces");
                });

            modelBuilder.Entity("CMRWebApi.Models.SheetMusic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PieceId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("PieceId");

                    b.ToTable("SheetMusic");
                });

            modelBuilder.Entity("CMRWebApi.Models.Tonality", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Tonality");
                });

            modelBuilder.Entity("CMRWebApi.Models.VideoRecording", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Channel")
                        .HasColumnType("longtext");

                    b.Property<string>("Performers")
                        .HasColumnType("longtext");

                    b.Property<Guid>("PieceId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("PieceId");

                    b.ToTable("VideoRecordings");
                });

            modelBuilder.Entity("CMRWebApi.Models.AudioRecording", b =>
                {
                    b.HasOne("CMRWebApi.Models.Piece", "Piece")
                        .WithMany("AudioRecordings")
                        .HasForeignKey("PieceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Piece");
                });

            modelBuilder.Entity("CMRWebApi.Models.InstrumentPiece", b =>
                {
                    b.HasOne("CMRWebApi.Models.Instrument", "Instrument")
                        .WithMany("InstrumentPieces")
                        .HasForeignKey("InstrumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMRWebApi.Models.Piece", "Piece")
                        .WithMany("InstrumentPieces")
                        .HasForeignKey("PieceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instrument");

                    b.Navigation("Piece");
                });

            modelBuilder.Entity("CMRWebApi.Models.Piece", b =>
                {
                    b.HasOne("CMRWebApi.Models.Composer", "Composer")
                        .WithMany("Pieces")
                        .HasForeignKey("ComposerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMRWebApi.Models.Tonality", "Tonality")
                        .WithMany("Pieces")
                        .HasForeignKey("TonalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Composer");

                    b.Navigation("Tonality");
                });

            modelBuilder.Entity("CMRWebApi.Models.SheetMusic", b =>
                {
                    b.HasOne("CMRWebApi.Models.Piece", "Piece")
                        .WithMany("SheetMusic")
                        .HasForeignKey("PieceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Piece");
                });

            modelBuilder.Entity("CMRWebApi.Models.VideoRecording", b =>
                {
                    b.HasOne("CMRWebApi.Models.Piece", "Piece")
                        .WithMany("VideoRecordings")
                        .HasForeignKey("PieceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Piece");
                });

            modelBuilder.Entity("CMRWebApi.Models.Composer", b =>
                {
                    b.Navigation("Pieces");
                });

            modelBuilder.Entity("CMRWebApi.Models.Instrument", b =>
                {
                    b.Navigation("InstrumentPieces");
                });

            modelBuilder.Entity("CMRWebApi.Models.Piece", b =>
                {
                    b.Navigation("AudioRecordings");

                    b.Navigation("InstrumentPieces");

                    b.Navigation("SheetMusic");

                    b.Navigation("VideoRecordings");
                });

            modelBuilder.Entity("CMRWebApi.Models.Tonality", b =>
                {
                    b.Navigation("Pieces");
                });
#pragma warning restore 612, 618
        }
    }
}