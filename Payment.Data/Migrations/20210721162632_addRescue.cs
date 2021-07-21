using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Payment.Data.Migrations
{
    public partial class addRescue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "code",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 615, DateTimeKind.Local).AddTicks(1930),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 787, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 615, DateTimeKind.Local).AddTicks(1327),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 787, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 612, DateTimeKind.Local).AddTicks(4224),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 784, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 612, DateTimeKind.Local).AddTicks(3738),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 784, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 609, DateTimeKind.Local).AddTicks(4517),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 782, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 609, DateTimeKind.Local).AddTicks(4051),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 781, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 607, DateTimeKind.Local).AddTicks(5198),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 779, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 607, DateTimeKind.Local).AddTicks(4505),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 779, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 605, DateTimeKind.Local).AddTicks(7561),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 777, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 605, DateTimeKind.Local).AddTicks(7092),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 777, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 626, DateTimeKind.Local).AddTicks(8211),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 797, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 626, DateTimeKind.Local).AddTicks(7628),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 797, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 600, DateTimeKind.Local).AddTicks(1127),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 770, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 600, DateTimeKind.Local).AddTicks(604),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 770, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 588, DateTimeKind.Local).AddTicks(233),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 757, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 585, DateTimeKind.Local).AddTicks(2213),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 753, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Rescue",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    lat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    lon = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 640, DateTimeKind.Local).AddTicks(1147))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rescue", x => x.id);
                    table.ForeignKey(
                        name: "FK_Rescue_User_username",
                        column: x => x.username,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RescueType",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RescueType", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "RescueThumbnail",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rescueid = table.Column<int>(type: "int", nullable: true),
                    refUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RescueThumbnail", x => x.id);
                    table.ForeignKey(
                        name: "FK_RescueThumbnail_Rescue_rescueid",
                        column: x => x.rescueid,
                        principalTable: "Rescue",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "RescueType",
                columns: new[] { "code", "name" },
                values: new object[,]
                {
                    { "Fuel", "Tiếp nhiên liệu" },
                    { "Key", "Sửa khóa" },
                    { "Repair", "Sửa chữa" },
                    { "Rescue", "Trường hợp cứu hộ khác" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rescue_username",
                table: "Rescue",
                column: "username");

            migrationBuilder.CreateIndex(
                name: "IX_RescueThumbnail_rescueid",
                table: "RescueThumbnail",
                column: "rescueid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RescueThumbnail");

            migrationBuilder.DropTable(
                name: "RescueType");

            migrationBuilder.DropTable(
                name: "Rescue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "code",
                table: "Product",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 787, DateTimeKind.Local).AddTicks(3316),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 615, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 787, DateTimeKind.Local).AddTicks(2842),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 615, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 784, DateTimeKind.Local).AddTicks(7315),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 612, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 784, DateTimeKind.Local).AddTicks(6754),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 612, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 782, DateTimeKind.Local).AddTicks(354),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 609, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 781, DateTimeKind.Local).AddTicks(9709),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 609, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 779, DateTimeKind.Local).AddTicks(5275),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 607, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 779, DateTimeKind.Local).AddTicks(4187),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 607, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 777, DateTimeKind.Local).AddTicks(5694),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 605, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 777, DateTimeKind.Local).AddTicks(5183),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 605, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 797, DateTimeKind.Local).AddTicks(9030),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 626, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 797, DateTimeKind.Local).AddTicks(8446),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 626, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 770, DateTimeKind.Local).AddTicks(8237),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 600, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 770, DateTimeKind.Local).AddTicks(7657),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 600, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 757, DateTimeKind.Local).AddTicks(3423),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 588, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 21, 20, 40, 0, 753, DateTimeKind.Local).AddTicks(8131),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 7, 21, 23, 26, 31, 585, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "code");
        }
    }
}
