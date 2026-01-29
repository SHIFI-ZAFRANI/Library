using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class manytoone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Userpassword",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Books_Userpassword",
                table: "Books",
                column: "Userpassword");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Users_Userpassword",
                table: "Books",
                column: "Userpassword",
                principalTable: "Users",
                principalColumn: "password",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Users_Userpassword",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Userpassword",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Userpassword",
                table: "Books");
        }
    }
}
