﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Varico.EF.Migrations
{
    /// <inheritdoc />
    public partial class AddedPictureUrlToCars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PictureURL",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureURL",
                table: "Cars");
        }
    }
}
