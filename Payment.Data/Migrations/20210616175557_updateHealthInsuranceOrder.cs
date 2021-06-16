using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Payment.Data.Migrations
{
    public partial class updateHealthInsuranceOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 780, DateTimeKind.Local).AddTicks(4386),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 585, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 780, DateTimeKind.Local).AddTicks(3981),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 585, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 777, DateTimeKind.Local).AddTicks(5357),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 582, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 777, DateTimeKind.Local).AddTicks(4950),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 582, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 775, DateTimeKind.Local).AddTicks(7093),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 580, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 775, DateTimeKind.Local).AddTicks(6737),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 580, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 774, DateTimeKind.Local).AddTicks(2754),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 579, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 774, DateTimeKind.Local).AddTicks(2290),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 579, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 788, DateTimeKind.Local).AddTicks(3058),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 592, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 788, DateTimeKind.Local).AddTicks(2720),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 592, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 768, DateTimeKind.Local).AddTicks(6634),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 574, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 768, DateTimeKind.Local).AddTicks(6200),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 574, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.AddColumn<string>(
                name: "nationality",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 758, DateTimeKind.Local).AddTicks(3064),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 568, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 755, DateTimeKind.Local).AddTicks(5451),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 565, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.CreateTable(
                name: "HealthInsurancePayment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paymentType = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    payDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthInsurancePayment", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HealthInsuranceOrder",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    channel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    categorycode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    productCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyerCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    buyerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyerType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyerDateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    buyerGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyerProvince = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyerDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyerWard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyerFullAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyerNationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyerIdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyerIdentityPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyerIdentityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    buyerPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyerFax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyerTaxCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paymentid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthInsuranceOrder", x => x.code);
                    table.ForeignKey(
                        name: "FK_HealthInsuranceOrder_Customer_buyerCode",
                        column: x => x.buyerCode,
                        principalTable: "Customer",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HealthInsuranceOrder_HealthInsurancePayment_paymentid",
                        column: x => x.paymentid,
                        principalTable: "HealthInsurancePayment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HealthInsuranceOrder_MasterCategory_categorycode",
                        column: x => x.categorycode,
                        principalTable: "MasterCategory",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HealthInsuranceDetail",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ordercode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    customerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerDateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    customerGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerProvince = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerWard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerFullAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerNationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerIdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerIdentityPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerIdentityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    customerPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerFax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerTaxCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    productCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    packCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    relationshipcode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    effectiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    expirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fees = table.Column<decimal>(type: "decimal(19,9)", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(19,9)", nullable: false),
                    totalDiscount = table.Column<decimal>(type: "decimal(19,9)", nullable: false),
                    totalAdd = table.Column<decimal>(type: "decimal(19,9)", nullable: false),
                    vat = table.Column<decimal>(type: "decimal(19,9)", nullable: false),
                    totalAmount = table.Column<decimal>(type: "decimal(19,9)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthInsuranceDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_HealthInsuranceDetail_HealthInsuranceOrder_ordercode",
                        column: x => x.ordercode,
                        principalTable: "HealthInsuranceOrder",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HealthInsuranceDetail_MasterCategory_relationshipcode",
                        column: x => x.relationshipcode,
                        principalTable: "MasterCategory",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HealthInsuranceDetail_ordercode",
                table: "HealthInsuranceDetail",
                column: "ordercode");

            migrationBuilder.CreateIndex(
                name: "IX_HealthInsuranceDetail_relationshipcode",
                table: "HealthInsuranceDetail",
                column: "relationshipcode");

            migrationBuilder.CreateIndex(
                name: "IX_HealthInsuranceOrder_buyerCode",
                table: "HealthInsuranceOrder",
                column: "buyerCode");

            migrationBuilder.CreateIndex(
                name: "IX_HealthInsuranceOrder_categorycode",
                table: "HealthInsuranceOrder",
                column: "categorycode");

            migrationBuilder.CreateIndex(
                name: "IX_HealthInsuranceOrder_paymentid",
                table: "HealthInsuranceOrder",
                column: "paymentid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HealthInsuranceDetail");

            migrationBuilder.DropTable(
                name: "HealthInsuranceOrder");

            migrationBuilder.DropTable(
                name: "HealthInsurancePayment");

            migrationBuilder.DropColumn(
                name: "nationality",
                table: "Customer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 585, DateTimeKind.Local).AddTicks(3415),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 780, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "PaymentLog",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 585, DateTimeKind.Local).AddTicks(2971),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 780, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 582, DateTimeKind.Local).AddTicks(4017),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 777, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 582, DateTimeKind.Local).AddTicks(3662),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 777, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 580, DateTimeKind.Local).AddTicks(5449),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 775, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderStatus",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 580, DateTimeKind.Local).AddTicks(5086),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 775, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 579, DateTimeKind.Local).AddTicks(1433),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 774, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "OrderInfor",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 579, DateTimeKind.Local).AddTicks(1034),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 774, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 592, DateTimeKind.Local).AddTicks(5296),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 788, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "FileImport",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 592, DateTimeKind.Local).AddTicks(4918),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 788, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 574, DateTimeKind.Local).AddTicks(5140),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 768, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "CustomerType",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 574, DateTimeKind.Local).AddTicks(4721),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 768, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastUpdatedAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 568, DateTimeKind.Local).AddTicks(9384),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 758, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Bank",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 15, 22, 44, 43, 565, DateTimeKind.Local).AddTicks(7031),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 6, 17, 0, 55, 56, 755, DateTimeKind.Local).AddTicks(5451));
        }
    }
}
