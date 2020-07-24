using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Agency = table.Column<string>(nullable: true),
                    BankAccount = table.Column<string>(nullable: true),
                    BankBalance = table.Column<decimal>(nullable: false),
                    AccountType = table.Column<int>(nullable: false),
                    CardID = table.Column<Guid>(nullable: false),
                    PhisicalPersonID = table.Column<Guid>(nullable: true),
                    LegalPersonID = table.Column<Guid>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoryTransaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    PaymentType = table.Column<int>(maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryTransaction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CardNumber = table.Column<string>(maxLength: 15, nullable: true),
                    Cvv = table.Column<string>(maxLength: 3, nullable: true),
                    ValidateCard = table.Column<string>(maxLength: 5, nullable: true),
                    PrintedNameCard = table.Column<string>(maxLength: 25, nullable: true),
                    Inactive = table.Column<bool>(nullable: false),
                    InactiveDate = table.Column<DateTime>(nullable: false),
                    AccountID = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Card_Account_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LegalPerson",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AccountID = table.Column<Guid>(nullable: false),
                    CompanyName = table.Column<string>(maxLength: 25, nullable: true),
                    CNPJ = table.Column<string>(maxLength: 11, nullable: true),
                    Telephone = table.Column<string>(maxLength: 10, nullable: true),
                    CellPhone = table.Column<string>(maxLength: 11, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    DigitalPassword = table.Column<string>(maxLength: 150, nullable: true),
                    AccountType = table.Column<int>(maxLength: 10, nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Inative = table.Column<bool>(nullable: false),
                    DateInative = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalPerson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LegalPerson_Account_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalPerson",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AccountID = table.Column<Guid>(nullable: false),
                    NickName = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    CPF = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    CellPhone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DigitalPassword = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Inative = table.Column<bool>(nullable: false),
                    DateInative = table.Column<DateTime>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalPerson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhysicalPerson_Account_Id",
                        column: x => x.Id,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerHistoryTransaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LegalPersonID = table.Column<Guid>(nullable: false),
                    HistoryTransactionID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerHistoryTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerHistoryTransaction_HistoryTransaction_HistoryTransac~",
                        column: x => x.HistoryTransactionID,
                        principalTable: "HistoryTransaction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerHistoryTransaction_LegalPerson_LegalPersonID",
                        column: x => x.LegalPersonID,
                        principalTable: "LegalPerson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalPersonHistoryTransaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PhysicalPersonID = table.Column<Guid>(nullable: false),
                    HistoryTransactionID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalPersonHistoryTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhysicalPersonHistoryTransaction_HistoryTransaction_HistoryT~",
                        column: x => x.HistoryTransactionID,
                        principalTable: "HistoryTransaction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhysicalPersonHistoryTransaction_PhysicalPerson_PhysicalPers~",
                        column: x => x.PhysicalPersonID,
                        principalTable: "PhysicalPerson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Card_AccountID",
                table: "Card",
                column: "AccountID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerHistoryTransaction_HistoryTransactionID",
                table: "CustomerHistoryTransaction",
                column: "HistoryTransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerHistoryTransaction_LegalPersonID",
                table: "CustomerHistoryTransaction",
                column: "LegalPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_LegalPerson_AccountID",
                table: "LegalPerson",
                column: "AccountID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalPersonHistoryTransaction_HistoryTransactionID",
                table: "PhysicalPersonHistoryTransaction",
                column: "HistoryTransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalPersonHistoryTransaction_PhysicalPersonID",
                table: "PhysicalPersonHistoryTransaction",
                column: "PhysicalPersonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropTable(
                name: "CustomerHistoryTransaction");

            migrationBuilder.DropTable(
                name: "PhysicalPersonHistoryTransaction");

            migrationBuilder.DropTable(
                name: "LegalPerson");

            migrationBuilder.DropTable(
                name: "HistoryTransaction");

            migrationBuilder.DropTable(
                name: "PhysicalPerson");

            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}
