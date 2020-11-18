using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ValkyraECommerce.Migrations
{
    public partial class Language : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerBaskets_Customers_CustomerId",
                table: "CustomerBaskets");

            migrationBuilder.DropIndex(
                name: "IX_CustomerBaskets_CustomerId",
                table: "CustomerBaskets");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CustomerBaskets");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "ShopProducts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "ShopProducts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EAN",
                table: "ShopProducts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "ShopProducts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ShopProducts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PriceId",
                table: "ShopProducts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProcuctDescriptionId",
                table: "ShopProducts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductNumber",
                table: "ShopProducts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerWebAccountId",
                table: "CustomerBaskets",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    GrossAmount = table.Column<decimal>(nullable: false),
                    NetAmout = table.Column<decimal>(nullable: false),
                    VatPercent = table.Column<decimal>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: true),
                    CountryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prices_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prices_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProcuctDescription",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    LanguageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcuctDescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcuctDescription_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopProducts_PriceId",
                table: "ShopProducts",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopProducts_ProcuctDescriptionId",
                table: "ShopProducts",
                column: "ProcuctDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_LanguageId",
                table: "Customers",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBaskets_CustomerWebAccountId",
                table: "CustomerBaskets",
                column: "CustomerWebAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_CountryId",
                table: "Prices",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_CurrencyId",
                table: "Prices",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcuctDescription_LanguageId",
                table: "ProcuctDescription",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerBaskets_WebAccounts_CustomerWebAccountId",
                table: "CustomerBaskets",
                column: "CustomerWebAccountId",
                principalTable: "WebAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Languages_LanguageId",
                table: "Customers",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProducts_Prices_PriceId",
                table: "ShopProducts",
                column: "PriceId",
                principalTable: "Prices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProducts_ProcuctDescription_ProcuctDescriptionId",
                table: "ShopProducts",
                column: "ProcuctDescriptionId",
                principalTable: "ProcuctDescription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerBaskets_WebAccounts_CustomerWebAccountId",
                table: "CustomerBaskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Languages_LanguageId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopProducts_Prices_PriceId",
                table: "ShopProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopProducts_ProcuctDescription_ProcuctDescriptionId",
                table: "ShopProducts");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "ProcuctDescription");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_ShopProducts_PriceId",
                table: "ShopProducts");

            migrationBuilder.DropIndex(
                name: "IX_ShopProducts_ProcuctDescriptionId",
                table: "ShopProducts");

            migrationBuilder.DropIndex(
                name: "IX_Customers_LanguageId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_CustomerBaskets_CustomerWebAccountId",
                table: "CustomerBaskets");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "ShopProducts");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "ShopProducts");

            migrationBuilder.DropColumn(
                name: "EAN",
                table: "ShopProducts");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "ShopProducts");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ShopProducts");

            migrationBuilder.DropColumn(
                name: "PriceId",
                table: "ShopProducts");

            migrationBuilder.DropColumn(
                name: "ProcuctDescriptionId",
                table: "ShopProducts");

            migrationBuilder.DropColumn(
                name: "ProductNumber",
                table: "ShopProducts");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerWebAccountId",
                table: "CustomerBaskets");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "CustomerBaskets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBaskets_CustomerId",
                table: "CustomerBaskets",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerBaskets_Customers_CustomerId",
                table: "CustomerBaskets",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
