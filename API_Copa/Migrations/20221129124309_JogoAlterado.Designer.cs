﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Models;

namespace API_Copa.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221129124309_JogoAlterado")]
    partial class JogoAlterado
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("API_Copa.Models.Jogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<int>("placarA")
                        .HasColumnType("INTEGER");

                    b.Property<int>("placarB")
                        .HasColumnType("INTEGER");

                    b.Property<int>("selecaoAId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("selecaoBId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("selecaoAId");

                    b.HasIndex("selecaoBId");

                    b.ToTable("Jogos");
                });

            modelBuilder.Entity("API_Copa.Models.Selecao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Selecoes");
                });

            modelBuilder.Entity("API_Copa.Models.Jogo", b =>
                {
                    b.HasOne("API_Copa.Models.Selecao", "SelecaoA")
                        .WithMany()
                        .HasForeignKey("selecaoAId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_Copa.Models.Selecao", "SelecaoB")
                        .WithMany()
                        .HasForeignKey("selecaoBId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SelecaoA");

                    b.Navigation("SelecaoB");
                });
#pragma warning restore 612, 618
        }
    }
}
