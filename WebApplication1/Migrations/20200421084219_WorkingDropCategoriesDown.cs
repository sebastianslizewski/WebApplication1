using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wymiana_Kart_TCG.Migrations
{
    public partial class WorkingDropCategoriesDown : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CardCategoryName = table.Column<string>(nullable: true),
                    CardDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardCategories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    CardId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CardName = table.Column<string>(nullable: true),
                    CardShortDescription = table.Column<string>(nullable: true),
                    CardLongDescription = table.Column<string>(nullable: true),
                    CardOtherDescription = table.Column<string>(nullable: true),
                    CardPrice = table.Column<int>(nullable: false),
                    CardImgUrl = table.Column<string>(nullable: true),
                    CardImgThumbnailUrl = table.Column<string>(nullable: true),
                    IsCardDealOfTheWeek = table.Column<bool>(nullable: false),
                    IsCardAvailableToTrade = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    CardCategoryCategoryId = table.Column<int>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardId);
                    table.ForeignKey(
                        name: "FK_Cards_CardCategories_CardCategoryCategoryId",
                        column: x => x.CardCategoryCategoryId,
                        principalTable: "CardCategories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CardId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShoppingCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "CardId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CardCategories",
                columns: new[] { "CategoryId", "CardCategoryName", "CardDescription" },
                values: new object[,]
                {
                    { 1, "Pokemon", null },
                    { 2, "MTG", null },
                    { 3, "Yugioh", null }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "CardCategoryCategoryId", "CardImgThumbnailUrl", "CardImgUrl", "CardLongDescription", "CardName", "CardOtherDescription", "CardPrice", "CardShortDescription", "CategoryId", "IsCardAvailableToTrade", "IsCardDealOfTheWeek", "Notes" },
                values: new object[,]
                {
                    { 1, null, "https://www.lootpots.com/wp-content/uploads/2019/12/pokemon-sword-shield-666x374.jpg", "https://imgix.ranker.com/user_node_img/36/700363/original/charizard-u21?w=650&q=50&fm=pjpg&fit=crop&crop=faces", "Long description AlakazamAlakazamAlakazamAlakazamAlakazamAlakazamAlakazamAlakazamAlakazamAlakazamAlakazam", "Alakazam", null, 12, "Our famous Alakazam Cards!", 1, true, true, null },
                    { 2, null, "https://www.lootpots.com/wp-content/uploads/2019/12/pokemon-sword-shield-666x374.jpg", "https://imgix.ranker.com/user_node_img/36/700363/original/charizard-u21?w=650&q=50&fm=pjpg&fit=crop&crop=faces", "Long description BlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoise", "Blastoise", null, 18, "Our famous Blastoise Cards!", 2, true, false, null },
                    { 3, null, "https://www.lootpots.com/wp-content/uploads/2019/12/pokemon-sword-shield-666x374.jpg", "https://imgix.ranker.com/user_node_img/36/700363/original/charizard-u21?w=650&q=50&fm=pjpg&fit=crop&crop=faces", " Long description VenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaur", "Venusaur", null, 18, "Our famous Venusaur Cards!", 2, true, false, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardCategoryCategoryId",
                table: "Cards",
                column: "CardCategoryCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_CardId",
                table: "ShoppingCartItems",
                column: "CardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "CardCategories");
        }
    }
}
