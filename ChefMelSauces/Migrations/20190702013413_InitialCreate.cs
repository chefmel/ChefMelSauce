using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChefMelSauces.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ECommerce",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sales = table.Column<short>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 25, nullable: false),
                    LastName = table.Column<string>(maxLength: 25, nullable: false),
                    StreetAddress = table.Column<string>(maxLength: 75, nullable: false),
                    City = table.Column<string>(maxLength: 75, nullable: false),
                    State = table.Column<string>(maxLength: 75, nullable: false),
                    ZipCode = table.Column<string>(maxLength: 75, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 10, nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 40, nullable: false),
                    CreditCardNumber = table.Column<string>(maxLength: 16, nullable: false),
                    ExpDate = table.Column<string>(maxLength: 25, nullable: false),
                    CvvCode = table.Column<int>(maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ECommerce", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ECommerce");
        }
    }
}
