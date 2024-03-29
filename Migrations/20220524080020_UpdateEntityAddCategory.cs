﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCore_01.Migrations
{
    public partial class UpdateEntityAddCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Posts");
        }
    }
}
