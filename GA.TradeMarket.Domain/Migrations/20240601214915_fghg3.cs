﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GA.TradeMarket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class fghg3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343451634435", new DateTime(2024, 7, 24, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343424934435", new DateTime(2025, 7, 19, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343410734435", new DateTime(2025, 2, 8, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343412934435", new DateTime(2024, 8, 10, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343446534435", new DateTime(2025, 9, 23, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343448234435", new DateTime(2025, 10, 7, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343452734435", new DateTime(2025, 3, 21, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343439934435", new DateTime(2025, 2, 15, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "Buy", "Currency", "LogTime", "Sell" },
                values: new object[,]
                {
                    { 1L, 2.7m, "USD", new DateTime(2024, 6, 2, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(1854), 2.8m },
                    { 2L, 2.9m, "EUR", new DateTime(2024, 6, 2, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(1870), 2.85m },
                    { 3L, 2.65m, "GBP", new DateTime(2024, 6, 2, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(1871), 2.85m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343448734435", new DateTime(2025, 5, 19, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343421234435", new DateTime(2025, 9, 13, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343439934435", new DateTime(2024, 10, 19, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343436134435", new DateTime(2025, 5, 30, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE34342234435", new DateTime(2024, 9, 4, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343442434435", new DateTime(2024, 12, 12, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE34344234435", new DateTime(2024, 8, 20, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343439234435", new DateTime(2025, 8, 18, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "Buy", "Currency", "LogTime", "Sell" },
                values: new object[,]
                {
                    { 5L, 2.7m, "USD", new DateTime(2024, 6, 2, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5274), 2.8m },
                    { 6L, 2.9m, "EUR", new DateTime(2024, 6, 2, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5287), 2.85m },
                    { 7L, 2.65m, "GBP", new DateTime(2024, 6, 2, 1, 42, 25, 118, DateTimeKind.Local).AddTicks(5288), 2.85m }
                });
        }
    }
}
