using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace netcore_spatial.Migrations
{
    public partial class SeedMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "place",
                keyColumn: "id",
                keyValue: new Guid("5f1b95ff-8167-4ac6-9db9-9a6459a6c816"));

            migrationBuilder.InsertData(
                table: "place",
                columns: new[] { "id", "name", "point" },
                values: new object[,]
                {
                    { new Guid("56cef075-da90-4977-b808-a22a26da9d1c"), "Monumen Nasional", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (106.8232042 -6.1778625)") },
                    { new Guid("0e7b76df-7aba-4ed0-88c9-abe602b319ca"), "Tanah Abang", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (106.7899549 -6.2054172)") },
                    { new Guid("dea028cc-b7b8-4ada-8667-f1f572e51bc4"), "Soekarno-Hatta International Airport", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (106.6515171 -6.1275282)") },
                    { new Guid("2472e920-c88f-4ab6-9ac9-7b0b6dca5429"), "Halim Perdanakusuma Airport", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (106.88239 -6.2653365)") },
                    { new Guid("4fab1364-e3c3-4602-992a-25aca3f2351d"), "Trans Studio Bandung", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (107.6001837 -6.9072212)") },
                    { new Guid("3b3bddfa-70cc-4382-9234-9c1400dc5e69"), "Gedung Sate", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (107.6230286 -6.8928316)") },
                    { new Guid("222c7934-e201-45e2-bd92-ba891ec74e5e"), "Surabaya Town Square", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (112.7280482 -7.2946663)") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "place",
                keyColumn: "id",
                keyValue: new Guid("0e7b76df-7aba-4ed0-88c9-abe602b319ca"));

            migrationBuilder.DeleteData(
                table: "place",
                keyColumn: "id",
                keyValue: new Guid("222c7934-e201-45e2-bd92-ba891ec74e5e"));

            migrationBuilder.DeleteData(
                table: "place",
                keyColumn: "id",
                keyValue: new Guid("2472e920-c88f-4ab6-9ac9-7b0b6dca5429"));

            migrationBuilder.DeleteData(
                table: "place",
                keyColumn: "id",
                keyValue: new Guid("3b3bddfa-70cc-4382-9234-9c1400dc5e69"));

            migrationBuilder.DeleteData(
                table: "place",
                keyColumn: "id",
                keyValue: new Guid("4fab1364-e3c3-4602-992a-25aca3f2351d"));

            migrationBuilder.DeleteData(
                table: "place",
                keyColumn: "id",
                keyValue: new Guid("56cef075-da90-4977-b808-a22a26da9d1c"));

            migrationBuilder.DeleteData(
                table: "place",
                keyColumn: "id",
                keyValue: new Guid("dea028cc-b7b8-4ada-8667-f1f572e51bc4"));

            migrationBuilder.InsertData(
                table: "place",
                columns: new[] { "id", "name", "point" },
                values: new object[] { new Guid("5f1b95ff-8167-4ac6-9db9-9a6459a6c816"), "Monumen Nasional", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (106.8232042 -6.1778625)") });
        }
    }
}
