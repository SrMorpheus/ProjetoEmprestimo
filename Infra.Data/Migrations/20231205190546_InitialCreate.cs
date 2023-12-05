using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeCategoria = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeTipo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoUtilizadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeTipo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUtilizadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeItem = table.Column<string>(type: "text", nullable: false),
                    QuantidadeTotal = table.Column<int>(type: "integer", nullable: false),
                    QuantidadeDisponivel = table.Column<int>(type: "integer", nullable: false),
                    Obervacao = table.Column<string>(type: "text", nullable: false),
                    CategoriaId = table.Column<int>(type: "integer", nullable: false),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Itens_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeUsuario = table.Column<string>(type: "text", nullable: false),
                    Matricula = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    TipoUsuarioId = table.Column<int>(type: "integer", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_TipoUsuarios_TipoUsuarioId",
                        column: x => x.TipoUsuarioId,
                        principalTable: "TipoUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Utilizadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeUltilizador = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false),
                    TipoUtilazdorId = table.Column<int>(type: "integer", nullable: false),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false),
                    TipoUtilizadorId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Utilizadores_TipoUtilizadores_TipoUtilizadorId",
                        column: x => x.TipoUtilizadorId,
                        principalTable: "TipoUtilizadores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Emprestimos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    DataTransacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Quantidade = table.Column<int>(type: "integer", nullable: false),
                    DataDevolucao = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DescricaoEmprestimo = table.Column<string>(type: "text", nullable: false),
                    DescricaoDevolucao = table.Column<string>(type: "text", nullable: false),
                    UsuarioId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprestimos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emprestimos_Itens_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Itens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Emprestimos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Matricula = table.Column<string>(type: "text", nullable: false),
                    LoginUsuario = table.Column<string>(type: "text", nullable: false),
                    Senha = table.Column<string>(type: "text", nullable: false),
                    UsuarioId1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logins_Usuarios_UsuarioId1",
                        column: x => x.UsuarioId1,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UltilizadorEmprestimos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmprestimoId = table.Column<int>(type: "integer", nullable: false),
                    UtilizadorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UltilizadorEmprestimos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UltilizadorEmprestimos_Emprestimos_EmprestimoId",
                        column: x => x.EmprestimoId,
                        principalTable: "Emprestimos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UltilizadorEmprestimos_Utilizadores_UtilizadorId",
                        column: x => x.UtilizadorId,
                        principalTable: "Utilizadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoEmails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UltilazadorEmprestimoId = table.Column<int>(type: "integer", nullable: false),
                    DataEnvio = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    Assunto = table.Column<string>(type: "text", nullable: false),
                    UltilizadorEmprestimoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoEmails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricoEmails_UltilizadorEmprestimos_UltilizadorEmprestim~",
                        column: x => x.UltilizadorEmprestimoId,
                        principalTable: "UltilizadorEmprestimos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimos_ItemId",
                table: "Emprestimos",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimos_UsuarioId",
                table: "Emprestimos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoEmails_UltilizadorEmprestimoId",
                table: "HistoricoEmails",
                column: "UltilizadorEmprestimoId");

            migrationBuilder.CreateIndex(
                name: "IX_Itens_CategoriaId",
                table: "Itens",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_UsuarioId1",
                table: "Logins",
                column: "UsuarioId1");

            migrationBuilder.CreateIndex(
                name: "IX_UltilizadorEmprestimos_EmprestimoId",
                table: "UltilizadorEmprestimos",
                column: "EmprestimoId");

            migrationBuilder.CreateIndex(
                name: "IX_UltilizadorEmprestimos_UtilizadorId",
                table: "UltilizadorEmprestimos",
                column: "UtilizadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TipoUsuarioId",
                table: "Usuarios",
                column: "TipoUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Utilizadores_TipoUtilizadorId",
                table: "Utilizadores",
                column: "TipoUtilizadorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricoEmails");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "UltilizadorEmprestimos");

            migrationBuilder.DropTable(
                name: "Emprestimos");

            migrationBuilder.DropTable(
                name: "Utilizadores");

            migrationBuilder.DropTable(
                name: "Itens");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "TipoUtilizadores");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "TipoUsuarios");
        }
    }
}
