using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Payment.Data.Migrations
{
    public partial class addCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 585, DateTimeKind.Local).AddTicks(3415),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 13, 4, 14, 55, 744, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 585, DateTimeKind.Local).AddTicks(2971),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 13, 4, 14, 55, 744, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 582, DateTimeKind.Local).AddTicks(4017),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 13, 4, 14, 55, 740, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 582, DateTimeKind.Local).AddTicks(3662),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 13, 4, 14, 55, 740, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 580, DateTimeKind.Local).AddTicks(5449),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 13, 4, 14, 55, 737, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 580, DateTimeKind.Local).AddTicks(5086),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 13, 4, 14, 55, 737, DateTimeKind.Local).AddTicks(948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 579, DateTimeKind.Local).AddTicks(1433),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 13, 4, 14, 55, 734, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 579, DateTimeKind.Local).AddTicks(1034),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 13, 4, 14, 55, 734, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 568, DateTimeKind.Local).AddTicks(9384),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 13, 4, 14, 55, 723, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 565, DateTimeKind.Local).AddTicks(7031),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 13, 4, 14, 55, 720, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.CreateTable(
                name: "CustomerType",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    createdByusername = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 574, DateTimeKind.Local).AddTicks(4721)),
                    lastUpdatedByusername = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    lastUpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 574, DateTimeKind.Local).AddTicks(5140))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerType", x => x.code);
                    table.ForeignKey(
                        name: "FK_CustomerType_User_createdByusername",
                        column: x => x.createdByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerType_User_lastUpdatedByusername",
                        column: x => x.lastUpdatedByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FileImport",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    fileName = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    savePath = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    createdByusername = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 592, DateTimeKind.Local).AddTicks(4918)),
                    lastUpdatedByusername = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    lastUpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 592, DateTimeKind.Local).AddTicks(5296))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileImport", x => x.code);
                    table.ForeignKey(
                        name: "FK_FileImport_User_createdByusername",
                        column: x => x.createdByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FileImport_User_lastUpdatedByusername",
                        column: x => x.lastUpdatedByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "MasterCategory",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    group = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    createdByusername = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lastUpdatedByusername = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    lastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterCategory", x => x.code);
                    table.ForeignKey(
                        name: "FK_MasterCategory_User_createdByusername",
                        column: x => x.createdByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MasterCategory_User_lastUpdatedByusername",
                        column: x => x.lastUpdatedByusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    provincecode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.code);
                    table.ForeignKey(
                        name: "FK_District_Province_provincecode",
                        column: x => x.provincecode,
                        principalTable: "Province",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ward",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    districtcode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ward", x => x.code);
                    table.ForeignKey(
                        name: "FK_Ward_District_districtcode",
                        column: x => x.districtcode,
                        principalTable: "District",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    typecode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    dateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gendercode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    provincecode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    districtcode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    wardcode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    fullAddress = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    identityNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    identityPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    identityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    fax = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    taxCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.code);
                    table.ForeignKey(
                        name: "FK_Customer_CustomerType_typecode",
                        column: x => x.typecode,
                        principalTable: "CustomerType",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_District_districtcode",
                        column: x => x.districtcode,
                        principalTable: "District",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Gender_gendercode",
                        column: x => x.gendercode,
                        principalTable: "Gender",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Province_provincecode",
                        column: x => x.provincecode,
                        principalTable: "Province",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Ward_wardcode",
                        column: x => x.wardcode,
                        principalTable: "Ward",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CustomerType",
                columns: new[] { "code", "createdByusername", "lastUpdatedByusername", "name" },
                values: new object[,]
                {
                    { "CN", null, null, "Cá nhân" },
                    { "CQ", null, null, "Cơ quan" },
                    { "DN", null, null, "Doanh nghiệp" }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "code", "name" },
                values: new object[,]
                {
                    { "M", "Nam" },
                    { "F", "Nữ" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_districtcode",
                table: "Customer",
                column: "districtcode");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_gendercode",
                table: "Customer",
                column: "gendercode");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_provincecode",
                table: "Customer",
                column: "provincecode");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_typecode",
                table: "Customer",
                column: "typecode");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_wardcode",
                table: "Customer",
                column: "wardcode");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerType_createdByusername",
                table: "CustomerType",
                column: "createdByusername");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerType_lastUpdatedByusername",
                table: "CustomerType",
                column: "lastUpdatedByusername");

            migrationBuilder.CreateIndex(
                name: "IX_District_provincecode",
                table: "District",
                column: "provincecode");

            migrationBuilder.CreateIndex(
                name: "IX_FileImport_createdByusername",
                table: "FileImport",
                column: "createdByusername");

            migrationBuilder.CreateIndex(
                name: "IX_FileImport_lastUpdatedByusername",
                table: "FileImport",
                column: "lastUpdatedByusername");

            migrationBuilder.CreateIndex(
                name: "IX_MasterCategory_createdByusername",
                table: "MasterCategory",
                column: "createdByusername");

            migrationBuilder.CreateIndex(
                name: "IX_MasterCategory_lastUpdatedByusername",
                table: "MasterCategory",
                column: "lastUpdatedByusername");

            migrationBuilder.CreateIndex(
                name: "IX_Ward_districtcode",
                table: "Ward",
                column: "districtcode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "FileImport");

            migrationBuilder.DropTable(
                name: "MasterCategory");

            migrationBuilder.DropTable(
                name: "CustomerType");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Ward");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 13, 4, 14, 55, 744, DateTimeKind.Local).AddTicks(6526),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 585, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 13, 4, 14, 55, 744, DateTimeKind.Local).AddTicks(5986),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 585, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 13, 4, 14, 55, 740, DateTimeKind.Local).AddTicks(3941),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 582, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 13, 4, 14, 55, 740, DateTimeKind.Local).AddTicks(3399),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 582, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 13, 4, 14, 55, 737, DateTimeKind.Local).AddTicks(1717),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 580, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 13, 4, 14, 55, 737, DateTimeKind.Local).AddTicks(948),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 580, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 13, 4, 14, 55, 734, DateTimeKind.Local).AddTicks(3600),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 579, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 13, 4, 14, 55, 734, DateTimeKind.Local).AddTicks(2849),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 579, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 13, 4, 14, 55, 723, DateTimeKind.Local).AddTicks(4738),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 568, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 13, 4, 14, 55, 720, DateTimeKind.Local).AddTicks(8579),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 565, DateTimeKind.Local).AddTicks(7031));
        }
    }
}
