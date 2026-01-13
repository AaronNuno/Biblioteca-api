using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BibliotecaAPI.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LlaveAPI_AspNetUsers_UsuarioId",
                table: "LlaveAPI");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LlaveAPI",
                table: "LlaveAPI");

            migrationBuilder.RenameTable(
                name: "LlaveAPI",
                newName: "LlavesAPI");

            migrationBuilder.RenameIndex(
                name: "IX_LlaveAPI_UsuarioId",
                table: "LlavesAPI",
                newName: "IX_LlavesAPI_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LlavesAPI",
                table: "LlavesAPI",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LlavesAPI_AspNetUsers_UsuarioId",
                table: "LlavesAPI",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LlavesAPI_AspNetUsers_UsuarioId",
                table: "LlavesAPI");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LlavesAPI",
                table: "LlavesAPI");

            migrationBuilder.RenameTable(
                name: "LlavesAPI",
                newName: "LlaveAPI");

            migrationBuilder.RenameIndex(
                name: "IX_LlavesAPI_UsuarioId",
                table: "LlaveAPI",
                newName: "IX_LlaveAPI_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LlaveAPI",
                table: "LlaveAPI",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LlaveAPI_AspNetUsers_UsuarioId",
                table: "LlaveAPI",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
