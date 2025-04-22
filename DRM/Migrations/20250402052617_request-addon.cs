using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DRM.Migrations
{
    /// <inheritdoc />
    public partial class requestaddon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    VideoId = table.Column<Guid>(type: "uuid", nullable: true),
                    PdfId = table.Column<Guid>(type: "uuid", nullable: true),
                    AudioId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsAccepted = table.Column<bool>(type: "boolean", nullable: false),
                    RequestedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_AudioFiles_AudioId",
                        column: x => x.AudioId,
                        principalTable: "AudioFiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Requests_PdfFiles_PdfId",
                        column: x => x.PdfId,
                        principalTable: "PdfFiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Requests_VideoFiles_VideoId",
                        column: x => x.VideoId,
                        principalTable: "VideoFiles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_AudioId",
                table: "Requests",
                column: "AudioId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_PdfId",
                table: "Requests",
                column: "PdfId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_UserId",
                table: "Requests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_VideoId",
                table: "Requests",
                column: "VideoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");
        }
    }
}
