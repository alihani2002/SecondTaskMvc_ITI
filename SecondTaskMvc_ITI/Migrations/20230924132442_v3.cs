using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecondTaskMvc_ITI.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_EmpolyeeProject_Project_Id",
                table: "EmpolyeeProject",
                column: "Project_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Empolyee_Office_Id",
                table: "Empolyee",
                column: "Office_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Empolyee_Office_Office_Id",
                table: "Empolyee",
                column: "Office_Id",
                principalTable: "Office",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpolyeeProject_Empolyee_Emp_Id",
                table: "EmpolyeeProject",
                column: "Emp_Id",
                principalTable: "Empolyee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpolyeeProject_project_Project_Id",
                table: "EmpolyeeProject",
                column: "Project_Id",
                principalTable: "project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empolyee_Office_Office_Id",
                table: "Empolyee");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpolyeeProject_Empolyee_Emp_Id",
                table: "EmpolyeeProject");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpolyeeProject_project_Project_Id",
                table: "EmpolyeeProject");

            migrationBuilder.DropIndex(
                name: "IX_EmpolyeeProject_Project_Id",
                table: "EmpolyeeProject");

            migrationBuilder.DropIndex(
                name: "IX_Empolyee_Office_Id",
                table: "Empolyee");
        }
    }
}
