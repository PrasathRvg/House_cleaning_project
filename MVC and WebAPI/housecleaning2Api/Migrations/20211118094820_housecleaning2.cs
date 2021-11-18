using Microsoft.EntityFrameworkCore.Migrations;

namespace housecleaning2Api.Migrations
{
    public partial class housecleaning2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "roomcost",
                columns: table => new
                {
                    room_id = table.Column<int>(type: "int", nullable: false),
                    room_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cost_per_sqft = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomcost", x => x.room_id);
                });

            migrationBuilder.CreateTable(
                name: "user_tbl",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false),
                    request_no = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    fullname = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    street_address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    phone_no = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    state = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    city = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    message = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    no_of_living_rooms = table.Column<int>(type: "int", nullable: true),
                    no_of_kitchens = table.Column<int>(type: "int", nullable: true),
                    no_of_bedrooms = table.Column<int>(type: "int", nullable: true),
                    no_of_bathrooms = table.Column<int>(type: "int", nullable: true),
                    living_room_sqft = table.Column<long>(type: "bigint", nullable: true),
                    kitchen_sqft = table.Column<long>(type: "bigint", nullable: true),
                    bedroom_sqft = table.Column<long>(type: "bigint", nullable: true),
                    bathroom_sqft = table.Column<long>(type: "bigint", nullable: true),
                    preferred_days = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    total_amount = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_tbl", x => x.user_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "roomcost");

            migrationBuilder.DropTable(
                name: "user_tbl");
        }
    }
}
