using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncHotels.Migrations
{
    public partial class addedSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "ID", "Amenity" },
                values: new object[,]
                {
                    { 1, "Massage bed" },
                    { 2, "Turbo shower" },
                    { 3, "Hands-Free wipe toilet" },
                    { 4, "Holographic phone" },
                    { 5, "Botomless Hummus" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "City", "HotelName", "Phone", "State", "StreetAdress" },
                values: new object[,]
                {
                    { 1, "Omaha", "Bubbles Inn", "111-111-1111", "Idaho", "1st street" },
                    { 2, "Springfield", "Cuddles Inn", "222-222-2222", "Ohio", "2nd street" },
                    { 3, "San Antonio", "Puddles Inn", "333-333-3333", "Texas", "3rd street" },
                    { 4, "Enumclaw", "Dubbles Inn", "444-444-44444", "Washington", "4th street" },
                    { 5, "Las Vegas", "Wubbles Inn", "555-555-5555", "Nevada", "5th street" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Layout", "Nickname" },
                values: new object[,]
                {
                    { 1, 1, "People's Republic of Ninight" },
                    { 2, 0, "Candle Light" },
                    { 3, 2, "Pumperschniquel" },
                    { 4, 1, "Live, Laugh, Love" },
                    { 5, 0, "Chicken Pot Pie" },
                    { 6, 2, "Smells like Christmas" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 6);
        }
    }
}
