using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ValkyraECommerce.Migrations
{
    public partial class Wishlist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopProducts_CustomerWishLists_CustomerWishListId",
                table: "ShopProducts");

            migrationBuilder.DropIndex(
                name: "IX_ShopProducts_CustomerWishListId",
                table: "ShopProducts");

            migrationBuilder.DropColumn(
                name: "CustomerWishListId",
                table: "ShopProducts");

            migrationBuilder.CreateTable(
                name: "WishListItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    ShopProductId = table.Column<int>(nullable: true),
                    CustomerWishListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishListItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishListItem_CustomerWishLists_CustomerWishListId",
                        column: x => x.CustomerWishListId,
                        principalTable: "CustomerWishLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WishListItem_ShopProducts_ShopProductId",
                        column: x => x.ShopProductId,
                        principalTable: "ShopProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WishListItem_CustomerWishListId",
                table: "WishListItem",
                column: "CustomerWishListId");

            migrationBuilder.CreateIndex(
                name: "IX_WishListItem_ShopProductId",
                table: "WishListItem",
                column: "ShopProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WishListItem");

            migrationBuilder.AddColumn<int>(
                name: "CustomerWishListId",
                table: "ShopProducts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShopProducts_CustomerWishListId",
                table: "ShopProducts",
                column: "CustomerWishListId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProducts_CustomerWishLists_CustomerWishListId",
                table: "ShopProducts",
                column: "CustomerWishListId",
                principalTable: "CustomerWishLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
