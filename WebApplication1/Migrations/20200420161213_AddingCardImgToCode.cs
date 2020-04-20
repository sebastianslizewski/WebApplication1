using Microsoft.EntityFrameworkCore.Migrations;

namespace Wymiana_Kart_TCG.Migrations
{
    public partial class AddingCardImgToCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 1,
                column: "CardImgUrl",
                value: "https://imgix.ranker.com/user_node_img/36/700363/original/charizard-u21?w=650&q=50&fm=pjpg&fit=crop&crop=faces");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 2,
                column: "CardImgUrl",
                value: "https://imgix.ranker.com/user_node_img/36/700363/original/charizard-u21?w=650&q=50&fm=pjpg&fit=crop&crop=faces");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 3,
                column: "CardImgUrl",
                value: "https://imgix.ranker.com/user_node_img/36/700363/original/charizard-u21?w=650&q=50&fm=pjpg&fit=crop&crop=faces");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 1,
                column: "CardImgUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 2,
                column: "CardImgUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 3,
                column: "CardImgUrl",
                value: null);
        }
    }
}
