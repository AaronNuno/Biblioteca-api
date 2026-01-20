using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BibliotecaAPI.Migrations
{
    /// <inheritdoc />
    public partial class Crea_SP_SetearUsuariosMalaPaga : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
CREATE PROCEDURE Usuarios_SetearMalaPaga


AS
BEGIN

	SET NOCOUNT ON ;

	UPDATE AspNetUsers 
	SET 
	MalaPaga = 'True'
	FROM Facturas
	INNER JOIN AspNetUsers
	ON AspNetUsers.Id = Facturas.UsuarioId
	WHERE Pagada = 'False' AND FechaLimiteDePago < GETDATE()

END");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE Usuarios_SetearMalaPaga");

        }
    }
}
