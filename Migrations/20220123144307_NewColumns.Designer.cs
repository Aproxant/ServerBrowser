﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServerBrowser.Entities;

namespace ServerBrowser.Migrations
{
    [DbContext(typeof(ServersDBContext))]
    [Migration("20220123144307_NewColumns")]
    partial class NewColumns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ServerBrowser.Entities.Servers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Mode")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("lastActive")
                        .HasColumnType("datetime2");

                    b.Property<int>("playerNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ServerList");
                });
#pragma warning restore 612, 618
        }
    }
}
