using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wymiana_Kart_TCG.Migrations
{
    public partial class WorkingDropCategoriesDown1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardCategories",
                columns: table => new
                {
                    CardCategoryId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CardCategoryName = table.Column<string>(nullable: true),
                    CardDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardCategories", x => x.CardCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 10, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 25, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
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
                    CardCategoryId = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardId);
                    table.ForeignKey(
                        name: "FK_Cards_CardCategories_CardCategoryId",
                        column: x => x.CardCategoryId,
                        principalTable: "CardCategories",
                        principalColumn: "CardCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    CardId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "CardId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
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
                columns: new[] { "CardCategoryId", "CardCategoryName", "CardDescription" },
                values: new object[] { 1, "Pokemon", null });

            migrationBuilder.InsertData(
                table: "CardCategories",
                columns: new[] { "CardCategoryId", "CardCategoryName", "CardDescription" },
                values: new object[] { 2, "MTG", null });

            migrationBuilder.InsertData(
                table: "CardCategories",
                columns: new[] { "CardCategoryId", "CardCategoryName", "CardDescription" },
                values: new object[] { 3, "Yugioh", null });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "CardCategoryId", "CardImgThumbnailUrl", "CardImgUrl", "CardLongDescription", "CardName", "CardOtherDescription", "CardPrice", "CardShortDescription", "IsCardAvailableToTrade", "IsCardDealOfTheWeek", "Notes" },
                values: new object[] { 1, 1, "https://www.lootpots.com/wp-content/uploads/2019/12/pokemon-sword-shield-666x374.jpg", "https://imgix.ranker.com/user_node_img/36/700363/original/charizard-u21?w=650&q=50&fm=pjpg&fit=crop&crop=faces", "Long description AlakazamAlakazamAlakazamAlakazamAlakazamAlakazamAlakazamAlakazamAlakazamAlakazamAlakazam", "Alakazam", null, 12, "Our famous Alakazam Cards!", true, true, null });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "CardCategoryId", "CardImgThumbnailUrl", "CardImgUrl", "CardLongDescription", "CardName", "CardOtherDescription", "CardPrice", "CardShortDescription", "IsCardAvailableToTrade", "IsCardDealOfTheWeek", "Notes" },
                values: new object[] { 2, 2, "https://www.lootpots.com/wp-content/uploads/2019/12/pokemon-sword-shield-666x374.jpg", "https://imgix.ranker.com/user_node_img/36/700363/original/charizard-u21?w=650&q=50&fm=pjpg&fit=crop&crop=faces", "Long description BlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoiseBlastoise", "Blastoise", null, 18, "Our famous Blastoise Cards!", true, false, null });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "CardCategoryId", "CardImgThumbnailUrl", "CardImgUrl", "CardLongDescription", "CardName", "CardOtherDescription", "CardPrice", "CardShortDescription", "IsCardAvailableToTrade", "IsCardDealOfTheWeek", "Notes" },
                values: new object[] { 3, 3, "https://www.lootpots.com/wp-content/uploads/2019/12/pokemon-sword-shield-666x374.jpg", "https://imgix.ranker.com/user_node_img/36/700363/original/charizard-u21?w=650&q=50&fm=pjpg&fit=crop&crop=faces", " Long description VenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaurVenusaur", "Venusaur", null, 18, "Our famous Venusaur Cards!", true, false, null });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardCategoryId",
                table: "Cards",
                column: "CardCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CardId",
                table: "OrderDetails",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_CardId",
                table: "ShoppingCartItems",
                column: "CardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "CardCategories");
        }
    }
}
