using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Payment.Data.Migrations
{
    public partial class addProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 787, DateTimeKind.Local).AddTicks(3316),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 779, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 787, DateTimeKind.Local).AddTicks(2842),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 779, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 784, DateTimeKind.Local).AddTicks(7315),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 776, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 784, DateTimeKind.Local).AddTicks(6754),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 776, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 782, DateTimeKind.Local).AddTicks(354),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 774, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 781, DateTimeKind.Local).AddTicks(9709),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 774, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 779, DateTimeKind.Local).AddTicks(5275),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 772, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 779, DateTimeKind.Local).AddTicks(4187),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 772, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 777, DateTimeKind.Local).AddTicks(5694),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 770, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 777, DateTimeKind.Local).AddTicks(5183),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 770, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 797, DateTimeKind.Local).AddTicks(9030),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 790, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 797, DateTimeKind.Local).AddTicks(8446),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 790, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 770, DateTimeKind.Local).AddTicks(8237),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 765, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 770, DateTimeKind.Local).AddTicks(7657),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 765, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 757, DateTimeKind.Local).AddTicks(3423),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 752, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 753, DateTimeKind.Local).AddTicks(8131),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 747, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    vat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.code);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 779, DateTimeKind.Local).AddTicks(2675),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 787, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 779, DateTimeKind.Local).AddTicks(2204),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 787, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 776, DateTimeKind.Local).AddTicks(3005),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 784, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 776, DateTimeKind.Local).AddTicks(2518),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 784, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 774, DateTimeKind.Local).AddTicks(2510),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 782, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 774, DateTimeKind.Local).AddTicks(1993),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 781, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 772, DateTimeKind.Local).AddTicks(6110),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 779, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 772, DateTimeKind.Local).AddTicks(5657),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 779, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 770, DateTimeKind.Local).AddTicks(9093),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 777, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 770, DateTimeKind.Local).AddTicks(8602),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 777, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 790, DateTimeKind.Local).AddTicks(7644),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 797, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 790, DateTimeKind.Local).AddTicks(7153),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 797, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 765, DateTimeKind.Local).AddTicks(4467),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 770, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 765, DateTimeKind.Local).AddTicks(3963),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 770, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 752, DateTimeKind.Local).AddTicks(2395),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 757, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 17, 1, 4, 20, 747, DateTimeKind.Local).AddTicks(1884),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 753, DateTimeKind.Local).AddTicks(8131));
        }
    }
}
