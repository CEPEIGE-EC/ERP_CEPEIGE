using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivosFijos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    TipoActivo = table.Column<int>(type: "integer", nullable: false),
                    Marca = table.Column<string>(type: "text", nullable: true),
                    Modelo = table.Column<string>(type: "text", nullable: true),
                    NumeroSerie = table.Column<string>(type: "text", nullable: true),
                    ValorAdquisicion = table.Column<decimal>(type: "numeric", nullable: false),
                    FechaAdquisicion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    UbicacionActual = table.Column<string>(type: "text", nullable: true),
                    AsignadoA = table.Column<string>(type: "text", nullable: true),
                    Observaciones = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivosFijos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aulas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Capacidad = table.Column<int>(type: "integer", nullable: false),
                    Ubicacion = table.Column<string>(type: "text", nullable: true),
                    TipoAmbiente = table.Column<string>(type: "text", nullable: true),
                    TieneProyector = table.Column<bool>(type: "boolean", nullable: false),
                    TieneInternet = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aulas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comunicados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    Contenido = table.Column<string>(type: "text", nullable: false),
                    TipoDestinatario = table.Column<string>(type: "text", nullable: true),
                    FechaPublicacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaExpiracion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Destacado = table.Column<bool>(type: "boolean", nullable: false),
                    AutorId = table.Column<string>(type: "text", nullable: true),
                    ArchivoAdjunto = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comunicados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConceptosPago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    MontoBase = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    AplicaMora = table.Column<bool>(type: "boolean", nullable: false),
                    PorcentajeMora = table.Column<decimal>(type: "numeric", nullable: true),
                    DiasGraciaMora = table.Column<int>(type: "integer", nullable: true),
                    EsRecurrente = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConceptosPago", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Creditos = table.Column<int>(type: "integer", nullable: false),
                    HorasTeoricas = table.Column<int>(type: "integer", nullable: false),
                    HorasPracticas = table.Column<int>(type: "integer", nullable: false),
                    HorasLaboratorio = table.Column<int>(type: "integer", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Syllabus = table.Column<string>(type: "text", nullable: true),
                    EsElectivo = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Descuentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    PorcentajeDescuento = table.Column<decimal>(type: "numeric", nullable: true),
                    MontoFijo = table.Column<decimal>(type: "numeric", nullable: true),
                    EsBeca = table.Column<bool>(type: "boolean", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    FechaFin = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descuentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Docentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Nombres = table.Column<string>(type: "text", nullable: false),
                    ApellidoPaterno = table.Column<string>(type: "text", nullable: false),
                    ApellidoMaterno = table.Column<string>(type: "text", nullable: false),
                    DNI = table.Column<string>(type: "text", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Sexo = table.Column<int>(type: "integer", nullable: false),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    Telefono = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: false),
                    FotoPerfil = table.Column<string>(type: "text", nullable: true),
                    Estado = table.Column<int>(type: "integer", nullable: false),
                    TipoContrato = table.Column<int>(type: "integer", nullable: false),
                    GradoAcademico = table.Column<string>(type: "text", nullable: true),
                    Especialidad = table.Column<string>(type: "text", nullable: true),
                    ColegiaturaN = table.Column<string>(type: "text", nullable: true),
                    FechaIngreso = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Sueldo = table.Column<decimal>(type: "numeric", nullable: true),
                    HorasMaximas = table.Column<int>(type: "integer", nullable: true),
                    UsuarioId = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Nombres = table.Column<string>(type: "text", nullable: false),
                    ApellidoPaterno = table.Column<string>(type: "text", nullable: false),
                    ApellidoMaterno = table.Column<string>(type: "text", nullable: false),
                    DNI = table.Column<string>(type: "text", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Sexo = table.Column<int>(type: "integer", nullable: false),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    Telefono = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    FotoPerfil = table.Column<string>(type: "text", nullable: true),
                    Estado = table.Column<int>(type: "integer", nullable: false),
                    Nacionalidad = table.Column<string>(type: "text", nullable: true),
                    LugarNacimiento = table.Column<string>(type: "text", nullable: true),
                    GrupoSanguineo = table.Column<string>(type: "text", nullable: true),
                    Alergias = table.Column<string>(type: "text", nullable: true),
                    Discapacidad = table.Column<string>(type: "text", nullable: true),
                    UsuarioId = table.Column<string>(type: "text", nullable: true),
                    NombreApoderado = table.Column<string>(type: "text", nullable: true),
                    DNIApoderado = table.Column<string>(type: "text", nullable: true),
                    TelefonoApoderado = table.Column<string>(type: "text", nullable: true),
                    EmailApoderado = table.Column<string>(type: "text", nullable: true),
                    ParentescoApoderado = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Facultades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Decano = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facultades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instituciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    NombreCorto = table.Column<string>(type: "text", nullable: true),
                    RUC = table.Column<string>(type: "text", nullable: true),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    Telefono = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    SitioWeb = table.Column<string>(type: "text", nullable: true),
                    Logo = table.Column<string>(type: "text", nullable: true),
                    Slogan = table.Column<string>(type: "text", nullable: true),
                    Departamento = table.Column<string>(type: "text", nullable: true),
                    Provincia = table.Column<string>(type: "text", nullable: true),
                    Distrito = table.Column<string>(type: "text", nullable: true),
                    Pais = table.Column<string>(type: "text", nullable: true),
                    Moneda = table.Column<string>(type: "text", nullable: true),
                    SimboloMoneda = table.Column<string>(type: "text", nullable: true),
                    ColorPrimario = table.Column<string>(type: "text", nullable: true),
                    ColorSecundario = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ISBN = table.Column<string>(type: "text", nullable: false),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    Autor = table.Column<string>(type: "text", nullable: false),
                    Editorial = table.Column<string>(type: "text", nullable: true),
                    AnioPublicacion = table.Column<int>(type: "integer", nullable: true),
                    Edicion = table.Column<string>(type: "text", nullable: true),
                    Idioma = table.Column<string>(type: "text", nullable: true),
                    Categoria = table.Column<string>(type: "text", nullable: true),
                    SubCategoria = table.Column<string>(type: "text", nullable: true),
                    Ubicacion = table.Column<string>(type: "text", nullable: true),
                    PortadaUrl = table.Column<string>(type: "text", nullable: true),
                    Resumen = table.Column<string>(type: "text", nullable: true),
                    TotalEjemplares = table.Column<int>(type: "integer", nullable: false),
                    EjemplaresDisponibles = table.Column<int>(type: "integer", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UsuarioId = table.Column<string>(type: "text", nullable: false),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    Mensaje = table.Column<string>(type: "text", nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: true),
                    Enlace = table.Column<string>(type: "text", nullable: true),
                    Leida = table.Column<bool>(type: "boolean", nullable: false),
                    FechaEnvio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parametros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Clave = table.Column<string>(type: "text", nullable: false),
                    Valor = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Grupo = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PeriodosAcademicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EsActual = table.Column<bool>(type: "boolean", nullable: false),
                    AnioAcademico = table.Column<int>(type: "integer", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodosAcademicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalAdministrativo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Nombres = table.Column<string>(type: "text", nullable: false),
                    ApellidoPaterno = table.Column<string>(type: "text", nullable: false),
                    ApellidoMaterno = table.Column<string>(type: "text", nullable: false),
                    DNI = table.Column<string>(type: "text", nullable: false),
                    Sexo = table.Column<int>(type: "integer", nullable: false),
                    Cargo = table.Column<string>(type: "text", nullable: true),
                    Area = table.Column<string>(type: "text", nullable: true),
                    TipoPersonal = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Telefono = table.Column<string>(type: "text", nullable: true),
                    Sueldo = table.Column<decimal>(type: "numeric", nullable: true),
                    FechaIngreso = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UsuarioId = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalAdministrativo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Turnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    HoraInicio = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    HoraFin = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turnos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Nombres = table.Column<string>(type: "text", nullable: false),
                    Apellidos = table.Column<string>(type: "text", nullable: false),
                    FotoPerfil = table.Column<string>(type: "text", nullable: true),
                    CambiarPassword = table.Column<bool>(type: "boolean", nullable: false),
                    UltimoAcceso = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Bloqueado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RolPrincipal = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tarifarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CarreraId = table.Column<int>(type: "integer", nullable: false),
                    ConceptoPagoId = table.Column<int>(type: "integer", nullable: false),
                    PeriodoAcademicoId = table.Column<int>(type: "integer", nullable: false),
                    Monto = table.Column<decimal>(type: "numeric", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarifarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarifarios_ConceptosPago_ConceptoPagoId",
                        column: x => x.ConceptoPagoId,
                        principalTable: "ConceptosPago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DescuentosEstudiante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DescuentoId = table.Column<int>(type: "integer", nullable: false),
                    EstudianteId = table.Column<int>(type: "integer", nullable: false),
                    PeriodoAcademicoId = table.Column<int>(type: "integer", nullable: false),
                    Aprobado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescuentosEstudiante", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DescuentosEstudiante_Descuentos_DescuentoId",
                        column: x => x.DescuentoId,
                        principalTable: "Descuentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DescuentosEstudiante_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deudas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NumeroDeuda = table.Column<string>(type: "text", nullable: false),
                    EstudianteId = table.Column<int>(type: "integer", nullable: false),
                    ConceptoPagoId = table.Column<int>(type: "integer", nullable: false),
                    PeriodoAcademicoId = table.Column<int>(type: "integer", nullable: false),
                    MontoOriginal = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    MontoMora = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    MontoDescuento = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Estado = table.Column<int>(type: "integer", nullable: false),
                    Cuota = table.Column<int>(type: "integer", nullable: true),
                    TotalCuotas = table.Column<int>(type: "integer", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deudas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deudas_ConceptosPago_ConceptoPagoId",
                        column: x => x.ConceptoPagoId,
                        principalTable: "ConceptosPago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deudas_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    TipoDocumento = table.Column<string>(type: "text", nullable: true),
                    RutaArchivo = table.Column<string>(type: "text", nullable: false),
                    EstudianteId = table.Column<int>(type: "integer", nullable: true),
                    DocenteId = table.Column<int>(type: "integer", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documentos_Docentes_DocenteId",
                        column: x => x.DocenteId,
                        principalTable: "Docentes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Documentos_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SolicitudesDocumento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NumeroSolicitud = table.Column<string>(type: "text", nullable: false),
                    EstudianteId = table.Column<int>(type: "integer", nullable: false),
                    TipoDocumento = table.Column<string>(type: "text", nullable: false),
                    Motivo = table.Column<string>(type: "text", nullable: true),
                    Estado = table.Column<int>(type: "integer", nullable: false),
                    FechaSolicitud = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaEntrega = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CostoDerecho = table.Column<decimal>(type: "numeric", nullable: false),
                    Pagado = table.Column<bool>(type: "boolean", nullable: false),
                    RutaDocumentoGenerado = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudesDocumento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitudesDocumento_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tesis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EstudianteId = table.Column<int>(type: "integer", nullable: false),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    Resumen = table.Column<string>(type: "text", nullable: true),
                    AsesorId = table.Column<string>(type: "text", nullable: true),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    FechaSustentacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    NotaSustentacion = table.Column<decimal>(type: "numeric", nullable: true),
                    RutaDocumento = table.Column<string>(type: "text", nullable: true),
                    Observaciones = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tesis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tesis_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FacultadId = table.Column<int>(type: "integer", nullable: false),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    NivelEducativo = table.Column<int>(type: "integer", nullable: false),
                    Modalidad = table.Column<int>(type: "integer", nullable: false),
                    DuracionSemestres = table.Column<int>(type: "integer", nullable: false),
                    TotalCreditos = table.Column<int>(type: "integer", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    DirectorId = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carreras_Facultades_FacultadId",
                        column: x => x.FacultadId,
                        principalTable: "Facultades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LibroId = table.Column<int>(type: "integer", nullable: false),
                    EstudianteId = table.Column<int>(type: "integer", nullable: false),
                    FechaPrestamo = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaDevolucionEsperada = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaDevolucionReal = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Estado = table.Column<int>(type: "integer", nullable: false),
                    MultaGenerada = table.Column<decimal>(type: "numeric", nullable: true),
                    MultaPagada = table.Column<bool>(type: "boolean", nullable: false),
                    Observaciones = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prestamos_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestamos_Libros_LibroId",
                        column: x => x.LibroId,
                        principalTable: "Libros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CiclosAcademicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PeriodoAcademicoId = table.Column<int>(type: "integer", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    OrdenNumero = table.Column<int>(type: "integer", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiclosAcademicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiclosAcademicos_PeriodosAcademicos_PeriodoAcademicoId",
                        column: x => x.PeriodoAcademicoId,
                        principalTable: "PeriodosAcademicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Secciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CursoId = table.Column<int>(type: "integer", nullable: false),
                    PeriodoAcademicoId = table.Column<int>(type: "integer", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Capacidad = table.Column<int>(type: "integer", nullable: false),
                    AulaId = table.Column<int>(type: "integer", nullable: true),
                    TurnoId = table.Column<int>(type: "integer", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Secciones_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Secciones_PeriodosAcademicos_PeriodoAcademicoId",
                        column: x => x.PeriodoAcademicoId,
                        principalTable: "PeriodosAcademicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioClaims_Usuarios_UserId",
                        column: x => x.UserId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UsuarioLogins_Usuarios_UserId",
                        column: x => x.UserId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UsuarioRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioRoles_Usuarios_UserId",
                        column: x => x.UserId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UsuarioTokens_Usuarios_UserId",
                        column: x => x.UserId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NumeroPago = table.Column<string>(type: "text", nullable: false),
                    DeudaId = table.Column<int>(type: "integer", nullable: false),
                    EstudianteId = table.Column<int>(type: "integer", nullable: false),
                    MontoPagado = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    FechaPago = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TipoPago = table.Column<int>(type: "integer", nullable: false),
                    NumeroOperacion = table.Column<string>(type: "text", nullable: true),
                    Banco = table.Column<string>(type: "text", nullable: true),
                    Observaciones = table.Column<string>(type: "text", nullable: true),
                    RutaComprobante = table.Column<string>(type: "text", nullable: true),
                    Anulado = table.Column<bool>(type: "boolean", nullable: false),
                    MotivoAnulacion = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagos_Deudas_DeudaId",
                        column: x => x.DeudaId,
                        principalTable: "Deudas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanesEstudio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CarreraId = table.Column<int>(type: "integer", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Version = table.Column<string>(type: "text", nullable: false),
                    AnioVigencia = table.Column<int>(type: "integer", nullable: false),
                    EsVigente = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanesEstudio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanesEstudio_Carreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "Carreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Postulantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombres = table.Column<string>(type: "text", nullable: false),
                    ApellidoPaterno = table.Column<string>(type: "text", nullable: false),
                    ApellidoMaterno = table.Column<string>(type: "text", nullable: false),
                    DNI = table.Column<string>(type: "text", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Sexo = table.Column<int>(type: "integer", nullable: false),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    Telefono = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    CarreraId = table.Column<int>(type: "integer", nullable: false),
                    PeriodoAcademicoId = table.Column<int>(type: "integer", nullable: false),
                    Estado = table.Column<int>(type: "integer", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PuntajeExamen = table.Column<decimal>(type: "numeric", nullable: true),
                    Observaciones = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postulantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Postulantes_Carreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "Carreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Postulantes_PeriodosAcademicos_PeriodoAcademicoId",
                        column: x => x.PeriodoAcademicoId,
                        principalTable: "PeriodosAcademicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AsignacionesCurso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SeccionId = table.Column<int>(type: "integer", nullable: false),
                    DocenteId = table.Column<int>(type: "integer", nullable: false),
                    EsPrincipal = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignacionesCurso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsignacionesCurso_Docentes_DocenteId",
                        column: x => x.DocenteId,
                        principalTable: "Docentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AsignacionesCurso_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asistencias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SeccionId = table.Column<int>(type: "integer", nullable: false),
                    EstudianteId = table.Column<int>(type: "integer", nullable: false),
                    FechaClase = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Estado = table.Column<int>(type: "integer", nullable: false),
                    Observacion = table.Column<string>(type: "text", nullable: true),
                    Justificado = table.Column<bool>(type: "boolean", nullable: false),
                    MotivoJustificacion = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asistencias_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asistencias_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evaluaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SeccionId = table.Column<int>(type: "integer", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Tipo = table.Column<int>(type: "integer", nullable: false),
                    PesoPromedio = table.Column<decimal>(type: "numeric(5,2)", precision: 5, scale: 2, nullable: false),
                    FechaProgramada = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NotaMaxima = table.Column<decimal>(type: "numeric(5,2)", precision: 5, scale: 2, nullable: false),
                    EsSubsanacion = table.Column<bool>(type: "boolean", nullable: false),
                    EvaluacionBaseId = table.Column<int>(type: "integer", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evaluaciones_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SeccionId = table.Column<int>(type: "integer", nullable: false),
                    DiaSemana = table.Column<int>(type: "integer", nullable: false),
                    HoraInicio = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    HoraFin = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    AulaId = table.Column<int>(type: "integer", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Horarios_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matriculas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NumeroMatricula = table.Column<string>(type: "text", nullable: false),
                    EstudianteId = table.Column<int>(type: "integer", nullable: false),
                    PeriodoAcademicoId = table.Column<int>(type: "integer", nullable: false),
                    CarreraId = table.Column<int>(type: "integer", nullable: false),
                    Ciclo = table.Column<int>(type: "integer", nullable: false),
                    TipoMatricula = table.Column<int>(type: "integer", nullable: false),
                    Estado = table.Column<int>(type: "integer", nullable: false),
                    FechaMatricula = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Observaciones = table.Column<string>(type: "text", nullable: true),
                    SeccionId = table.Column<int>(type: "integer", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matriculas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matriculas_Carreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "Carreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matriculas_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matriculas_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PromediosFinales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EstudianteId = table.Column<int>(type: "integer", nullable: false),
                    SeccionId = table.Column<int>(type: "integer", nullable: false),
                    PeriodoAcademicoId = table.Column<int>(type: "integer", nullable: false),
                    PromedioCalculado = table.Column<decimal>(type: "numeric(5,2)", precision: 5, scale: 2, nullable: true),
                    Aprobado = table.Column<bool>(type: "boolean", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromediosFinales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PromediosFinales_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PromediosFinales_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CajaMovimientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tipo = table.Column<string>(type: "text", nullable: false),
                    Concepto = table.Column<string>(type: "text", nullable: false),
                    Monto = table.Column<decimal>(type: "numeric", nullable: false),
                    Fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UsuarioCajero = table.Column<string>(type: "text", nullable: true),
                    Referencia = table.Column<string>(type: "text", nullable: true),
                    PagoId = table.Column<int>(type: "integer", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CajaMovimientos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CajaMovimientos_Pagos_PagoId",
                        column: x => x.PagoId,
                        principalTable: "Pagos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CursosMalla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PlanEstudioId = table.Column<int>(type: "integer", nullable: false),
                    CursoId = table.Column<int>(type: "integer", nullable: false),
                    Ciclo = table.Column<int>(type: "integer", nullable: false),
                    PrerrequisitoId = table.Column<int>(type: "integer", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursosMalla", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CursosMalla_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursosMalla_PlanesEstudio_PlanEstudioId",
                        column: x => x.PlanEstudioId,
                        principalTable: "PlanesEstudio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EvaluacionId = table.Column<int>(type: "integer", nullable: false),
                    EstudianteId = table.Column<int>(type: "integer", nullable: false),
                    Calificacion = table.Column<decimal>(type: "numeric(5,2)", precision: 5, scale: 2, nullable: true),
                    Observacion = table.Column<string>(type: "text", nullable: true),
                    Ausente = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notas_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notas_Evaluaciones_EvaluacionId",
                        column: x => x.EvaluacionId,
                        principalTable: "Evaluaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesMatricula",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MatriculaId = table.Column<int>(type: "integer", nullable: false),
                    SeccionId = table.Column<int>(type: "integer", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesMatricula", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetallesMatricula_Matriculas_MatriculaId",
                        column: x => x.MatriculaId,
                        principalTable: "Matriculas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesMatricula_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionesCurso_DocenteId",
                table: "AsignacionesCurso",
                column: "DocenteId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionesCurso_SeccionId",
                table: "AsignacionesCurso",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencias_EstudianteId",
                table: "Asistencias",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencias_SeccionId",
                table: "Asistencias",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_CajaMovimientos_PagoId",
                table: "CajaMovimientos",
                column: "PagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Carreras_FacultadId",
                table: "Carreras",
                column: "FacultadId");

            migrationBuilder.CreateIndex(
                name: "IX_CiclosAcademicos_PeriodoAcademicoId",
                table: "CiclosAcademicos",
                column: "PeriodoAcademicoId");

            migrationBuilder.CreateIndex(
                name: "IX_CursosMalla_CursoId",
                table: "CursosMalla",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_CursosMalla_PlanEstudioId",
                table: "CursosMalla",
                column: "PlanEstudioId");

            migrationBuilder.CreateIndex(
                name: "IX_DescuentosEstudiante_DescuentoId",
                table: "DescuentosEstudiante",
                column: "DescuentoId");

            migrationBuilder.CreateIndex(
                name: "IX_DescuentosEstudiante_EstudianteId",
                table: "DescuentosEstudiante",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesMatricula_MatriculaId",
                table: "DetallesMatricula",
                column: "MatriculaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesMatricula_SeccionId",
                table: "DetallesMatricula",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Deudas_ConceptoPagoId",
                table: "Deudas",
                column: "ConceptoPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Deudas_EstudianteId",
                table: "Deudas",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Docentes_Codigo",
                table: "Docentes",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Docentes_DNI",
                table: "Docentes",
                column: "DNI",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_DocenteId",
                table: "Documentos",
                column: "DocenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_EstudianteId",
                table: "Documentos",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_Codigo",
                table: "Estudiantes",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_DNI",
                table: "Estudiantes",
                column: "DNI",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Evaluaciones_SeccionId",
                table: "Evaluaciones",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Horarios_SeccionId",
                table: "Horarios",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_ISBN",
                table: "Libros",
                column: "ISBN");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_CarreraId",
                table: "Matriculas",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_EstudianteId",
                table: "Matriculas",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_NumeroMatricula",
                table: "Matriculas",
                column: "NumeroMatricula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_SeccionId",
                table: "Matriculas",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_EstudianteId",
                table: "Notas",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_EvaluacionId",
                table: "Notas",
                column: "EvaluacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_DeudaId",
                table: "Pagos",
                column: "DeudaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_NumeroPago",
                table: "Pagos",
                column: "NumeroPago",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Parametros_Clave",
                table: "Parametros",
                column: "Clave",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlanesEstudio_CarreraId",
                table: "PlanesEstudio",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_Postulantes_CarreraId",
                table: "Postulantes",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_Postulantes_PeriodoAcademicoId",
                table: "Postulantes",
                column: "PeriodoAcademicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_EstudianteId",
                table: "Prestamos",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_LibroId",
                table: "Prestamos",
                column: "LibroId");

            migrationBuilder.CreateIndex(
                name: "IX_PromediosFinales_EstudianteId",
                table: "PromediosFinales",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_PromediosFinales_SeccionId",
                table: "PromediosFinales",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolClaims_RoleId",
                table: "RolClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Secciones_CursoId",
                table: "Secciones",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Secciones_PeriodoAcademicoId",
                table: "Secciones",
                column: "PeriodoAcademicoId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesDocumento_EstudianteId",
                table: "SolicitudesDocumento",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarifarios_ConceptoPagoId",
                table: "Tarifarios",
                column: "ConceptoPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tesis_EstudianteId",
                table: "Tesis",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioClaims_UserId",
                table: "UsuarioClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioLogins_UserId",
                table: "UsuarioLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioRoles_RoleId",
                table: "UsuarioRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Usuarios",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Usuarios",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivosFijos");

            migrationBuilder.DropTable(
                name: "AsignacionesCurso");

            migrationBuilder.DropTable(
                name: "Asistencias");

            migrationBuilder.DropTable(
                name: "Aulas");

            migrationBuilder.DropTable(
                name: "CajaMovimientos");

            migrationBuilder.DropTable(
                name: "CiclosAcademicos");

            migrationBuilder.DropTable(
                name: "Comunicados");

            migrationBuilder.DropTable(
                name: "CursosMalla");

            migrationBuilder.DropTable(
                name: "DescuentosEstudiante");

            migrationBuilder.DropTable(
                name: "DetallesMatricula");

            migrationBuilder.DropTable(
                name: "Documentos");

            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropTable(
                name: "Instituciones");

            migrationBuilder.DropTable(
                name: "Notas");

            migrationBuilder.DropTable(
                name: "Notificaciones");

            migrationBuilder.DropTable(
                name: "Parametros");

            migrationBuilder.DropTable(
                name: "PersonalAdministrativo");

            migrationBuilder.DropTable(
                name: "Postulantes");

            migrationBuilder.DropTable(
                name: "Prestamos");

            migrationBuilder.DropTable(
                name: "PromediosFinales");

            migrationBuilder.DropTable(
                name: "RolClaims");

            migrationBuilder.DropTable(
                name: "SolicitudesDocumento");

            migrationBuilder.DropTable(
                name: "Tarifarios");

            migrationBuilder.DropTable(
                name: "Tesis");

            migrationBuilder.DropTable(
                name: "Turnos");

            migrationBuilder.DropTable(
                name: "UsuarioClaims");

            migrationBuilder.DropTable(
                name: "UsuarioLogins");

            migrationBuilder.DropTable(
                name: "UsuarioRoles");

            migrationBuilder.DropTable(
                name: "UsuarioTokens");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "PlanesEstudio");

            migrationBuilder.DropTable(
                name: "Descuentos");

            migrationBuilder.DropTable(
                name: "Matriculas");

            migrationBuilder.DropTable(
                name: "Docentes");

            migrationBuilder.DropTable(
                name: "Evaluaciones");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Deudas");

            migrationBuilder.DropTable(
                name: "Carreras");

            migrationBuilder.DropTable(
                name: "Secciones");

            migrationBuilder.DropTable(
                name: "ConceptosPago");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Facultades");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "PeriodosAcademicos");
        }
    }
}
