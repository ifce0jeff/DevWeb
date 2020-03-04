using Microsoft.EntityFrameworkCore.Migrations;

namespace B_API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    Preco = table.Column<int>(nullable: false),
                    Categoria = table.Column<int>(nullable: false),
                    Especialidade = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    Sobre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RestauranteId = table.Column<int>(nullable: false),
                    Data = table.Column<string>(nullable: true),
                    Hora = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservas_Restaurantes_RestauranteId",
                        column: x => x.RestauranteId,
                        principalTable: "Restaurantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Restaurantes",
                columns: new[] { "Id", "Categoria", "Endereco", "Especialidade", "Nome", "Preco", "Status" },
                values: new object[] { 1, 2, "McDonald", "Laches", "McDonald", 1, "Aberto" });

            migrationBuilder.InsertData(
                table: "Restaurantes",
                columns: new[] { "Id", "Categoria", "Endereco", "Especialidade", "Nome", "Preco", "Status" },
                values: new object[] { 2, 3, "LaParrilla", "Hamburguer", "LaParrilla", 2, "Fechado" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "Facebook", "Nome", "Senha", "Sobre", "Twitter" },
                values: new object[] { 1, "iesus90@gmail.com", "Iesus Silva", "Iesus", "1234", "Gosto de Comer", "iesus" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "Facebook", "Nome", "Senha", "Sobre", "Twitter" },
                values: new object[] { 2, "Jeff@gmail.com", "Jefferson Nunes", "Jefferson", "4321", "Gosto de conhecer novos lugares", "Jeff" });

            migrationBuilder.InsertData(
                table: "Reservas",
                columns: new[] { "Id", "Data", "Hora", "RestauranteId", "UsuarioId" },
                values: new object[] { 2, "04/03/2020", "13:00", 1, 1 });

            migrationBuilder.InsertData(
                table: "Reservas",
                columns: new[] { "Id", "Data", "Hora", "RestauranteId", "UsuarioId" },
                values: new object[] { 1, "04/03/2020", "19:00", 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_RestauranteId",
                table: "Reservas",
                column: "RestauranteId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_UsuarioId",
                table: "Reservas",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Restaurantes");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
