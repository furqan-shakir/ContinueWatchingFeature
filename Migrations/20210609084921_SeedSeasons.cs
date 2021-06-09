using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesApis.Migrations
{
    public partial class SeedSeasons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "CreationDateTime", "EposidesNumber", "LastUpdateDateTime", "SeriesId", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 8, 13, 14, 45, 33, 975, DateTimeKind.Local).AddTicks(7066), 6, null, 556, "Buckinghamshire Buckinghamshire Metal invoice" },
                    { 28, new DateTime(2020, 10, 29, 4, 37, 19, 880, DateTimeKind.Local).AddTicks(1315), 6, null, 811, "Metal Planner Money Market Account Wooden" },
                    { 29, new DateTime(2021, 1, 6, 17, 12, 59, 95, DateTimeKind.Local).AddTicks(1917), 6, null, 765, "Public-key Small initiative Jewelery, Shoes & Games" },
                    { 30, new DateTime(2020, 6, 19, 23, 43, 48, 298, DateTimeKind.Local).AddTicks(8166), 6, null, 20, "deposit bluetooth Nebraska navigating" },
                    { 31, new DateTime(2020, 10, 13, 16, 13, 39, 890, DateTimeKind.Local).AddTicks(8087), 6, null, 98, "Hawaii Automotive, Kids & Baby Wells transmit" },
                    { 32, new DateTime(2021, 2, 19, 21, 17, 1, 279, DateTimeKind.Local).AddTicks(6064), 6, null, 276, "Reverse-engineered Qatari Rial Awesome Concrete Cheese Iraqi Dinar" },
                    { 33, new DateTime(2020, 11, 30, 1, 34, 39, 338, DateTimeKind.Local).AddTicks(1586), 6, null, 717, "applications payment Personal Loan Account teal" },
                    { 34, new DateTime(2020, 10, 22, 12, 46, 57, 541, DateTimeKind.Local).AddTicks(9614), 6, null, 14, "open-source primary purple capacity" },
                    { 35, new DateTime(2021, 4, 1, 21, 8, 13, 783, DateTimeKind.Local).AddTicks(9146), 6, null, 819, "Missouri Utah IB Peso Uruguayo" },
                    { 36, new DateTime(2020, 7, 2, 8, 27, 19, 38, DateTimeKind.Local).AddTicks(8161), 6, null, 887, "IB navigate Buckinghamshire Garden, Jewelery & Kids" },
                    { 37, new DateTime(2020, 9, 15, 20, 5, 14, 421, DateTimeKind.Local).AddTicks(2476), 6, null, 646, "capacitor metrics Fantastic Steel Shoes Guinea" },
                    { 38, new DateTime(2020, 10, 14, 12, 12, 34, 76, DateTimeKind.Local).AddTicks(6569), 6, null, 529, "Response synthesize copy 24/365" },
                    { 39, new DateTime(2021, 5, 28, 9, 36, 51, 535, DateTimeKind.Local).AddTicks(8210), 6, null, 229, "Analyst Plains orchestrate Squares" },
                    { 40, new DateTime(2020, 9, 19, 21, 10, 54, 177, DateTimeKind.Local).AddTicks(829), 6, null, 778, "Ouguiya programming Bridge Investment Account" },
                    { 41, new DateTime(2020, 12, 8, 13, 42, 24, 310, DateTimeKind.Local).AddTicks(1610), 6, null, 578, "web-enabled Metal Nebraska De-engineered" },
                    { 42, new DateTime(2020, 7, 19, 11, 12, 36, 950, DateTimeKind.Local).AddTicks(7133), 6, null, 983, "Networked paradigms Agent content" },
                    { 43, new DateTime(2020, 10, 27, 17, 40, 0, 119, DateTimeKind.Local).AddTicks(9712), 6, null, 886, "Music, Kids & Movies content AGP calculate" },
                    { 44, new DateTime(2021, 3, 20, 11, 7, 50, 485, DateTimeKind.Local).AddTicks(2489), 6, null, 290, "virtual India primary programming" },
                    { 45, new DateTime(2020, 12, 14, 8, 12, 29, 815, DateTimeKind.Local).AddTicks(5778), 6, null, 190, "application purple reboot Namibia" },
                    { 46, new DateTime(2020, 8, 3, 21, 6, 31, 351, DateTimeKind.Local).AddTicks(1104), 6, null, 815, "SMS Hill Montserrat Ergonomic Cotton Salad" },
                    { 47, new DateTime(2020, 6, 20, 3, 4, 39, 225, DateTimeKind.Local).AddTicks(1183), 6, null, 128, "transition Shore Borders Isle" },
                    { 48, new DateTime(2021, 4, 14, 23, 23, 17, 401, DateTimeKind.Local).AddTicks(8444), 6, null, 748, "firewall applications AGP invoice" },
                    { 27, new DateTime(2020, 8, 6, 6, 16, 50, 12, DateTimeKind.Local).AddTicks(157), 6, null, 527, "virtual enterprise Games synergies" },
                    { 26, new DateTime(2021, 1, 13, 9, 3, 21, 433, DateTimeKind.Local).AddTicks(2608), 6, null, 563, "bricks-and-clicks Investment Account uniform Florida" },
                    { 25, new DateTime(2021, 1, 12, 21, 11, 59, 588, DateTimeKind.Local).AddTicks(1655), 6, null, 499, "Avon incubate Netherlands Antillian Guilder backing up" },
                    { 24, new DateTime(2020, 6, 11, 14, 47, 5, 982, DateTimeKind.Local).AddTicks(5716), 6, null, 825, "Berkshire Rustic Granite Computer card firmware" },
                    { 2, new DateTime(2020, 7, 30, 23, 54, 59, 14, DateTimeKind.Local).AddTicks(6522), 6, null, 288, "Dynamic Forward Mission Field" },
                    { 3, new DateTime(2020, 8, 25, 14, 30, 52, 18, DateTimeKind.Local).AddTicks(6317), 6, null, 301, "SSL throughput red Unbranded" },
                    { 4, new DateTime(2020, 7, 13, 22, 25, 39, 562, DateTimeKind.Local).AddTicks(3398), 6, null, 782, "Plastic withdrawal clear-thinking Gorgeous" },
                    { 5, new DateTime(2021, 3, 3, 21, 4, 39, 648, DateTimeKind.Local).AddTicks(5436), 6, null, 128, "Oregon generating 24 hour visualize" },
                    { 6, new DateTime(2020, 9, 9, 12, 37, 22, 385, DateTimeKind.Local).AddTicks(1484), 6, null, 624, "Plastic Awesome Soft Ball mesh Course" },
                    { 7, new DateTime(2021, 4, 5, 3, 31, 7, 590, DateTimeKind.Local).AddTicks(9396), 6, null, 409, "Buckinghamshire Malaysian Ringgit New Hampshire Jersey" },
                    { 8, new DateTime(2021, 1, 19, 4, 12, 31, 412, DateTimeKind.Local), 6, null, 641, "Isle capability repurpose deposit" },
                    { 9, new DateTime(2020, 11, 19, 9, 34, 25, 869, DateTimeKind.Local).AddTicks(5028), 6, null, 803, "back up invoice asymmetric Branch" },
                    { 10, new DateTime(2020, 8, 20, 16, 57, 11, 580, DateTimeKind.Local).AddTicks(3913), 6, null, 443, "Serbian Dinar regional Centralized International" },
                    { 11, new DateTime(2020, 10, 17, 1, 25, 41, 24, DateTimeKind.Local).AddTicks(9079), 6, null, 885, "magenta XSS Dynamic Phased" },
                    { 49, new DateTime(2020, 9, 8, 11, 52, 13, 132, DateTimeKind.Local).AddTicks(7089), 6, null, 905, "Keys bandwidth Yuan Renminbi Dynamic" },
                    { 12, new DateTime(2020, 12, 20, 2, 46, 15, 419, DateTimeKind.Local).AddTicks(3215), 6, null, 302, "AI Bedfordshire Architect Unbranded" },
                    { 14, new DateTime(2021, 4, 12, 20, 6, 38, 495, DateTimeKind.Local).AddTicks(5705), 6, null, 125, "program blue Handmade Fresh Soap parsing" },
                    { 15, new DateTime(2020, 6, 19, 5, 33, 10, 386, DateTimeKind.Local).AddTicks(7002), 6, null, 410, "withdrawal green synthesizing Strategist" },
                    { 16, new DateTime(2020, 7, 1, 14, 58, 52, 102, DateTimeKind.Local).AddTicks(8112), 6, null, 832, "wireless Small Cotton Keyboard Roads Metical" },
                    { 17, new DateTime(2020, 11, 22, 9, 27, 5, 119, DateTimeKind.Local).AddTicks(4910), 6, null, 191, "Credit Card Account Refined Plastic Pants Kids, Books & Tools Bedfordshire" },
                    { 18, new DateTime(2021, 2, 21, 10, 20, 58, 798, DateTimeKind.Local).AddTicks(7250), 6, null, 169, "Handcrafted Wooden Gloves haptic back up Australia" },
                    { 19, new DateTime(2021, 6, 5, 23, 45, 58, 669, DateTimeKind.Local).AddTicks(3455), 6, null, 584, "driver Plastic Kentucky feed" },
                    { 20, new DateTime(2020, 8, 16, 7, 19, 1, 972, DateTimeKind.Local).AddTicks(7697), 6, null, 561, "Optimization Personal Loan Account Forint copy" },
                    { 21, new DateTime(2020, 8, 13, 17, 53, 48, 198, DateTimeKind.Local).AddTicks(5643), 6, null, 529, "methodical Andorra Illinois Sports & Toys" },
                    { 22, new DateTime(2020, 12, 1, 4, 13, 10, 479, DateTimeKind.Local).AddTicks(2937), 6, null, 467, "Steel neural-net Saint Barthelemy hacking" },
                    { 23, new DateTime(2021, 4, 2, 12, 24, 6, 419, DateTimeKind.Local).AddTicks(9647), 6, null, 263, "Program calculate Uzbekistan Sum indexing" },
                    { 13, new DateTime(2020, 6, 27, 11, 1, 58, 493, DateTimeKind.Local).AddTicks(2075), 6, null, 814, "Baby & Sports Buckinghamshire Sleek Product" },
                    { 50, new DateTime(2021, 6, 2, 9, 24, 36, 617, DateTimeKind.Local).AddTicks(3193), 6, null, 443, "Massachusetts e-business Harbor Alaska" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
