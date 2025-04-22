using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DRM.Migrations
{
    /// <inheritdoc />
    public partial class ForiegnKeyIssue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_AudioFiles_AudioId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_PdfFiles_PdfId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_VideoFiles_VideoId",
                table: "Requests");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_AudioFiles_AudioId",
                table: "Requests",
                column: "AudioId",
                principalTable: "AudioFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_PdfFiles_PdfId",
                table: "Requests",
                column: "PdfId",
                principalTable: "PdfFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_VideoFiles_VideoId",
                table: "Requests",
                column: "VideoId",
                principalTable: "VideoFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_AudioFiles_AudioId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_PdfFiles_PdfId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_VideoFiles_VideoId",
                table: "Requests");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_AudioFiles_AudioId",
                table: "Requests",
                column: "AudioId",
                principalTable: "AudioFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_PdfFiles_PdfId",
                table: "Requests",
                column: "PdfId",
                principalTable: "PdfFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_VideoFiles_VideoId",
                table: "Requests",
                column: "VideoId",
                principalTable: "VideoFiles",
                principalColumn: "Id");
        }
    }
}
