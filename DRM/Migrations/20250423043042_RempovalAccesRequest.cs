using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DRM.Migrations
{
    /// <inheritdoc />
    public partial class RempovalAccesRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignUsers");

            migrationBuilder.DropTable(
                name: "Requests");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssignUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AudioId = table.Column<Guid>(type: "uuid", nullable: true),
                    PdfId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    VideoId = table.Column<Guid>(type: "uuid", nullable: true),
                    AssignedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Year = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssignUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignUsers_AudioFiles_AudioId",
                        column: x => x.AudioId,
                        principalTable: "AudioFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_AssignUsers_PdfFiles_PdfId",
                        column: x => x.PdfId,
                        principalTable: "PdfFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_AssignUsers_VideoFiles_VideoId",
                        column: x => x.VideoId,
                        principalTable: "VideoFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AudioId = table.Column<Guid>(type: "uuid", nullable: true),
                    PdfId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    VideoId = table.Column<Guid>(type: "uuid", nullable: true),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Requests_PdfFiles_PdfId",
                        column: x => x.PdfId,
                        principalTable: "PdfFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Requests_VideoFiles_VideoId",
                        column: x => x.VideoId,
                        principalTable: "VideoFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssignUsers_AudioId",
                table: "AssignUsers",
                column: "AudioId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignUsers_PdfId",
                table: "AssignUsers",
                column: "PdfId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignUsers_UserId",
                table: "AssignUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignUsers_VideoId",
                table: "AssignUsers",
                column: "VideoId");

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
    }
}
