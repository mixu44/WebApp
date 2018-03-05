using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Car",
                newName: "Model");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Car",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Car");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Car",
                newName: "Name");
        }
    }
}
