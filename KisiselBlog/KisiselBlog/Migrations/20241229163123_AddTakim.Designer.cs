﻿// <auto-generated />
using KisiselBlog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KisiselBlog.Migrations
{
    [DbContext(typeof(KisiselBlogContext))]
    [Migration("20241229163123_AddTakim")]
    partial class AddTakim
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KisiselBlog.Models.AdminLogin", b =>
                {
                    b.Property<int>("LoginID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoginID"));

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoginID");

                    b.ToTable("adminLogins");
                });

            modelBuilder.Entity("KisiselBlog.Models.Anasayfa", b =>
                {
                    b.Property<int>("AnasayfaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnasayfaID"));

                    b.Property<string>("Aciklama1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Aciklama2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnasayfaID");

                    b.ToTable("anasayfas");
                });

            modelBuilder.Entity("KisiselBlog.Models.AnasayfaImage", b =>
                {
                    b.Property<int>("AnasayfaImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnasayfaImageID"));

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnasayfaImageID");

                    b.ToTable("anasayfaImages");
                });

            modelBuilder.Entity("KisiselBlog.Models.BlogPost", b =>
                {
                    b.Property<int>("BlogPostID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlogPostID"));

                    b.Property<string>("AdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KısaBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParagrafBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pozisyon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TakımImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TarihBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogPostID");

                    b.ToTable("blogPosts");
                });

            modelBuilder.Entity("KisiselBlog.Models.Menu1", b =>
                {
                    b.Property<int>("Menu1ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Menu1ID"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Menu1ID");

                    b.ToTable("Menu1s");
                });

            modelBuilder.Entity("KisiselBlog.Models.Menu2", b =>
                {
                    b.Property<int>("Menu2ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Menu2ID"));

                    b.Property<string>("Aciklama1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Aciklama2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Aciklama3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Menu2ID");

                    b.ToTable("Menu2s");
                });

            modelBuilder.Entity("KisiselBlog.Models.Misyon", b =>
                {
                    b.Property<int>("MisyonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MisyonID"));

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Misyon1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Misyon2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MisyonImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MisyonID");

                    b.ToTable("misyons");
                });

            modelBuilder.Entity("KisiselBlog.Models.Portfolio", b =>
                {
                    b.Property<int>("PortfolioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PortfolioID"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sinif1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sinif2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PortfolioID");

                    b.ToTable("portfolios");
                });

            modelBuilder.Entity("KisiselBlog.Models.Takim", b =>
                {
                    b.Property<int>("TakimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TakimID"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BtnUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ozellik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pozisyon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TakimID");

                    b.ToTable("takims");
                });
#pragma warning restore 612, 618
        }
    }
}
