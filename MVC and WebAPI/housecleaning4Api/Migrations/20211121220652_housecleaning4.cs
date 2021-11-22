using Microsoft.EntityFrameworkCore.Migrations;

namespace housecleaning4Api.Migrations
{
    public partial class housecleaning4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "room_cost",
                columns: table => new
                {
                    room_id = table.Column<int>(type: "int", nullable: false),
                    room_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cost_per_sqft = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room_cost", x => x.room_id);
                });

            migrationBuilder.CreateTable(
                name: "user_tbl",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullname = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    street_address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    phone_no = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    city = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    message = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    living_room_sqft = table.Column<long>(type: "bigint", nullable: true),
                    kitchen_sqft = table.Column<long>(type: "bigint", nullable: true),
                    bedroom_sqft = table.Column<long>(type: "bigint", nullable: true),
                    bathroom_sqft = table.Column<long>(type: "bigint", nullable: true),
                    preferred_days = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    total_amount = table.Column<long>(type: "bigint", nullable: false),
                    request_no = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false, computedColumnSql: "(concat(substring([city],(1),(3)),'-',datepart(year,getdate()),'-',right(concat('00',[user_id]),(3))))", stored: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_tbl", x => x.user_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "room_cost");

            migrationBuilder.DropTable(
                name: "user_tbl");
        }
    }
}
