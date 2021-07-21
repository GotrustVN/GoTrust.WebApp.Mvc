using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Payment.Data.Migrations
{
    public partial class updateRescue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Rescue",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 408, DateTimeKind.Local).AddTicks(4561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 640, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Rescue",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "typecode",
                table: "Rescue",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 379, DateTimeKind.Local).AddTicks(7785),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 615, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 379, DateTimeKind.Local).AddTicks(6623),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 615, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 376, DateTimeKind.Local).AddTicks(7206),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 612, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 376, DateTimeKind.Local).AddTicks(6745),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 612, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 374, DateTimeKind.Local).AddTicks(4679),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 609, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 374, DateTimeKind.Local).AddTicks(4236),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 609, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 372, DateTimeKind.Local).AddTicks(4734),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 607, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 372, DateTimeKind.Local).AddTicks(3954),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 607, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 370, DateTimeKind.Local).AddTicks(2181),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 605, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 370, DateTimeKind.Local).AddTicks(1682),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 605, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 394, DateTimeKind.Local).AddTicks(8432),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 626, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 394, DateTimeKind.Local).AddTicks(7933),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 626, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 363, DateTimeKind.Local).AddTicks(6246),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 600, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 363, DateTimeKind.Local).AddTicks(5682),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 600, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 348, DateTimeKind.Local).AddTicks(7447),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 588, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 345, DateTimeKind.Local).AddTicks(3650),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 585, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.CreateIndex(
                name: "IX_Rescue_typecode",
                table: "Rescue",
                column: "typecode");

            migrationBuilder.AddForeignKey(
                name: "FK_Rescue_RescueType_typecode",
                table: "Rescue",
                column: "typecode",
                principalTable: "RescueType",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rescue_RescueType_typecode",
                table: "Rescue");

            migrationBuilder.DropIndex(
                name: "IX_Rescue_typecode",
                table: "Rescue");

            migrationBuilder.DropColumn(
                name: "description",
                table: "Rescue");

            migrationBuilder.DropColumn(
                name: "typecode",
                table: "Rescue");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Rescue",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 640, DateTimeKind.Local).AddTicks(1147),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 408, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 615, DateTimeKind.Local).AddTicks(1930),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 379, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 615, DateTimeKind.Local).AddTicks(1327),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 379, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 612, DateTimeKind.Local).AddTicks(4224),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 376, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 612, DateTimeKind.Local).AddTicks(3738),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 376, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 609, DateTimeKind.Local).AddTicks(4517),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 374, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 609, DateTimeKind.Local).AddTicks(4051),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 374, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 607, DateTimeKind.Local).AddTicks(5198),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 372, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 607, DateTimeKind.Local).AddTicks(4505),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 372, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 605, DateTimeKind.Local).AddTicks(7561),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 370, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 605, DateTimeKind.Local).AddTicks(7092),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 370, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 626, DateTimeKind.Local).AddTicks(8211),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 394, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 626, DateTimeKind.Local).AddTicks(7628),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 394, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 600, DateTimeKind.Local).AddTicks(1127),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 363, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 600, DateTimeKind.Local).AddTicks(604),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 363, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 588, DateTimeKind.Local).AddTicks(233),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 348, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 585, DateTimeKind.Local).AddTicks(2213),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 58, 46, 345, DateTimeKind.Local).AddTicks(3650));
        }
    }
}
