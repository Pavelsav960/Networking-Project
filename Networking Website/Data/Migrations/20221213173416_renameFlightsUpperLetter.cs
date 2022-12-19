using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Networking_Website.Data.Migrations
{
    public partial class renameFlightsUpperLetter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "time",
                table: "Flights",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Flights",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "originCountry",
                table: "Flights",
                newName: "OriginCountry");

            migrationBuilder.RenameColumn(
                name: "isOneWay",
                table: "Flights",
                newName: "IsOneWay");

            migrationBuilder.RenameColumn(
                name: "isDirect",
                table: "Flights",
                newName: "IsDirect");

            migrationBuilder.RenameColumn(
                name: "destinationCountry",
                table: "Flights",
                newName: "DestinationCountry");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Flights",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Flights",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Flights",
                newName: "time");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Flights",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "OriginCountry",
                table: "Flights",
                newName: "originCountry");

            migrationBuilder.RenameColumn(
                name: "IsOneWay",
                table: "Flights",
                newName: "isOneWay");

            migrationBuilder.RenameColumn(
                name: "IsDirect",
                table: "Flights",
                newName: "isDirect");

            migrationBuilder.RenameColumn(
                name: "DestinationCountry",
                table: "Flights",
                newName: "destinationCountry");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Flights",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Flights",
                newName: "id");
        }
    }
}
