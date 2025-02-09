using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    /// <inheritdoc />
    public partial class CreateUserSampleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Password", "Phone", "Role", "Status", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { new Guid("a13304d6-3748-4720-b1cf-149c4092fdc0"), new DateTime(2025, 2, 9, 13, 17, 8, 105, DateTimeKind.Utc), "jane@ambev.com.br", "$2a$11$A.3yd/ekyeIV8KrrZrJ7KuXBpnmwFlFDA85WZLRM076hZPrM.G6zC", "11984155566", "Customer", "Active", null, "Jane" },
                    { new Guid("bd43d49a-1246-4368-8ec1-03508d2c9bf1"), new DateTime(2025, 2, 9, 13, 17, 8, 105, DateTimeKind.Utc), "mary@ambev.com.br", "$2a$11$bSfY6FmnKx4QxnTOw9DHz.864wBSBWAAq.eeojS.c6POYGtp8iTWS", "11984153344", "Admin", "Active", null, "Mary" },
                    { new Guid("c205acda-f799-4620-af11-2d0d31c4cc61"), new DateTime(2025, 2, 9, 13, 17, 8, 105, DateTimeKind.Utc), "john@ambev.com.br", "$2a$11$98uK.e4T65eZLbZoM1m4UeTvWdq3Cv1Yb7GA.VfaNkq2RAreOTIxy", "11984151122", "Admin", "Active", null, "John" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a13304d6-3748-4720-b1cf-149c4092fdc0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd43d49a-1246-4368-8ec1-03508d2c9bf1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c205acda-f799-4620-af11-2d0d31c4cc61"));
        }
    }
}
