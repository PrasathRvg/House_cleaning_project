using Microsoft.EntityFrameworkCore.Migrations;

namespace housecleaningApi.Migrations
{
    public partial class housecleaning : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "room_cost",
                columns: table => new
                {
                    room_id = table.Column<int>(type: "int", nullable: false),
                    room_name_sqft = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
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
                    user_id = table.Column<int>(type: "int", nullable: false),
                    request_no = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    rm_id = table.Column<int>(type: "int", nullable: false),
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
                    no_of_worship_rooms = table.Column<int>(type: "int", nullable: true),
                    no_of_store_rooms = table.Column<int>(type: "int", nullable: true),
                    living_room_sqft = table.Column<long>(type: "bigint", nullable: true),
                    kitchen_sqft = table.Column<long>(type: "bigint", nullable: true),
                    bedroom_sqft = table.Column<long>(type: "bigint", nullable: true),
                    bathroom_sqft = table.Column<long>(type: "bigint", nullable: true),
                    worship_sqft = table.Column<long>(type: "bigint", nullable: true),
                    store_room_sqft = table.Column<long>(type: "bigint", nullable: true),
                    preferred_days = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    total_amount = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_user_room_cost",
                        column: x => x.rm_id,
                        principalTable: "room_cost",
                        principalColumn: "room_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_user_tbl_rm_id",
                table: "user_tbl",
                column: "rm_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_tbl");

            migrationBuilder.DropTable(
                name: "room_cost");
        }
    }
}
