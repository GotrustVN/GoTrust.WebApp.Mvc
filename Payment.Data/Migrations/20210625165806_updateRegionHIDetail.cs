using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Payment.Data.Migrations
{
    public partial class updateRegionHIDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 65, DateTimeKind.Local).AddTicks(1669),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 636, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 65, DateTimeKind.Local).AddTicks(1077),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 636, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 61, DateTimeKind.Local).AddTicks(3235),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 632, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 61, DateTimeKind.Local).AddTicks(2622),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 632, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 58, DateTimeKind.Local).AddTicks(1979),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 629, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 58, DateTimeKind.Local).AddTicks(1577),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 629, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 56, DateTimeKind.Local).AddTicks(6013),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 627, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 56, DateTimeKind.Local).AddTicks(5444),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 627, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 54, DateTimeKind.Local).AddTicks(7454),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 625, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 54, DateTimeKind.Local).AddTicks(6910),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 625, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.AddColumn<string>(
                name: "region",
                table: "HealthInsuranceDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 80, DateTimeKind.Local).AddTicks(1310),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 647, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 80, DateTimeKind.Local).AddTicks(201),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 647, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 47, DateTimeKind.Local).AddTicks(3797),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 618, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 47, DateTimeKind.Local).AddTicks(3037),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 618, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 29, DateTimeKind.Local).AddTicks(130),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 602, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 23, DateTimeKind.Local).AddTicks(9319),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 599, DateTimeKind.Local).AddTicks(936));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "region",
                table: "HealthInsuranceDetail");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 636, DateTimeKind.Local).AddTicks(7717),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 65, DateTimeKind.Local).AddTicks(1669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 636, DateTimeKind.Local).AddTicks(7075),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 65, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 632, DateTimeKind.Local).AddTicks(4145),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 61, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 632, DateTimeKind.Local).AddTicks(2931),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 61, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 629, DateTimeKind.Local).AddTicks(4032),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 58, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 629, DateTimeKind.Local).AddTicks(3076),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 58, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 627, DateTimeKind.Local).AddTicks(6611),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 56, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 627, DateTimeKind.Local).AddTicks(6138),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 56, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 625, DateTimeKind.Local).AddTicks(1232),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 54, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 625, DateTimeKind.Local).AddTicks(746),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 54, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 647, DateTimeKind.Local).AddTicks(2934),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 80, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 647, DateTimeKind.Local).AddTicks(2027),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 80, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 618, DateTimeKind.Local).AddTicks(6400),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 47, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 618, DateTimeKind.Local).AddTicks(5980),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 47, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 602, DateTimeKind.Local).AddTicks(2624),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 29, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 25, 23, 49, 49, 599, DateTimeKind.Local).AddTicks(936),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 25, 23, 58, 6, 23, DateTimeKind.Local).AddTicks(9319));
        }
    }
}
