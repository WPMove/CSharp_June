﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TwoFormsOnePage.Models;

namespace TwoFormsOnePage.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200611212707_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TwoFormsOnePage.Models.Liquor", b =>
                {
                    b.Property<int>("LiquorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("Proof");

                    b.Property<string>("Type");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("LiquorId");

                    b.ToTable("Liquors");
                });

            modelBuilder.Entity("TwoFormsOnePage.Models.Mixer", b =>
                {
                    b.Property<int>("MixerId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Flavor");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("MixerId");

                    b.ToTable("Mixers");
                });
#pragma warning restore 612, 618
        }
    }
}
