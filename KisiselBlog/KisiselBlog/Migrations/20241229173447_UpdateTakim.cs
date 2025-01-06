using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KisiselBlog.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTakim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BtnUrl",
                table: "takims");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BtnUrl",
                table: "takims",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
