using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class myFirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livreurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livreurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateMenu = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plats",
                columns: table => new
                {
                    IdPlat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TypePlat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoPlat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prix = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plats", x => x.IdPlat);
                });

            migrationBuilder.CreateTable(
                name: "Commandes",
                columns: table => new
                {
                    NumCmd = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateCommande = table.Column<DateTime>(name: "Date Commande", type: "datetime2", nullable: false),
                    Livree = table.Column<bool>(type: "bit", nullable: false),
                    LivreurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commandes", x => x.NumCmd);
                    table.ForeignKey(
                        name: "FK_Commandes_Livreurs_LivreurId",
                        column: x => x.LivreurId,
                        principalTable: "Livreurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuPlat",
                columns: table => new
                {
                    MenusId = table.Column<int>(type: "int", nullable: false),
                    PlatsIdPlat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuPlat", x => new { x.MenusId, x.PlatsIdPlat });
                    table.ForeignKey(
                        name: "FK_MenuPlat_Menus_MenusId",
                        column: x => x.MenusId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuPlat_Plats_PlatsIdPlat",
                        column: x => x.PlatsIdPlat,
                        principalTable: "Plats",
                        principalColumn: "IdPlat",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommandePlat",
                columns: table => new
                {
                    CommandesNumCmd = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PlatsIdPlat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandePlat", x => new { x.CommandesNumCmd, x.PlatsIdPlat });
                    table.ForeignKey(
                        name: "FK_CommandePlat_Commandes_CommandesNumCmd",
                        column: x => x.CommandesNumCmd,
                        principalTable: "Commandes",
                        principalColumn: "NumCmd",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommandePlat_Plats_PlatsIdPlat",
                        column: x => x.PlatsIdPlat,
                        principalTable: "Plats",
                        principalColumn: "IdPlat",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LigneCommande",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantite = table.Column<int>(type: "int", nullable: false),
                    PlatId = table.Column<int>(type: "int", nullable: false),
                    NumCmd = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LigneCommande", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LigneCommande_Commandes_NumCmd",
                        column: x => x.NumCmd,
                        principalTable: "Commandes",
                        principalColumn: "NumCmd",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LigneCommande_Plats_PlatId",
                        column: x => x.PlatId,
                        principalTable: "Plats",
                        principalColumn: "IdPlat",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommandePlat_PlatsIdPlat",
                table: "CommandePlat",
                column: "PlatsIdPlat");

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_LivreurId",
                table: "Commandes",
                column: "LivreurId");

            migrationBuilder.CreateIndex(
                name: "IX_LigneCommande_NumCmd",
                table: "LigneCommande",
                column: "NumCmd");

            migrationBuilder.CreateIndex(
                name: "IX_LigneCommande_PlatId",
                table: "LigneCommande",
                column: "PlatId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuPlat_PlatsIdPlat",
                table: "MenuPlat",
                column: "PlatsIdPlat");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommandePlat");

            migrationBuilder.DropTable(
                name: "LigneCommande");

            migrationBuilder.DropTable(
                name: "MenuPlat");

            migrationBuilder.DropTable(
                name: "Commandes");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Plats");

            migrationBuilder.DropTable(
                name: "Livreurs");
        }
    }
}
