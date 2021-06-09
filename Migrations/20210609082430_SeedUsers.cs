using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesApis.Migrations
{
    public partial class SeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDateTime", "FirstName", "LastName", "LastUpdateDateTime", "Password" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 6, 22, 36, 1, 793, DateTimeKind.Local).AddTicks(9123), "Nels", "Price", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 73, new DateTime(2020, 7, 1, 10, 0, 56, 599, DateTimeKind.Local).AddTicks(5322), "Ramona", "Daugherty", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 72, new DateTime(2021, 5, 11, 23, 52, 52, 584, DateTimeKind.Local).AddTicks(7716), "Kattie", "Hagenes", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 71, new DateTime(2020, 9, 27, 7, 46, 8, 915, DateTimeKind.Local).AddTicks(7329), "Kaleb", "Predovic", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 70, new DateTime(2020, 12, 26, 17, 40, 14, 181, DateTimeKind.Local).AddTicks(8712), "Warren", "Marvin", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 69, new DateTime(2021, 2, 3, 19, 36, 3, 832, DateTimeKind.Local).AddTicks(2482), "Okey", "Rolfson", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 68, new DateTime(2020, 10, 9, 20, 4, 1, 287, DateTimeKind.Local).AddTicks(1970), "Lucas", "Nolan", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 67, new DateTime(2020, 8, 2, 10, 54, 46, 337, DateTimeKind.Local).AddTicks(6253), "Isai", "Maggio", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 66, new DateTime(2020, 9, 21, 5, 38, 33, 767, DateTimeKind.Local).AddTicks(6204), "Alycia", "Aufderhar", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 65, new DateTime(2020, 10, 1, 6, 2, 11, 210, DateTimeKind.Local).AddTicks(9471), "Douglas", "Runte", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 64, new DateTime(2020, 10, 14, 18, 59, 23, 640, DateTimeKind.Local).AddTicks(9514), "Lazaro", "Dibbert", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 63, new DateTime(2021, 4, 3, 11, 55, 58, 180, DateTimeKind.Local).AddTicks(5892), "Kathleen", "Littel", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 62, new DateTime(2021, 2, 16, 19, 15, 42, 708, DateTimeKind.Local).AddTicks(8629), "Joanie", "Tremblay", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 61, new DateTime(2021, 3, 3, 0, 2, 52, 762, DateTimeKind.Local).AddTicks(7472), "Ike", "Price", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 60, new DateTime(2021, 1, 31, 10, 14, 3, 15, DateTimeKind.Local).AddTicks(7625), "Oceane", "Weimann", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 59, new DateTime(2021, 1, 11, 8, 47, 21, 24, DateTimeKind.Local).AddTicks(589), "Bonita", "Corkery", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 58, new DateTime(2020, 8, 4, 5, 36, 20, 212, DateTimeKind.Local).AddTicks(1464), "Mable", "Toy", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 57, new DateTime(2021, 1, 16, 7, 30, 19, 284, DateTimeKind.Local).AddTicks(850), "Edyth", "Braun", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 56, new DateTime(2020, 11, 9, 18, 11, 11, 971, DateTimeKind.Local).AddTicks(5689), "Ana", "O'Keefe", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 55, new DateTime(2021, 1, 9, 19, 26, 27, 501, DateTimeKind.Local).AddTicks(4122), "Marjory", "Smith", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 54, new DateTime(2021, 5, 11, 1, 26, 15, 239, DateTimeKind.Local).AddTicks(6082), "Newell", "Sanford", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 53, new DateTime(2020, 7, 13, 13, 55, 49, 971, DateTimeKind.Local).AddTicks(3010), "Jalyn", "Nienow", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 74, new DateTime(2021, 4, 29, 16, 56, 8, 408, DateTimeKind.Local).AddTicks(1359), "Beaulah", "Lakin", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 52, new DateTime(2020, 6, 29, 1, 21, 50, 846, DateTimeKind.Local).AddTicks(280), "Maudie", "Metz", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 75, new DateTime(2020, 7, 9, 13, 1, 51, 693, DateTimeKind.Local).AddTicks(1058), "Grace", "Pfeffer", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 77, new DateTime(2021, 4, 23, 22, 49, 40, 748, DateTimeKind.Local).AddTicks(6155), "Carmelo", "Blanda", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 98, new DateTime(2020, 9, 24, 7, 5, 34, 120, DateTimeKind.Local).AddTicks(1290), "Ayana", "Stiedemann", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 97, new DateTime(2020, 11, 17, 11, 42, 8, 123, DateTimeKind.Local).AddTicks(7511), "Emily", "Rowe", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 96, new DateTime(2020, 6, 18, 3, 45, 42, 704, DateTimeKind.Local).AddTicks(2126), "Eduardo", "Von", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 95, new DateTime(2020, 8, 7, 1, 23, 38, 666, DateTimeKind.Local).AddTicks(9578), "Malinda", "Lowe", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 94, new DateTime(2020, 10, 14, 17, 42, 4, 149, DateTimeKind.Local).AddTicks(7691), "Herminia", "Schiller", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 93, new DateTime(2020, 10, 24, 9, 12, 22, 948, DateTimeKind.Local).AddTicks(6991), "Bryce", "O'Reilly", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 92, new DateTime(2020, 7, 5, 16, 34, 1, 487, DateTimeKind.Local).AddTicks(2172), "Peter", "Connelly", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 91, new DateTime(2020, 12, 28, 17, 25, 1, 126, DateTimeKind.Local).AddTicks(1435), "Alberta", "DuBuque", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 90, new DateTime(2020, 12, 5, 17, 14, 43, 520, DateTimeKind.Local).AddTicks(1977), "Enola", "Bechtelar", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 89, new DateTime(2021, 1, 23, 1, 40, 33, 37, DateTimeKind.Local).AddTicks(7092), "Enrico", "Sporer", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 88, new DateTime(2020, 12, 9, 15, 35, 46, 668, DateTimeKind.Local).AddTicks(9497), "Dalton", "Schulist", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 87, new DateTime(2021, 1, 22, 18, 28, 17, 369, DateTimeKind.Local).AddTicks(4786), "Ned", "Balistreri", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 86, new DateTime(2020, 6, 25, 9, 10, 47, 962, DateTimeKind.Local).AddTicks(1582), "Nakia", "Flatley", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 85, new DateTime(2021, 5, 19, 11, 40, 9, 263, DateTimeKind.Local).AddTicks(7454), "Ora", "Heathcote", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 84, new DateTime(2020, 8, 6, 22, 36, 42, 522, DateTimeKind.Local).AddTicks(1088), "Leonel", "Feil", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 83, new DateTime(2020, 12, 24, 6, 58, 16, 995, DateTimeKind.Local).AddTicks(6607), "Vanessa", "Reilly", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 82, new DateTime(2020, 12, 11, 22, 45, 5, 782, DateTimeKind.Local).AddTicks(9447), "Moses", "Berge", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 81, new DateTime(2020, 6, 20, 15, 35, 39, 189, DateTimeKind.Local).AddTicks(3572), "Violet", "Mayert", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 80, new DateTime(2021, 4, 17, 23, 11, 23, 361, DateTimeKind.Local).AddTicks(2294), "Lelah", "Rice", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 79, new DateTime(2021, 5, 20, 15, 5, 45, 714, DateTimeKind.Local).AddTicks(5511), "Jewel", "Schmitt", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 78, new DateTime(2021, 1, 23, 7, 0, 53, 447, DateTimeKind.Local).AddTicks(2283), "Matilda", "Hammes", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 76, new DateTime(2021, 4, 25, 16, 39, 58, 551, DateTimeKind.Local).AddTicks(1177), "Natalia", "Hirthe", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 51, new DateTime(2020, 8, 14, 5, 7, 54, 591, DateTimeKind.Local).AddTicks(1306), "Griffin", "Feil", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 50, new DateTime(2021, 4, 10, 5, 3, 39, 407, DateTimeKind.Local).AddTicks(9225), "Toy", "Russel", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 49, new DateTime(2021, 3, 21, 9, 29, 7, 240, DateTimeKind.Local).AddTicks(4647), "Libbie", "Lakin", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 22, new DateTime(2020, 7, 14, 3, 36, 45, 774, DateTimeKind.Local).AddTicks(9164), "Cicero", "Kuphal", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 21, new DateTime(2021, 2, 3, 23, 2, 19, 783, DateTimeKind.Local).AddTicks(5514), "Cayla", "Sawayn", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 20, new DateTime(2020, 12, 8, 17, 25, 19, 53, DateTimeKind.Local).AddTicks(9108), "Lane", "Greenfelder", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 19, new DateTime(2021, 5, 13, 2, 51, 17, 859, DateTimeKind.Local).AddTicks(2699), "Cali", "Walter", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 18, new DateTime(2020, 10, 8, 15, 52, 32, 996, DateTimeKind.Local).AddTicks(4674), "Martine", "Strosin", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 17, new DateTime(2020, 8, 17, 1, 52, 3, 262, DateTimeKind.Local).AddTicks(4924), "Alec", "O'Keefe", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 16, new DateTime(2020, 8, 22, 4, 36, 45, 887, DateTimeKind.Local).AddTicks(4269), "Kathryn", "Leuschke", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 15, new DateTime(2021, 1, 31, 15, 32, 20, 246, DateTimeKind.Local).AddTicks(6530), "Emmanuel", "Kiehn", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 14, new DateTime(2020, 6, 12, 17, 46, 42, 656, DateTimeKind.Local).AddTicks(7967), "Aidan", "Auer", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 13, new DateTime(2021, 5, 30, 0, 53, 24, 529, DateTimeKind.Local).AddTicks(5283), "Cesar", "Beier", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 12, new DateTime(2020, 12, 18, 9, 48, 7, 776, DateTimeKind.Local).AddTicks(2003), "Virginia", "Witting", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 11, new DateTime(2021, 1, 31, 14, 57, 53, 246, DateTimeKind.Local).AddTicks(1892), "Trenton", "Walsh", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 10, new DateTime(2020, 10, 1, 20, 8, 59, 405, DateTimeKind.Local).AddTicks(2196), "Wendy", "McGlynn", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 9, new DateTime(2021, 2, 26, 4, 18, 22, 124, DateTimeKind.Local).AddTicks(5023), "Abigail", "Goyette", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 8, new DateTime(2020, 11, 8, 19, 36, 31, 516, DateTimeKind.Local).AddTicks(1228), "Reilly", "Mueller", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 7, new DateTime(2021, 4, 3, 20, 33, 42, 177, DateTimeKind.Local).AddTicks(3777), "Kailyn", "Lueilwitz", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 6, new DateTime(2020, 11, 3, 15, 39, 48, 609, DateTimeKind.Local).AddTicks(8464), "Harrison", "Koepp", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 5, new DateTime(2020, 9, 14, 17, 35, 36, 936, DateTimeKind.Local).AddTicks(4649), "Hanna", "Marvin", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 4, new DateTime(2020, 6, 10, 6, 13, 39, 942, DateTimeKind.Local).AddTicks(4074), "Hortense", "Sipes", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 3, new DateTime(2020, 7, 25, 13, 29, 13, 53, DateTimeKind.Local).AddTicks(9392), "Nina", "Ward", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 2, new DateTime(2020, 12, 26, 10, 45, 59, 497, DateTimeKind.Local).AddTicks(9983), "Eleanora", "Sauer", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 23, new DateTime(2020, 11, 1, 15, 35, 21, 263, DateTimeKind.Local).AddTicks(649), "Lukas", "Kilback", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 24, new DateTime(2021, 1, 13, 12, 26, 34, 173, DateTimeKind.Local).AddTicks(9870), "Destini", "Flatley", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 25, new DateTime(2020, 11, 26, 11, 34, 47, 929, DateTimeKind.Local).AddTicks(5601), "Kenyon", "Leannon", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 26, new DateTime(2021, 4, 3, 21, 55, 33, 930, DateTimeKind.Local).AddTicks(2907), "Claude", "Kuvalis", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 48, new DateTime(2020, 7, 30, 10, 2, 22, 193, DateTimeKind.Local).AddTicks(1516), "Maynard", "Lubowitz", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 47, new DateTime(2021, 4, 24, 1, 27, 13, 235, DateTimeKind.Local).AddTicks(4203), "Josie", "Konopelski", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 46, new DateTime(2021, 4, 3, 18, 26, 25, 664, DateTimeKind.Local).AddTicks(429), "Maci", "Green", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 45, new DateTime(2020, 11, 21, 16, 26, 16, 103, DateTimeKind.Local).AddTicks(1028), "Davin", "Sauer", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 44, new DateTime(2021, 1, 25, 10, 21, 32, 629, DateTimeKind.Local).AddTicks(9556), "Eliane", "Little", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 43, new DateTime(2020, 10, 8, 7, 20, 28, 372, DateTimeKind.Local).AddTicks(1603), "Lonzo", "Bauch", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 42, new DateTime(2020, 10, 11, 10, 7, 22, 350, DateTimeKind.Local).AddTicks(5971), "Keanu", "Stokes", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 41, new DateTime(2020, 10, 23, 7, 24, 39, 727, DateTimeKind.Local).AddTicks(8650), "Ross", "Williamson", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 40, new DateTime(2021, 3, 10, 14, 4, 55, 656, DateTimeKind.Local).AddTicks(7137), "Hanna", "Hahn", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 39, new DateTime(2020, 8, 9, 6, 3, 24, 483, DateTimeKind.Local).AddTicks(3316), "Nikko", "Paucek", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 99, new DateTime(2020, 9, 3, 17, 9, 8, 42, DateTimeKind.Local).AddTicks(4899), "Nyasia", "Roberts", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 38, new DateTime(2020, 8, 8, 3, 48, 29, 983, DateTimeKind.Local).AddTicks(5580), "Sincere", "Hettinger", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 36, new DateTime(2021, 1, 31, 20, 21, 17, 542, DateTimeKind.Local).AddTicks(5174), "Haleigh", "Cartwright", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 35, new DateTime(2021, 1, 10, 1, 56, 11, 61, DateTimeKind.Local).AddTicks(7405), "Cletus", "Runolfsson", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 34, new DateTime(2021, 5, 7, 1, 49, 23, 382, DateTimeKind.Local).AddTicks(8395), "Isai", "Ullrich", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 33, new DateTime(2020, 6, 29, 19, 30, 39, 412, DateTimeKind.Local).AddTicks(179), "Luther", "Cole", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 32, new DateTime(2021, 3, 15, 7, 50, 34, 38, DateTimeKind.Local).AddTicks(2267), "Juliet", "Stanton", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 31, new DateTime(2020, 9, 1, 9, 14, 50, 689, DateTimeKind.Local).AddTicks(1343), "Grayson", "McClure", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 30, new DateTime(2021, 5, 24, 5, 39, 14, 370, DateTimeKind.Local).AddTicks(8409), "Marlen", "Schumm", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 29, new DateTime(2021, 5, 20, 7, 18, 19, 680, DateTimeKind.Local).AddTicks(6987), "Scotty", "Friesen", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 28, new DateTime(2020, 7, 4, 4, 29, 20, 609, DateTimeKind.Local).AddTicks(1533), "Jazmyn", "Wiegand", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 27, new DateTime(2020, 9, 11, 4, 37, 9, 180, DateTimeKind.Local).AddTicks(6196), "Daphney", "Kling", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 37, new DateTime(2021, 1, 5, 2, 26, 46, 55, DateTimeKind.Local).AddTicks(4125), "Brett", "Will", null, "25d55ad283aa400af464c76d713c07ad" },
                    { 100, new DateTime(2021, 3, 21, 20, 28, 42, 630, DateTimeKind.Local).AddTicks(106), "Janie", "Jast", null, "25d55ad283aa400af464c76d713c07ad" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
