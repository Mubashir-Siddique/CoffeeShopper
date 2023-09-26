using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddCoffeeShops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO [dbo].[CoffeeShops]([Name] ,[OpeningHours],[Address])     VALUES('Nescafe' ,'9-5 Mon-Sat','Test Address')");
            migrationBuilder.Sql($"INSERT INTO [dbo].[CoffeeShops]([Name] ,[OpeningHours],[Address])     VALUES('Nescafe' ,'9-5 Mon-Sat','Test Address')");
            migrationBuilder.Sql($"INSERT INTO [dbo].[CoffeeShops]([Name] ,[OpeningHours],[Address])     VALUES('Nescafe' ,'9-5 Mon-Sat','Test Address')");
            migrationBuilder.Sql($"INSERT INTO [dbo].[CoffeeShops]([Name] ,[OpeningHours],[Address])     VALUES('Nescafe' ,'9-5 Mon-Sat','Test Address')");
            migrationBuilder.Sql($"INSERT INTO [dbo].[CoffeeShops]([Name] ,[OpeningHours],[Address])     VALUES('Nescafe' ,'9-5 Mon-Sat','Test Address')");
            migrationBuilder.Sql($"INSERT INTO [dbo].[CoffeeShops]([Name] ,[OpeningHours],[Address])     VALUES('Nescafe' ,'9-5 Mon-Sat','Test Address')");
            migrationBuilder.Sql($"INSERT INTO [dbo].[CoffeeShops]([Name] ,[OpeningHours],[Address])     VALUES('Nescafe' ,'9-5 Mon-Sat','Test Address')");
            migrationBuilder.Sql($"INSERT INTO [dbo].[CoffeeShops]([Name] ,[OpeningHours],[Address])     VALUES('Nescafe' ,'9-5 Mon-Sat','Test Address')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
