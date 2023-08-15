using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogProjesi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedByDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("0adc455e-c18e-47d1-a5c0-b808227d78cf"), "Admin Test", new DateTime(2023, 8, 15, 15, 43, 39, 105, DateTimeKind.Local).AddTicks(4349), null, null, false, null, null, "Asp.Net Core" },
                    { new Guid("8caa2c38-f5f2-451a-871f-35e1bcf2fb77"), "Admin Test", new DateTime(2023, 8, 15, 15, 43, 39, 105, DateTimeKind.Local).AddTicks(4352), null, null, false, null, null, "Visual Studio 2022" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedByDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("17836af8-a6ec-4ad2-9215-752f35927c84"), "Admin Test", new DateTime(2023, 8, 15, 15, 43, 39, 105, DateTimeKind.Local).AddTicks(4429), null, null, "images/testimage", "jpg", false, null, null },
                    { new Guid("17e53d0d-01dd-4ece-8d67-b234785b605e"), "Admin Test", new DateTime(2023, 8, 15, 15, 43, 39, 105, DateTimeKind.Local).AddTicks(4432), null, null, "images/vstest", "png", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedByDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("05b3d77b-6c80-425d-9eec-079b7c29b66c"), new Guid("0adc455e-c18e-47d1-a5c0-b808227d78cf"), "Asp.net Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2023, 8, 15, 15, 43, 39, 105, DateTimeKind.Local).AddTicks(4177), null, null, new Guid("17836af8-a6ec-4ad2-9215-752f35927c84"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 },
                    { new Guid("7d140695-547f-4e28-92d6-666f8ed550a6"), new Guid("8caa2c38-f5f2-451a-871f-35e1bcf2fb77"), "Visual Studio Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2023, 8, 15, 15, 43, 39, 105, DateTimeKind.Local).AddTicks(4184), null, null, new Guid("17e53d0d-01dd-4ece-8d67-b234785b605e"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("05b3d77b-6c80-425d-9eec-079b7c29b66c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7d140695-547f-4e28-92d6-666f8ed550a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0adc455e-c18e-47d1-a5c0-b808227d78cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8caa2c38-f5f2-451a-871f-35e1bcf2fb77"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("17836af8-a6ec-4ad2-9215-752f35927c84"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("17e53d0d-01dd-4ece-8d67-b234785b605e"));
        }
    }
}
