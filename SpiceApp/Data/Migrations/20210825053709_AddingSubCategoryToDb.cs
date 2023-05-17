using Microsoft.EntityFrameworkCore.Migrations;

namespace SpiceApp.Data.Migrations
{
    public partial class AddingSubCategoryToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubCategory_UKSARMA",
                columns: table => new
                {
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory_UKSARMA", x => x.SubCategoryId);
                    table.ForeignKey(
                        name: "FK_SubCategory_UKSARMA_Category_UKSARMA_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category_UKSARMA",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubCategory_UKSARMA_CategoryId",
                table: "SubCategory_UKSARMA",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategory_UKSARMA");
        }
    }
}
