using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesApis.Migrations
{
    public partial class UsersTableMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

          

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDateTime", "FirstName", "LastName", "LastUpdateDateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 23, 20, 6, 46, 579, DateTimeKind.Local).AddTicks(3755), "Kenna", "Prohaska", null },
                    { 73, new DateTime(2021, 1, 4, 9, 44, 16, 467, DateTimeKind.Local).AddTicks(9086), "Ramona", "Gleason", null },
                    { 72, new DateTime(2021, 1, 13, 13, 52, 46, 764, DateTimeKind.Local).AddTicks(5090), "Carole", "Treutel", null },
                    { 71, new DateTime(2020, 9, 7, 5, 45, 0, 159, DateTimeKind.Local).AddTicks(4476), "Jovany", "Kovacek", null },
                    { 70, new DateTime(2021, 2, 17, 3, 7, 54, 383, DateTimeKind.Local).AddTicks(3297), "Anais", "Steuber", null },
                    { 69, new DateTime(2020, 10, 20, 1, 47, 34, 778, DateTimeKind.Local).AddTicks(4076), "Kaden", "Walsh", null },
                    { 68, new DateTime(2021, 1, 22, 16, 4, 39, 775, DateTimeKind.Local).AddTicks(1770), "Cruz", "King", null },
                    { 67, new DateTime(2020, 12, 19, 0, 50, 13, 613, DateTimeKind.Local).AddTicks(4028), "Marcos", "Rath", null },
                    { 66, new DateTime(2020, 10, 16, 12, 25, 24, 448, DateTimeKind.Local).AddTicks(520), "Krystina", "Crona", null },
                    { 65, new DateTime(2020, 7, 16, 21, 7, 36, 482, DateTimeKind.Local).AddTicks(8661), "Mafalda", "Cummerata", null },
                    { 64, new DateTime(2020, 9, 19, 8, 34, 48, 265, DateTimeKind.Local).AddTicks(3557), "Zane", "Wiza", null },
                    { 63, new DateTime(2020, 8, 16, 18, 23, 58, 159, DateTimeKind.Local).AddTicks(8511), "Darlene", "Gutkowski", null },
                    { 62, new DateTime(2021, 4, 30, 5, 25, 22, 787, DateTimeKind.Local).AddTicks(225), "Merlin", "Carroll", null },
                    { 61, new DateTime(2020, 11, 11, 18, 25, 9, 424, DateTimeKind.Local).AddTicks(362), "Danial", "Huels", null },
                    { 60, new DateTime(2021, 1, 30, 7, 30, 59, 510, DateTimeKind.Local).AddTicks(7785), "Newton", "Conn", null },
                    { 59, new DateTime(2020, 12, 27, 1, 47, 7, 402, DateTimeKind.Local).AddTicks(5202), "Cristobal", "Welch", null },
                    { 58, new DateTime(2021, 5, 11, 13, 43, 30, 283, DateTimeKind.Local).AddTicks(8613), "Colleen", "Kemmer", null },
                    { 57, new DateTime(2021, 4, 11, 15, 11, 6, 23, DateTimeKind.Local).AddTicks(8119), "Christopher", "Connelly", null },
                    { 56, new DateTime(2020, 11, 25, 17, 10, 41, 193, DateTimeKind.Local).AddTicks(6658), "Jewel", "Erdman", null },
                    { 55, new DateTime(2020, 12, 19, 4, 18, 16, 545, DateTimeKind.Local).AddTicks(6822), "Whitney", "Littel", null },
                    { 54, new DateTime(2021, 1, 19, 20, 1, 17, 420, DateTimeKind.Local).AddTicks(1815), "Brad", "Schimmel", null },
                    { 53, new DateTime(2020, 12, 2, 19, 16, 18, 922, DateTimeKind.Local).AddTicks(818), "Dameon", "Towne", null },
                    { 74, new DateTime(2020, 7, 8, 10, 37, 16, 310, DateTimeKind.Local).AddTicks(6518), "Francesca", "Glover", null },
                    { 52, new DateTime(2020, 6, 19, 12, 51, 16, 252, DateTimeKind.Local).AddTicks(6502), "Ansley", "Friesen", null },
                    { 75, new DateTime(2021, 4, 8, 4, 27, 35, 922, DateTimeKind.Local).AddTicks(6857), "Mitchel", "Dicki", null },
                    { 77, new DateTime(2020, 8, 25, 2, 53, 10, 399, DateTimeKind.Local).AddTicks(8859), "Cheyenne", "Murray", null },
                    { 98, new DateTime(2021, 5, 8, 23, 3, 45, 529, DateTimeKind.Local).AddTicks(9330), "Mathew", "Zboncak", null },
                    { 97, new DateTime(2020, 12, 1, 0, 56, 5, 470, DateTimeKind.Local).AddTicks(3632), "Winfield", "Hartmann", null },
                    { 96, new DateTime(2020, 8, 30, 19, 55, 5, 570, DateTimeKind.Local).AddTicks(6847), "Sonia", "McDermott", null },
                    { 95, new DateTime(2020, 7, 30, 17, 29, 13, 328, DateTimeKind.Local).AddTicks(9544), "Zoie", "Pfannerstill", null },
                    { 94, new DateTime(2021, 5, 23, 11, 8, 9, 579, DateTimeKind.Local).AddTicks(7317), "Mallie", "Kozey", null },
                    { 93, new DateTime(2020, 9, 19, 4, 1, 59, 480, DateTimeKind.Local).AddTicks(9145), "Janiya", "Erdman", null },
                    { 92, new DateTime(2021, 5, 5, 14, 28, 18, 684, DateTimeKind.Local).AddTicks(8238), "Dariana", "Towne", null },
                    { 91, new DateTime(2021, 5, 7, 12, 22, 2, 17, DateTimeKind.Local).AddTicks(8482), "Izabella", "Morar", null },
                    { 90, new DateTime(2020, 7, 19, 20, 41, 34, 671, DateTimeKind.Local).AddTicks(3807), "Enrique", "Gorczany", null },
                    { 89, new DateTime(2021, 1, 17, 8, 26, 25, 434, DateTimeKind.Local).AddTicks(857), "Joseph", "Raynor", null },
                    { 88, new DateTime(2021, 3, 18, 14, 0, 29, 699, DateTimeKind.Local).AddTicks(9451), "Frederique", "Swift", null },
                    { 87, new DateTime(2021, 1, 20, 1, 28, 43, 227, DateTimeKind.Local).AddTicks(5838), "Coralie", "Botsford", null },
                    { 86, new DateTime(2021, 3, 7, 4, 52, 24, 417, DateTimeKind.Local).AddTicks(3045), "Katlynn", "Kulas", null },
                    { 85, new DateTime(2020, 12, 28, 23, 25, 30, 787, DateTimeKind.Local).AddTicks(8515), "Dahlia", "Hagenes", null },
                    { 84, new DateTime(2020, 7, 17, 21, 40, 2, 509, DateTimeKind.Local).AddTicks(8807), "Jermey", "Rutherford", null },
                    { 83, new DateTime(2021, 3, 2, 11, 58, 33, 166, DateTimeKind.Local).AddTicks(7769), "Vito", "Kuphal", null },
                    { 82, new DateTime(2020, 12, 6, 19, 58, 55, 532, DateTimeKind.Local).AddTicks(9655), "Joanny", "Kozey", null },
                    { 81, new DateTime(2020, 12, 27, 15, 58, 23, 820, DateTimeKind.Local).AddTicks(1675), "Jaqueline", "Dare", null },
                    { 80, new DateTime(2021, 3, 29, 17, 21, 46, 570, DateTimeKind.Local).AddTicks(9854), "Clifton", "Dare", null },
                    { 79, new DateTime(2020, 6, 27, 16, 32, 33, 828, DateTimeKind.Local).AddTicks(8009), "Shawna", "Anderson", null },
                    { 78, new DateTime(2021, 1, 3, 13, 43, 2, 979, DateTimeKind.Local).AddTicks(3149), "Queenie", "Bode", null },
                    { 76, new DateTime(2021, 3, 3, 0, 5, 6, 750, DateTimeKind.Local).AddTicks(4903), "Ignacio", "Littel", null },
                    { 51, new DateTime(2021, 4, 20, 19, 27, 50, 826, DateTimeKind.Local).AddTicks(2721), "Brain", "Bergstrom", null },
                    { 50, new DateTime(2020, 9, 28, 14, 8, 1, 219, DateTimeKind.Local).AddTicks(9468), "Lonny", "Larkin", null },
                    { 49, new DateTime(2020, 9, 8, 3, 55, 34, 338, DateTimeKind.Local).AddTicks(5774), "Coy", "Pfeffer", null },
                    { 22, new DateTime(2020, 11, 3, 18, 10, 51, 692, DateTimeKind.Local).AddTicks(9971), "Donnie", "Mosciski", null },
                    { 21, new DateTime(2021, 4, 30, 0, 13, 46, 987, DateTimeKind.Local).AddTicks(7298), "Lesley", "Brakus", null },
                    { 20, new DateTime(2020, 10, 15, 11, 39, 14, 983, DateTimeKind.Local).AddTicks(6974), "Wilfredo", "Raynor", null },
                    { 19, new DateTime(2021, 3, 23, 18, 0, 34, 893, DateTimeKind.Local).AddTicks(2797), "Lelah", "Cole", null },
                    { 18, new DateTime(2020, 11, 26, 22, 20, 19, 235, DateTimeKind.Local).AddTicks(3848), "Halie", "Frami", null },
                    { 17, new DateTime(2020, 10, 22, 13, 9, 21, 640, DateTimeKind.Local).AddTicks(5843), "Seamus", "Jerde", null },
                    { 16, new DateTime(2020, 10, 6, 21, 17, 23, 960, DateTimeKind.Local).AddTicks(4238), "Cortney", "Schamberger", null },
                    { 15, new DateTime(2020, 7, 7, 7, 36, 34, 993, DateTimeKind.Local).AddTicks(2494), "Cecil", "Strosin", null },
                    { 14, new DateTime(2020, 7, 16, 10, 14, 6, 987, DateTimeKind.Local).AddTicks(1260), "Antonia", "Mitchell", null },
                    { 13, new DateTime(2020, 12, 8, 8, 45, 2, 567, DateTimeKind.Local).AddTicks(9108), "Emmie", "Kutch", null },
                    { 12, new DateTime(2020, 12, 12, 16, 55, 11, 813, DateTimeKind.Local).AddTicks(6357), "Gilberto", "Ebert", null },
                    { 11, new DateTime(2020, 12, 6, 18, 36, 11, 809, DateTimeKind.Local).AddTicks(4133), "Roselyn", "Rowe", null },
                    { 10, new DateTime(2021, 4, 20, 6, 47, 0, 183, DateTimeKind.Local).AddTicks(8273), "Leif", "Schmidt", null },
                    { 9, new DateTime(2020, 12, 1, 15, 56, 20, 991, DateTimeKind.Local).AddTicks(9842), "Orlo", "Bradtke", null },
                    { 8, new DateTime(2021, 2, 16, 6, 7, 33, 724, DateTimeKind.Local).AddTicks(7618), "Horacio", "Kulas", null },
                    { 7, new DateTime(2020, 7, 30, 8, 20, 39, 714, DateTimeKind.Local).AddTicks(9215), "Tracy", "Heidenreich", null },
                    { 6, new DateTime(2020, 12, 30, 6, 40, 54, 60, DateTimeKind.Local).AddTicks(3589), "Louisa", "Hackett", null },
                    { 5, new DateTime(2020, 8, 18, 8, 27, 50, 561, DateTimeKind.Local).AddTicks(1835), "Anita", "Nitzsche", null },
                    { 4, new DateTime(2021, 4, 29, 4, 9, 49, 202, DateTimeKind.Local).AddTicks(2576), "Jameson", "Hermann", null },
                    { 3, new DateTime(2021, 1, 10, 22, 52, 21, 751, DateTimeKind.Local).AddTicks(3868), "Melany", "Upton", null },
                    { 2, new DateTime(2021, 4, 21, 22, 12, 16, 568, DateTimeKind.Local).AddTicks(6106), "Jerrell", "Rogahn", null },
                    { 23, new DateTime(2021, 1, 2, 9, 52, 1, 951, DateTimeKind.Local).AddTicks(2815), "Lennie", "Padberg", null },
                    { 24, new DateTime(2020, 8, 17, 15, 3, 38, 338, DateTimeKind.Local).AddTicks(9582), "Emma", "Halvorson", null },
                    { 25, new DateTime(2020, 9, 10, 0, 22, 46, 578, DateTimeKind.Local).AddTicks(8143), "Trisha", "Stracke", null },
                    { 26, new DateTime(2020, 10, 24, 15, 0, 42, 790, DateTimeKind.Local).AddTicks(4865), "Vidal", "Gislason", null },
                    { 48, new DateTime(2021, 4, 18, 5, 29, 37, 560, DateTimeKind.Local).AddTicks(717), "Brett", "Dibbert", null },
                    { 47, new DateTime(2020, 6, 20, 12, 35, 5, 966, DateTimeKind.Local).AddTicks(7361), "Edwina", "Pfeffer", null },
                    { 46, new DateTime(2021, 4, 6, 7, 10, 10, 462, DateTimeKind.Local).AddTicks(5268), "Cleta", "Mohr", null },
                    { 45, new DateTime(2020, 6, 21, 12, 58, 31, 875, DateTimeKind.Local).AddTicks(9399), "Furman", "Beier", null },
                    { 44, new DateTime(2021, 1, 25, 20, 27, 38, 20, DateTimeKind.Local).AddTicks(2383), "Dedrick", "Daniel", null },
                    { 43, new DateTime(2021, 1, 11, 17, 41, 36, 882, DateTimeKind.Local).AddTicks(4696), "Alden", "Bogisich", null },
                    { 42, new DateTime(2020, 6, 17, 16, 47, 0, 563, DateTimeKind.Local).AddTicks(7256), "Felicia", "Bauch", null },
                    { 41, new DateTime(2020, 7, 17, 18, 6, 48, 899, DateTimeKind.Local).AddTicks(6532), "Arianna", "Nader", null },
                    { 40, new DateTime(2021, 4, 3, 2, 48, 5, 891, DateTimeKind.Local).AddTicks(4345), "Miracle", "Runolfsdottir", null },
                    { 39, new DateTime(2021, 1, 22, 19, 33, 1, 210, DateTimeKind.Local).AddTicks(6442), "Ethelyn", "Runolfsson", null },
                    { 99, new DateTime(2021, 2, 18, 16, 54, 42, 411, DateTimeKind.Local).AddTicks(3653), "Randi", "Breitenberg", null },
                    { 38, new DateTime(2021, 4, 14, 19, 23, 11, 252, DateTimeKind.Local).AddTicks(1043), "Lafayette", "Medhurst", null },
                    { 36, new DateTime(2021, 1, 20, 3, 26, 12, 528, DateTimeKind.Local).AddTicks(309), "Reece", "Kovacek", null },
                    { 35, new DateTime(2021, 5, 3, 17, 38, 52, 39, DateTimeKind.Local).AddTicks(2961), "Dax", "Lynch", null },
                    { 34, new DateTime(2021, 4, 27, 15, 48, 33, 497, DateTimeKind.Local).AddTicks(3188), "Erik", "Mitchell", null },
                    { 33, new DateTime(2021, 3, 8, 17, 53, 4, 393, DateTimeKind.Local).AddTicks(285), "Parker", "Treutel", null },
                    { 32, new DateTime(2020, 12, 7, 23, 5, 51, 892, DateTimeKind.Local).AddTicks(8089), "Royal", "Koch", null },
                    { 31, new DateTime(2020, 8, 27, 2, 9, 56, 297, DateTimeKind.Local).AddTicks(2403), "Doyle", "Heaney", null },
                    { 30, new DateTime(2021, 5, 10, 7, 53, 9, 200, DateTimeKind.Local).AddTicks(3572), "Watson", "Sawayn", null },
                    { 29, new DateTime(2020, 12, 2, 6, 14, 8, 165, DateTimeKind.Local).AddTicks(3072), "Joelle", "Kertzmann", null },
                    { 28, new DateTime(2021, 1, 18, 7, 41, 59, 430, DateTimeKind.Local).AddTicks(8626), "Roselyn", "Rempel", null },
                    { 27, new DateTime(2021, 2, 15, 7, 46, 4, 384, DateTimeKind.Local).AddTicks(8334), "Gerson", "Mante", null },
                    { 37, new DateTime(2020, 7, 26, 20, 23, 28, 49, DateTimeKind.Local).AddTicks(3848), "Pamela", "Nolan", null },
                    { 100, new DateTime(2020, 9, 6, 2, 8, 23, 378, DateTimeKind.Local).AddTicks(7258), "Dalton", "Yundt", null }
                });

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
         

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
