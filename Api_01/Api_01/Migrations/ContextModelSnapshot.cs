﻿// <auto-generated />
using Api_01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api_01.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("Api_01.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Height");

                    b.Property<string>("Tags");

                    b.Property<string>("Title");

                    b.Property<string>("Uploaded");

                    b.Property<string>("Url");

                    b.Property<string>("Width");

                    b.HasKey("Id");

                    b.ToTable("Class");
                });
#pragma warning restore 612, 618
        }
    }
}