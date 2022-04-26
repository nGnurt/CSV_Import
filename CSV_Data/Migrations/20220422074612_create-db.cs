using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSV_Import_Data.Migrations
{
    public partial class createdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderNumber = table.Column<string>(type: "text", nullable: true),
                    BuyerUserName = table.Column<string>(type: "text", nullable: true),
                    BuyerName = table.Column<string>(type: "text", nullable: true),
                    BuyerNote = table.Column<string>(type: "text", nullable: true),
                    BuyerAddress1 = table.Column<string>(type: "text", nullable: true),
                    BuyerAddress2 = table.Column<string>(type: "text", nullable: true),
                    BuyerCity = table.Column<string>(type: "text", nullable: true),
                    BuyerSate = table.Column<string>(type: "text", nullable: true),
                    BuyerZip = table.Column<string>(type: "text", nullable: true),
                    BuyerCountry = table.Column<string>(type: "text", nullable: true),
                    ShipToName = table.Column<string>(type: "text", nullable: true),
                    ShipToPhone = table.Column<string>(type: "text", nullable: true),
                    ShipToAddress1 = table.Column<string>(type: "text", nullable: true),
                    ShipToAddress2 = table.Column<string>(type: "text", nullable: true),
                    ShipToCity = table.Column<string>(type: "text", nullable: true),
                    ShipToState = table.Column<string>(type: "text", nullable: true),
                    ShipToZip = table.Column<string>(type: "text", nullable: true),
                    ShipToCountry = table.Column<string>(type: "text", nullable: true),
                    ItemNumber = table.Column<string>(type: "text", nullable: true),
                    ItemTitle = table.Column<string>(type: "text", nullable: true),
                    CustomLabel = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    TotalPrice = table.Column<float>(type: "real", nullable: false),
                    SaleDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    SellerId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderNumber",
                table: "Orders",
                column: "OrderNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
