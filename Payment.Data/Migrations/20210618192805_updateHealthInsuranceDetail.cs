using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Payment.Data.Migrations
{
    public partial class updateHealthInsuranceDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 901, DateTimeKind.Local).AddTicks(7866),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 347, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 901, DateTimeKind.Local).AddTicks(7510),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 347, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 899, DateTimeKind.Local).AddTicks(4985),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 345, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 899, DateTimeKind.Local).AddTicks(4593),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 345, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 897, DateTimeKind.Local).AddTicks(7800),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 343, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 897, DateTimeKind.Local).AddTicks(7457),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 343, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 896, DateTimeKind.Local).AddTicks(4781),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 342, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 896, DateTimeKind.Local).AddTicks(4320),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 342, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 894, DateTimeKind.Local).AddTicks(9802),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 340, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 894, DateTimeKind.Local).AddTicks(9414),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 340, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.AlterColumn<decimal>(
                name: "vat",
                table: "HealthInsuranceDetail",
                type: "decimal(19,9)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,9)");

            migrationBuilder.AlterColumn<decimal>(
                name: "totalDiscount",
                table: "HealthInsuranceDetail",
                type: "decimal(19,9)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,9)");

            migrationBuilder.AlterColumn<decimal>(
                name: "totalAmount",
                table: "HealthInsuranceDetail",
                type: "decimal(19,9)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,9)");

            migrationBuilder.AlterColumn<decimal>(
                name: "totalAdd",
                table: "HealthInsuranceDetail",
                type: "decimal(19,9)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,9)");

            migrationBuilder.AlterColumn<decimal>(
                name: "fees",
                table: "HealthInsuranceDetail",
                type: "decimal(19,9)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,9)");

            migrationBuilder.AlterColumn<decimal>(
                name: "amount",
                table: "HealthInsuranceDetail",
                type: "decimal(19,9)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,9)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 909, DateTimeKind.Local).AddTicks(5209),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 355, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 909, DateTimeKind.Local).AddTicks(4867),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 355, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 890, DateTimeKind.Local).AddTicks(5726),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 335, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 890, DateTimeKind.Local).AddTicks(5326),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 335, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 880, DateTimeKind.Local).AddTicks(9720),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 326, DateTimeKind.Local).AddTicks(1701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 878, DateTimeKind.Local).AddTicks(3122),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 323, DateTimeKind.Local).AddTicks(3672));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 347, DateTimeKind.Local).AddTicks(5057),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 901, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 347, DateTimeKind.Local).AddTicks(4645),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 901, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 345, DateTimeKind.Local).AddTicks(2154),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 899, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 345, DateTimeKind.Local).AddTicks(1811),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 899, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 343, DateTimeKind.Local).AddTicks(4750),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 897, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 343, DateTimeKind.Local).AddTicks(4398),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 897, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 342, DateTimeKind.Local).AddTicks(1345),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 896, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 342, DateTimeKind.Local).AddTicks(953),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 896, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 340, DateTimeKind.Local).AddTicks(6322),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 894, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 340, DateTimeKind.Local).AddTicks(5986),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 894, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.AlterColumn<decimal>(
                name: "vat",
                table: "HealthInsuranceDetail",
                type: "decimal(19,9)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,9)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "totalDiscount",
                table: "HealthInsuranceDetail",
                type: "decimal(19,9)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,9)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "totalAmount",
                table: "HealthInsuranceDetail",
                type: "decimal(19,9)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,9)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "totalAdd",
                table: "HealthInsuranceDetail",
                type: "decimal(19,9)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,9)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "fees",
                table: "HealthInsuranceDetail",
                type: "decimal(19,9)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,9)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "amount",
                table: "HealthInsuranceDetail",
                type: "decimal(19,9)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,9)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 355, DateTimeKind.Local).AddTicks(463),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 909, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 355, DateTimeKind.Local).AddTicks(45),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 909, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 335, DateTimeKind.Local).AddTicks(8260),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 890, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 335, DateTimeKind.Local).AddTicks(7805),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 890, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 326, DateTimeKind.Local).AddTicks(1701),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 880, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 1, 23, 17, 323, DateTimeKind.Local).AddTicks(3672),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 2, 28, 4, 878, DateTimeKind.Local).AddTicks(3122));
        }
    }
}
