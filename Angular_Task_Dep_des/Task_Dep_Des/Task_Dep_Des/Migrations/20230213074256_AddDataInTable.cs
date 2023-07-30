using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_Dep_Des.Migrations
{
    public partial class AddDataInTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Department
            migrationBuilder.Sql("insert Departments values('Accounts')");
            migrationBuilder.Sql("insert Departments values('Sales')");
            migrationBuilder.Sql("insert Departments values('Marketing')");

            //Designation
            migrationBuilder.Sql("insert Designations values('Project Manager')");
            migrationBuilder.Sql("insert Designations values('Team Leader')");
            migrationBuilder.Sql("insert Designations values('Employee')");
            migrationBuilder.Sql("insert Designations values('Trainee')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
