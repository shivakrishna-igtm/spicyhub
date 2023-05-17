using Microsoft.EntityFrameworkCore.Migrations;

namespace SpiceApp.Data.Migrations
{
    public partial class AddingMenuItemToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuItem_UKSARMA",
                columns: table => new
                {
                    MenuItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem_UKSARMA", x => x.MenuItemId);
                    table.ForeignKey(
                        name: "FK_MenuItem_UKSARMA_Category_UKSARMA_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category_UKSARMA",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_MenuItem_UKSARMA_SubCategory_UKSARMA_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategory_UKSARMA",
                        principalColumn: "SubCategoryId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_UKSARMA_CategoryId",
                table: "MenuItem_UKSARMA",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_UKSARMA_SubCategoryId",
                table: "MenuItem_UKSARMA",
                column: "SubCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItem_UKSARMA");
        }
    }
}
