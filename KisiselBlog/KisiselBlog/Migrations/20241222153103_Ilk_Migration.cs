using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KisiselBlog.Migrations
{
    /// <inheritdoc />
    public partial class Ilk_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "adminLogins",
                columns: table => new
                {
                    LoginID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adminLogins", x => x.LoginID);
                });

            migrationBuilder.CreateTable(
                name: "anasayfaImages",
                columns: table => new
                {
                    AnasayfaImageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anasayfaImages", x => x.AnasayfaImageID);
                });

            migrationBuilder.CreateTable(
                name: "anasayfas",
                columns: table => new
                {
                    AnasayfaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anasayfas", x => x.AnasayfaID);
                });

            migrationBuilder.CreateTable(
                name: "blogPosts",
                columns: table => new
                {
                    BlogPostID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KısaBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TarihBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParagrafBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TakımImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pozisyon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogPosts", x => x.BlogPostID);
                });

            migrationBuilder.CreateTable(
                name: "misyons",
                columns: table => new
                {
                    MisyonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Misyon1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Misyon2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MisyonImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_misyons", x => x.MisyonID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "adminLogins");

            migrationBuilder.DropTable(
                name: "anasayfaImages");

            migrationBuilder.DropTable(
                name: "anasayfas");

            migrationBuilder.DropTable(
                name: "blogPosts");

            migrationBuilder.DropTable(
                name: "misyons");
        }
    }
}
