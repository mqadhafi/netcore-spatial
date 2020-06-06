using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace netcore_spatial.Migrations
{
    public partial class SeedOneData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "place",
                columns: new[] { "id", "name", "point" },
                values: new object[] { new Guid("5f1b95ff-8167-4ac6-9db9-9a6459a6c816"), "Monumen Nasional", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (106.8232042 -6.1778625)") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "place",
                keyColumn: "id",
                keyValue: new Guid("5f1b95ff-8167-4ac6-9db9-9a6459a6c816"));
        }
    }
}
