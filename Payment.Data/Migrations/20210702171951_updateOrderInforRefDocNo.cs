using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Payment.Data.Migrations
{
    public partial class updateOrderInforRefDocNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 503, DateTimeKind.Local).AddTicks(6091),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 313, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 503, DateTimeKind.Local).AddTicks(5648),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 313, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 501, DateTimeKind.Local).AddTicks(2694),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 311, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 501, DateTimeKind.Local).AddTicks(2359),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 311, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 499, DateTimeKind.Local).AddTicks(5262),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 309, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 499, DateTimeKind.Local).AddTicks(4916),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 309, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 498, DateTimeKind.Local).AddTicks(1518),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 308, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 498, DateTimeKind.Local).AddTicks(1070),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 308, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.AddColumn<string>(
                name: "refDocNo",
                table: "OrderInfor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 496, DateTimeKind.Local).AddTicks(5853),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 307, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 496, DateTimeKind.Local).AddTicks(5506),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 307, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 511, DateTimeKind.Local).AddTicks(7875),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 321, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 511, DateTimeKind.Local).AddTicks(7448),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 321, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 491, DateTimeKind.Local).AddTicks(6406),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 303, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 491, DateTimeKind.Local).AddTicks(6057),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 302, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 481, DateTimeKind.Local).AddTicks(8773),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 293, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 479, DateTimeKind.Local).AddTicks(1907),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 291, DateTimeKind.Local).AddTicks(2997));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "refDocNo",
                table: "OrderInfor");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 313, DateTimeKind.Local).AddTicks(8180),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 503, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 313, DateTimeKind.Local).AddTicks(7628),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 503, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 311, DateTimeKind.Local).AddTicks(5920),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 501, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 311, DateTimeKind.Local).AddTicks(5607),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 501, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 309, DateTimeKind.Local).AddTicks(9483),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 499, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 309, DateTimeKind.Local).AddTicks(9162),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 499, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 308, DateTimeKind.Local).AddTicks(6871),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 498, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 308, DateTimeKind.Local).AddTicks(6523),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 498, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 307, DateTimeKind.Local).AddTicks(3074),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 496, DateTimeKind.Local).AddTicks(5853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 307, DateTimeKind.Local).AddTicks(2686),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 496, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 321, DateTimeKind.Local).AddTicks(2785),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 511, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 321, DateTimeKind.Local).AddTicks(2390),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 511, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 303, DateTimeKind.Local).AddTicks(316),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 491, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 302, DateTimeKind.Local).AddTicks(9978),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 491, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 293, DateTimeKind.Local).AddTicks(8298),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 481, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 291, DateTimeKind.Local).AddTicks(2997),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 3, 0, 19, 50, 479, DateTimeKind.Local).AddTicks(1907));
        }
    }
}
