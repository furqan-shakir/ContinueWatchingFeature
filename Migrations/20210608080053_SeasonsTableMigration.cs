using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesApis.Migrations
{
    public partial class SeasonsTableMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");


            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SeriesId = table.Column<int>(type: "int", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seasons_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Serieses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");


            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "CreationDateTime", "LastUpdateDateTime", "SeriesId", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 25, 3, 55, 41, 206, DateTimeKind.Local).AddTicks(1934), null, 590, "Mountain hard drive Plastic Mississippi" },
                    { 28, new DateTime(2020, 11, 23, 8, 46, 23, 801, DateTimeKind.Local).AddTicks(7746), null, 700, "deliver Ergonomic Wooden Ball Designer frictionless" },
                    { 29, new DateTime(2021, 5, 28, 19, 47, 32, 449, DateTimeKind.Local).AddTicks(8605), null, 99, "payment Rustic Concrete Towels synthesizing Lead" },
                    { 30, new DateTime(2020, 11, 22, 17, 45, 37, 735, DateTimeKind.Local).AddTicks(1235), null, 284, "workforce Technician Producer National" },
                    { 31, new DateTime(2020, 10, 16, 15, 58, 57, 223, DateTimeKind.Local).AddTicks(8340), null, 236, "Consultant Berkshire even-keeled Fort" },
                    { 32, new DateTime(2020, 12, 26, 15, 40, 11, 439, DateTimeKind.Local).AddTicks(2772), null, 961, "microchip Mission toolset Paradigm" },
                    { 33, new DateTime(2020, 11, 14, 8, 43, 18, 968, DateTimeKind.Local).AddTicks(9877), null, 592, "Guinea Crossroad digital focus group" },
                    { 34, new DateTime(2020, 12, 9, 10, 7, 12, 622, DateTimeKind.Local).AddTicks(4393), null, 325, "portals bandwidth-monitored withdrawal Auto Loan Account" },
                    { 35, new DateTime(2021, 6, 7, 18, 36, 6, 187, DateTimeKind.Local).AddTicks(8813), null, 376, "turn-key online artificial intelligence Mississippi" },
                    { 36, new DateTime(2021, 5, 2, 1, 42, 19, 914, DateTimeKind.Local).AddTicks(3633), null, 54, "multi-byte generate Garden & Garden deposit" },
                    { 37, new DateTime(2021, 4, 3, 4, 45, 22, 755, DateTimeKind.Local).AddTicks(3434), null, 337, "payment Implemented Paradigm programming" },
                    { 38, new DateTime(2020, 8, 6, 17, 22, 15, 658, DateTimeKind.Local).AddTicks(7140), null, 609, "Architect Fresh Well calculating" },
                    { 39, new DateTime(2021, 3, 1, 23, 26, 15, 946, DateTimeKind.Local).AddTicks(2598), null, 30, "Intranet transmit Administrator Small" },
                    { 40, new DateTime(2021, 3, 5, 10, 55, 15, 698, DateTimeKind.Local).AddTicks(745), null, 153, "Concrete Fields Executive Up-sized" },
                    { 41, new DateTime(2021, 1, 29, 3, 37, 57, 97, DateTimeKind.Local).AddTicks(4772), null, 51, "Investment Account payment Personal Loan Account Yuan Renminbi" },
                    { 42, new DateTime(2020, 11, 30, 1, 39, 36, 758, DateTimeKind.Local).AddTicks(4045), null, 398, "Uruguay Bedfordshire Steel District" },
                    { 43, new DateTime(2020, 7, 5, 20, 44, 7, 379, DateTimeKind.Local).AddTicks(9730), null, 764, "indigo HTTP Handmade Steel Salad District" },
                    { 44, new DateTime(2020, 7, 4, 11, 52, 41, 235, DateTimeKind.Local).AddTicks(7543), null, 714, "Louisiana Networked Corporate green" },
                    { 45, new DateTime(2020, 8, 14, 23, 21, 38, 579, DateTimeKind.Local).AddTicks(7765), null, 211, "Technician hack compress Unbranded" },
                    { 46, new DateTime(2020, 11, 2, 7, 37, 41, 221, DateTimeKind.Local).AddTicks(962), null, 271, "New Caledonia Refined Rubber Soap Vermont Forward" },
                    { 47, new DateTime(2021, 2, 25, 4, 27, 27, 411, DateTimeKind.Local).AddTicks(7508), null, 809, "Passage infrastructures Technician Licensed Concrete Pants" },
                    { 48, new DateTime(2020, 6, 27, 6, 37, 46, 907, DateTimeKind.Local).AddTicks(1033), null, 243, "digital support Data backing up" },
                    { 27, new DateTime(2021, 1, 6, 18, 59, 7, 450, DateTimeKind.Local).AddTicks(7804), null, 212, "Administrator bandwidth Practical Steel Mouse SAS" },
                    { 26, new DateTime(2020, 11, 16, 11, 19, 31, 705, DateTimeKind.Local).AddTicks(6261), null, 820, "Identity open-source Michigan Investment Account" },
                    { 25, new DateTime(2020, 12, 9, 17, 24, 48, 689, DateTimeKind.Local).AddTicks(9083), null, 152, "Bypass Rustic Steel Data" },
                    { 24, new DateTime(2021, 5, 14, 10, 23, 34, 479, DateTimeKind.Local).AddTicks(2845), null, 585, "Fresh Books & Beauty neural Electronics & Shoes" },
                    { 2, new DateTime(2020, 8, 2, 22, 18, 26, 886, DateTimeKind.Local).AddTicks(2520), null, 600, "Flats Key Nebraska Consultant" },
                    { 3, new DateTime(2020, 10, 31, 11, 46, 57, 12, DateTimeKind.Local).AddTicks(8727), null, 500, "bi-directional Gorgeous Metal Fish Internal navigating" },
                    { 4, new DateTime(2021, 1, 25, 13, 44, 23, 812, DateTimeKind.Local).AddTicks(2630), null, 246, "Auto Loan Account Rustic Curve Tasty Frozen Bike" },
                    { 5, new DateTime(2020, 9, 3, 19, 24, 44, 598, DateTimeKind.Local).AddTicks(149), null, 850, "cyan Buckinghamshire alarm bypassing" },
                    { 6, new DateTime(2021, 4, 1, 4, 48, 44, 7, DateTimeKind.Local).AddTicks(6899), null, 644, "ADP magnetic District mindshare" },
                    { 7, new DateTime(2020, 10, 31, 16, 46, 57, 18, DateTimeKind.Local).AddTicks(6274), null, 731, "revolutionize Home Loan Account hub Configuration" },
                    { 8, new DateTime(2021, 4, 1, 6, 33, 0, 19, DateTimeKind.Local).AddTicks(7123), null, 102, "Solutions SAS Licensed asynchronous" },
                    { 9, new DateTime(2020, 10, 14, 6, 20, 49, 365, DateTimeKind.Local).AddTicks(686), null, 257, "Massachusetts program Technician hack" },
                    { 10, new DateTime(2021, 2, 27, 10, 32, 40, 203, DateTimeKind.Local).AddTicks(9819), null, 512, "Expressway Center Coordinator tangible" },
                    { 11, new DateTime(2021, 4, 22, 22, 27, 47, 386, DateTimeKind.Local).AddTicks(759), null, 369, "Namibia Dollar end-to-end transmitting Nevada" },
                    { 49, new DateTime(2020, 7, 11, 17, 26, 37, 433, DateTimeKind.Local).AddTicks(3241), null, 169, "experiences functionalities National Gateway" },
                    { 12, new DateTime(2020, 8, 29, 4, 55, 49, 932, DateTimeKind.Local).AddTicks(6876), null, 691, "Incredible Rubber Table Personal Loan Account Handmade Port" },
                    { 14, new DateTime(2020, 12, 11, 21, 3, 25, 567, DateTimeKind.Local).AddTicks(5317), null, 129, "Circle Antarctica (the territory South of 60 deg S) Wooden Seamless" },
                    { 15, new DateTime(2021, 1, 16, 23, 58, 52, 485, DateTimeKind.Local).AddTicks(2220), null, 932, "Organic Cotton Incredible Granite Ball HDD" },
                    { 16, new DateTime(2020, 9, 9, 14, 52, 34, 921, DateTimeKind.Local).AddTicks(4181), null, 787, "context-sensitive Fantastic monitor Pakistan Rupee" },
                    { 17, new DateTime(2020, 8, 26, 9, 28, 34, 834, DateTimeKind.Local).AddTicks(3756), null, 592, "mobile Toys, Clothing & Health Mississippi Architect" },
                    { 18, new DateTime(2020, 8, 21, 10, 21, 45, 746, DateTimeKind.Local).AddTicks(8758), null, 198, "Incredible Cotton Cheese productize Handmade Optimized" },
                    { 19, new DateTime(2020, 9, 2, 12, 46, 23, 711, DateTimeKind.Local).AddTicks(1200), null, 501, "throughput array Avon Buckinghamshire" },
                    { 20, new DateTime(2020, 12, 31, 13, 25, 45, 324, DateTimeKind.Local).AddTicks(9507), null, 680, "Practical Wooden Fish neural array Factors" },
                    { 21, new DateTime(2021, 1, 3, 3, 51, 36, 876, DateTimeKind.Local).AddTicks(622), null, 563, "Direct compelling open system Netherlands Antillian Guilder" },
                    { 22, new DateTime(2020, 7, 19, 2, 12, 23, 381, DateTimeKind.Local).AddTicks(7409), null, 980, "bypassing reciprocal microchip Agent" },
                    { 23, new DateTime(2021, 3, 1, 10, 54, 28, 505, DateTimeKind.Local).AddTicks(3532), null, 609, "fresh-thinking Tasty Rubber Tuna Concrete infrastructures" },
                    { 13, new DateTime(2020, 12, 15, 8, 12, 35, 973, DateTimeKind.Local).AddTicks(3027), null, 825, "Cliffs Grocery, Sports & Jewelery Lithuanian Litas engage" },
                    { 50, new DateTime(2020, 12, 30, 1, 43, 34, 932, DateTimeKind.Local).AddTicks(5781), null, 728, "withdrawal Rustic calculate Mandatory" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_SeriesId",
                table: "Seasons",
                column: "SeriesId");

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropTable(
                name: "Seasons");

        }
    }
}
