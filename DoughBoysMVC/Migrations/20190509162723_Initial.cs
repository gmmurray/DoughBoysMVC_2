using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoughBoysMVC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerOrders",
                columns: table => new
                {
                    OrderNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    PhoneNo = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PickUpDate = table.Column<string>(nullable: false),
                    OrderDate = table.Column<string>(nullable: true),
                    DoughnutType = table.Column<string>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    OrderStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerOrders", x => x.OrderNo);
                });

            migrationBuilder.InsertData(
                table: "CustomerOrders",
                columns: new[] { "OrderNo", "DoughnutType", "Email", "FirstName", "LastName", "OrderDate", "OrderStatus", "PhoneNo", "PickUpDate", "Quantity" },
                values: new object[,]
                {
                    { 200, "Glazed", "email@email.com", "Greg", "M", "5/9/2019", false, "1234567890", "4/19/2019", 17 },
                    { 201, "Cinnamon Sugar", "email@email.com", "John", "Doe", "5/9/2019", false, "1234567890", "4/19/2019", 29 },
                    { 202, "Glazed", "email@email.com", "Jane", "Doe", "5/9/2019", false, "1234567890", "4/19/2019", 75 },
                    { 203, "Glazed", "email@email.com", "James", "Jameson", "5/9/2019", false, "1234567890", "4/19/2019", 99 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerOrders");
        }
    }
}
