using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Payment.Data.Migrations
{
    public partial class updateHIDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 636, DateTimeKind.Local).AddTicks(7717),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 478, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 636, DateTimeKind.Local).AddTicks(7075),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 478, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 632, DateTimeKind.Local).AddTicks(4145),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 475, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 632, DateTimeKind.Local).AddTicks(2931),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 475, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 629, DateTimeKind.Local).AddTicks(4032),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 473, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 629, DateTimeKind.Local).AddTicks(3076),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 473, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 627, DateTimeKind.Local).AddTicks(6611),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 472, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 627, DateTimeKind.Local).AddTicks(6138),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 472, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 625, DateTimeKind.Local).AddTicks(1232),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 470, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 625, DateTimeKind.Local).AddTicks(746),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 470, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.AddColumn<string>(
                name: "customerAddress",
                table: "HealthInsuranceDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 647, DateTimeKind.Local).AddTicks(2934),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 490, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 647, DateTimeKind.Local).AddTicks(2027),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 490, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 618, DateTimeKind.Local).AddTicks(6400),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 465, DateTimeKind.Local).AddTicks(1939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 618, DateTimeKind.Local).AddTicks(5980),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 465, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 602, DateTimeKind.Local).AddTicks(2624),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 453, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 599, DateTimeKind.Local).AddTicks(936),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 449, DateTimeKind.Local).AddTicks(1913));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "customerAddress",
                table: "HealthInsuranceDetail");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 478, DateTimeKind.Local).AddTicks(6692),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 636, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 478, DateTimeKind.Local).AddTicks(6163),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 636, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 475, DateTimeKind.Local).AddTicks(8282),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 632, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 475, DateTimeKind.Local).AddTicks(7889),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 632, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 473, DateTimeKind.Local).AddTicks(8838),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 629, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 473, DateTimeKind.Local).AddTicks(8384),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 629, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 472, DateTimeKind.Local).AddTicks(3424),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 627, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 472, DateTimeKind.Local).AddTicks(2581),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 627, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 470, DateTimeKind.Local).AddTicks(3277),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 625, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 470, DateTimeKind.Local).AddTicks(2809),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 625, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 490, DateTimeKind.Local).AddTicks(961),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 647, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 490, DateTimeKind.Local).AddTicks(488),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 647, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 465, DateTimeKind.Local).AddTicks(1939),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 618, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 465, DateTimeKind.Local).AddTicks(1533),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 618, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 453, DateTimeKind.Local).AddTicks(394),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 602, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 24, 20, 54, 21, 449, DateTimeKind.Local).AddTicks(1913),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 599, DateTimeKind.Local).AddTicks(936));
        }
    }
}
