using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GPS.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    abertura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fantasia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    natureza_juridica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    complemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    municipio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    efr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    situacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data_situacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    motivo_situacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    situacao_especial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data_situacao_especial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    capital_social = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "atividade_principais",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_atividade_principais", x => x.id);
                    table.ForeignKey(
                        name: "FK_atividade_principais_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "atividades_secundarias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_atividades_secundarias", x => x.id);
                    table.ForeignKey(
                        name: "FK_atividades_secundarias_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "billing",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    free = table.Column<bool>(type: "bit", nullable: false),
                    database = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billing", x => x.id);
                    table.ForeignKey(
                        name: "FK_billing_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "qsas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    qual = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pais_origem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nome_rep_legal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    qual_rep_legal = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qsas", x => x.id);
                    table.ForeignKey(
                        name: "FK_qsas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_atividade_principais_EmpresaId",
                table: "atividade_principais",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_atividades_secundarias_EmpresaId",
                table: "atividades_secundarias",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_billing_EmpresaId",
                table: "billing",
                column: "EmpresaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_qsas_EmpresaId",
                table: "qsas",
                column: "EmpresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "atividade_principais");

            migrationBuilder.DropTable(
                name: "atividades_secundarias");

            migrationBuilder.DropTable(
                name: "billing");

            migrationBuilder.DropTable(
                name: "qsas");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
