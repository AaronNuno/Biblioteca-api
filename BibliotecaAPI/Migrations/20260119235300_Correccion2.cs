using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BibliotecaAPI.Migrations
{
    /// <inheritdoc />
    public partial class Correccion2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_restriccionDominio_LlavesAPI_LlaveId",
                table: "restriccionDominio");

            migrationBuilder.DropForeignKey(
                name: "FK_restriccionIP_LlavesAPI_LlaveId",
                table: "restriccionIP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_restriccionIP",
                table: "restriccionIP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_restriccionDominio",
                table: "restriccionDominio");

            migrationBuilder.RenameTable(
                name: "restriccionIP",
                newName: "RestriccionIP");

            migrationBuilder.RenameTable(
                name: "restriccionDominio",
                newName: "RestriccionDominio");

            migrationBuilder.RenameIndex(
                name: "IX_restriccionIP_LlaveId",
                table: "RestriccionIP",
                newName: "IX_RestriccionIP_LlaveId");

            migrationBuilder.RenameIndex(
                name: "IX_restriccionDominio_LlaveId",
                table: "RestriccionDominio",
                newName: "IX_RestriccionDominio_LlaveId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RestriccionIP",
                table: "RestriccionIP",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RestriccionDominio",
                table: "RestriccionDominio",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RestriccionDominio_LlavesAPI_LlaveId",
                table: "RestriccionDominio",
                column: "LlaveId",
                principalTable: "LlavesAPI",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestriccionIP_LlavesAPI_LlaveId",
                table: "RestriccionIP",
                column: "LlaveId",
                principalTable: "LlavesAPI",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestriccionDominio_LlavesAPI_LlaveId",
                table: "RestriccionDominio");

            migrationBuilder.DropForeignKey(
                name: "FK_RestriccionIP_LlavesAPI_LlaveId",
                table: "RestriccionIP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RestriccionIP",
                table: "RestriccionIP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RestriccionDominio",
                table: "RestriccionDominio");

            migrationBuilder.RenameTable(
                name: "RestriccionIP",
                newName: "restriccionIP");

            migrationBuilder.RenameTable(
                name: "RestriccionDominio",
                newName: "restriccionDominio");

            migrationBuilder.RenameIndex(
                name: "IX_RestriccionIP_LlaveId",
                table: "restriccionIP",
                newName: "IX_restriccionIP_LlaveId");

            migrationBuilder.RenameIndex(
                name: "IX_RestriccionDominio_LlaveId",
                table: "restriccionDominio",
                newName: "IX_restriccionDominio_LlaveId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_restriccionIP",
                table: "restriccionIP",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_restriccionDominio",
                table: "restriccionDominio",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_restriccionDominio_LlavesAPI_LlaveId",
                table: "restriccionDominio",
                column: "LlaveId",
                principalTable: "LlavesAPI",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_restriccionIP_LlavesAPI_LlaveId",
                table: "restriccionIP",
                column: "LlaveId",
                principalTable: "LlavesAPI",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
