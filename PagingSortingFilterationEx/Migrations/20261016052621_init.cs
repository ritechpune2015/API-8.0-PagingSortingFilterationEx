using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PagingSortingFilterationEx.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "CreditLimit", "CustomerName", "EmailID" },
                values: new object[,]
                {
                    { 1L, "Nigdi", 4500m, "Manish", "manish@hotmail.com" },
                    { 2L, "Akurdi", 7500m, "Akash", "akash@hotmail.com" },
                    { 3L, "Nigdi", 9500m, "Amol", "amol@hotmail.com" },
                    { 4L, "Nigdi", 56500m, "Ajit", "Ajit@hotmail.com" },
                    { 5L, "Chinchwad", 6500m, "Nilesh", "nilesh@hotmail.com" },
                    { 6L, "Nigdi", 67500m, "Nitin", "nitin@hotmail.com" },
                    { 7L, "Pradhikaran", 7800m, "Rajesh", "rajesh@hotmail.com" },
                    { 8L, "Akurdi", 9800m, "Rakesh", "rakesh@hotmail.com" },
                    { 9L, "Shivaji nagar", 7800m, "Ranjeet", "Ranjeet@hotmail.com" },
                    { 10L, "karvenagar", 1800m, "Balaji", "Balaji@hotmail.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
