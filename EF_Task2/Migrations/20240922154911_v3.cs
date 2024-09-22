using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Task2.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "userName",
                table: "Author",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Author",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Author",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_News_authId",
                table: "News",
                column: "authId");

            migrationBuilder.CreateIndex(
                name: "IX_News_catId",
                table: "News",
                column: "catId");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Author_authId",
                table: "News",
                column: "authId",
                principalTable: "Author",
                principalColumn: "autId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Catalogs_catId",
                table: "News",
                column: "catId",
                principalTable: "Catalogs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Author_authId",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Catalogs_catId",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_authId",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_catId",
                table: "News");

            migrationBuilder.AlterColumn<string>(
                name: "userName",
                table: "Author",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Author",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Author",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
