using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Payment.Data.Migrations
{
    public partial class addFileType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 247, DateTimeKind.Local).AddTicks(8),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 327, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 246, DateTimeKind.Local).AddTicks(9425),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 327, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 243, DateTimeKind.Local).AddTicks(827),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 324, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 243, DateTimeKind.Local).AddTicks(147),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 324, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 240, DateTimeKind.Local).AddTicks(5633),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 323, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 240, DateTimeKind.Local).AddTicks(5232),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 323, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 238, DateTimeKind.Local).AddTicks(8285),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 322, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 238, DateTimeKind.Local).AddTicks(7520),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 322, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 236, DateTimeKind.Local).AddTicks(731),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 320, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 236, DateTimeKind.Local).AddTicks(57),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 320, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 260, DateTimeKind.Local).AddTicks(2200),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 334, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 260, DateTimeKind.Local).AddTicks(1784),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 334, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.AddColumn<string>(
                name: "typecode",
                table: "FileImport",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 229, DateTimeKind.Local).AddTicks(179),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 316, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 228, DateTimeKind.Local).AddTicks(9160),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 316, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 213, DateTimeKind.Local).AddTicks(5534),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 307, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 208, DateTimeKind.Local).AddTicks(9173),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 304, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.CreateTable(
                name: "FileType",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    allowExtension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileType", x => x.code);
                });

            migrationBuilder.InsertData(
                table: "FileType",
                columns: new[] { "code", "allowExtension", "name", "note" },
                values: new object[,]
                {
                    { "CMND", "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*", "Chứng minh nhân dân", null },
                    { "CCCD", "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*", "Căn cước công dân", null },
                    { "HC", "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*", "Hộ chiếu", null },
                    { "GPLX", "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*", "Bằng lái xe", null },
                    { "CI", "Excel|*.xls|Excel 2010|*.xlsx", "Import khách hàng", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FileImport_typecode",
                table: "FileImport",
                column: "typecode");

            migrationBuilder.AddForeignKey(
                name: "FK_FileImport_FileType_typecode",
                table: "FileImport",
                column: "typecode",
                principalTable: "FileType",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileImport_FileType_typecode",
                table: "FileImport");

            migrationBuilder.DropTable(
                name: "FileType");

            migrationBuilder.DropIndex(
                name: "IX_FileImport_typecode",
                table: "FileImport");

            migrationBuilder.DropColumn(
                name: "typecode",
                table: "FileImport");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 327, DateTimeKind.Local).AddTicks(1897),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 247, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 327, DateTimeKind.Local).AddTicks(1491),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 246, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 324, DateTimeKind.Local).AddTicks(9783),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 243, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 324, DateTimeKind.Local).AddTicks(9454),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 243, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 323, DateTimeKind.Local).AddTicks(3161),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 240, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 323, DateTimeKind.Local).AddTicks(2753),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 240, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 322, DateTimeKind.Local).AddTicks(393),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 238, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 322, DateTimeKind.Local).AddTicks(27),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 238, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 320, DateTimeKind.Local).AddTicks(6205),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 236, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "MasterCategory",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 320, DateTimeKind.Local).AddTicks(5810),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 236, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 334, DateTimeKind.Local).AddTicks(8035),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 260, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 334, DateTimeKind.Local).AddTicks(7693),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 260, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 316, DateTimeKind.Local).AddTicks(3546),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 229, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 316, DateTimeKind.Local).AddTicks(3111),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 228, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 307, DateTimeKind.Local).AddTicks(799),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 213, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 19, 4, 16, 3, 304, DateTimeKind.Local).AddTicks(5135),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 20, 23, 45, 25, 208, DateTimeKind.Local).AddTicks(9173));
        }
    }
}
