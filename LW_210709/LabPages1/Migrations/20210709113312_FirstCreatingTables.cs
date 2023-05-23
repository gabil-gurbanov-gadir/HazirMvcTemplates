using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LabPages1.Migrations
{
    public partial class FirstCreatingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Desc = table.Column<string>(maxLength: 500, nullable: false),
                    BlogTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    ImgName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoName = table.Column<string>(maxLength: 25, nullable: false),
                    Phone = table.Column<string>(maxLength: 25, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    Street = table.Column<string>(maxLength: 100, nullable: false),
                    City = table.Column<string>(maxLength: 25, nullable: false),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    HomeTitle = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogServices_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogServices_BlogId",
                table: "BlogServices",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogServices_ServiceId",
                table: "BlogServices",
                column: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogServices");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
