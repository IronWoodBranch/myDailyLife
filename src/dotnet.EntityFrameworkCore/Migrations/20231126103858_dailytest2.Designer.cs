﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet.EntityFrameworkCore;

#nullable disable

namespace dotnet.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(dotnetDbContext))]
    [Migration("20231126103858_dailytest2")]
    partial class dailytest2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("dotnet.Domain.PaymentInfo.singlePayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("支出");

                    b.Property<string>("remark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("消费内容");

                    b.HasKey("Id");

                    b.ToTable("singlePayment");
                });
#pragma warning restore 612, 618
        }
    }
}
