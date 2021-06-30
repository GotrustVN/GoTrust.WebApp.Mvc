using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Payment.Data.Migrations
{
    public partial class addColumnForHI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 313, DateTimeKind.Local).AddTicks(8180),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 31, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 313, DateTimeKind.Local).AddTicks(7628),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 31, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 311, DateTimeKind.Local).AddTicks(5920),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 27, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 311, DateTimeKind.Local).AddTicks(5607),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 27, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 309, DateTimeKind.Local).AddTicks(9483),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 24, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 309, DateTimeKind.Local).AddTicks(9162),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 24, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 308, DateTimeKind.Local).AddTicks(6871),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 22, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 308, DateTimeKind.Local).AddTicks(6523),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 22, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 307, DateTimeKind.Local).AddTicks(3074),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 20, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 307, DateTimeKind.Local).AddTicks(2686),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 20, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.AddColumn<decimal>(
                name: "amount",
                table: "HealthInsuranceOrder",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "contractCode",
                table: "HealthInsuranceOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "contractModel",
                table: "HealthInsuranceOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "contractNo",
                table: "HealthInsuranceOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "orderCode",
                table: "HealthInsuranceOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "HealthInsuranceOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "statusName",
                table: "HealthInsuranceOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "totalAmount",
                table: "HealthInsuranceOrder",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "totalDiscount",
                table: "HealthInsuranceOrder",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "vat",
                table: "HealthInsuranceOrder",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "certificateNo",
                table: "HealthInsuranceDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "contractCode",
                table: "HealthInsuranceDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "detailCode",
                table: "HealthInsuranceDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "urlGCN",
                table: "HealthInsuranceDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 321, DateTimeKind.Local).AddTicks(2785),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 39, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 321, DateTimeKind.Local).AddTicks(2390),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 39, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 303, DateTimeKind.Local).AddTicks(316),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 16, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 302, DateTimeKind.Local).AddTicks(9978),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 16, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 293, DateTimeKind.Local).AddTicks(8298),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 5, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 291, DateTimeKind.Local).AddTicks(2997),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 2, DateTimeKind.Local).AddTicks(7780));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "amount",
                table: "HealthInsuranceOrder");

            migrationBuilder.DropColumn(
                name: "contractCode",
                table: "HealthInsuranceOrder");

            migrationBuilder.DropColumn(
                name: "contractModel",
                table: "HealthInsuranceOrder");

            migrationBuilder.DropColumn(
                name: "contractNo",
                table: "HealthInsuranceOrder");

            migrationBuilder.DropColumn(
                name: "orderCode",
                table: "HealthInsuranceOrder");

            migrationBuilder.DropColumn(
                name: "status",
                table: "HealthInsuranceOrder");

            migrationBuilder.DropColumn(
                name: "statusName",
                table: "HealthInsuranceOrder");

            migrationBuilder.DropColumn(
                name: "totalAmount",
                table: "HealthInsuranceOrder");

            migrationBuilder.DropColumn(
                name: "totalDiscount",
                table: "HealthInsuranceOrder");

            migrationBuilder.DropColumn(
                name: "vat",
                table: "HealthInsuranceOrder");

            migrationBuilder.DropColumn(
                name: "certificateNo",
                table: "HealthInsuranceDetail");

            migrationBuilder.DropColumn(
                name: "contractCode",
                table: "HealthInsuranceDetail");

            migrationBuilder.DropColumn(
                name: "detailCode",
                table: "HealthInsuranceDetail");

            migrationBuilder.DropColumn(
                name: "urlGCN",
                table: "HealthInsuranceDetail");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 31, DateTimeKind.Local).AddTicks(761),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 313, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 31, DateTimeKind.Local).AddTicks(184),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 313, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 27, DateTimeKind.Local).AddTicks(5377),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 311, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 27, DateTimeKind.Local).AddTicks(4730),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 311, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 24, DateTimeKind.Local).AddTicks(4310),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 309, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 24, DateTimeKind.Local).AddTicks(3829),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 309, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 22, DateTimeKind.Local).AddTicks(5321),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 308, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 22, DateTimeKind.Local).AddTicks(4816),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 308, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 20, DateTimeKind.Local).AddTicks(9492),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 307, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 20, DateTimeKind.Local).AddTicks(9116),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 307, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 39, DateTimeKind.Local).AddTicks(4210),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 321, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 39, DateTimeKind.Local).AddTicks(3731),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 321, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 16, DateTimeKind.Local).AddTicks(2890),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 303, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 16, DateTimeKind.Local).AddTicks(2469),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 302, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 5, DateTimeKind.Local).AddTicks(6483),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 293, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 30, 2, 24, 7, 2, DateTimeKind.Local).AddTicks(7780),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 30, 2, 51, 42, 291, DateTimeKind.Local).AddTicks(2997));
        }
    }
}
