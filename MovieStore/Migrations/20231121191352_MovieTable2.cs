using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieStore.Migrations
{
    /// <inheritdoc />
    public partial class MovieTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Cart_CartId",
                table: "Movie");

            migrationBuilder.AlterColumn<int>(
                name: "CartId",
                table: "Movie",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Cart_CartId",
                table: "Movie",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Cart_CartId",
                table: "Movie");

            migrationBuilder.AlterColumn<int>(
                name: "CartId",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Cart_CartId",
                table: "Movie",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
