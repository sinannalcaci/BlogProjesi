using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogProjesi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Images_ImageUrlId",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "ImageUrlId",
                table: "Articles",
                newName: "ImageId");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_ImageUrlId",
                table: "Articles",
                newName: "IX_Articles_ImageId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "ImageId",
                table: "Articles",
                newName: "ImageUrlId");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_ImageId",
                table: "Articles",
                newName: "IX_Articles_ImageUrlId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Images_ImageUrlId",
                table: "Articles",
                column: "ImageUrlId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
