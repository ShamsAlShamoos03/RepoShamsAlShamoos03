using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShamsAlShamoos03.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPersonleTbl_01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategorySubImagesList",
                columns: table => new
                {
                    CategorySubImagesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleCategorySub = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NewsTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NewsDateSham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTimestring = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorySubImagesList", x => x.CategorySubImagesId);
                });

            migrationBuilder.CreateTable(
                name: "CityType",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TITLE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ALPHABETICSORT = table.Column<int>(type: "int", nullable: true),
                    Cod_h = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles_Tbl",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles_Tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sortable01_Tbl",
                columns: table => new
                {
                    Sortable01Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idsort = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sortable01_Tbl", x => x.Sortable01Id);
                });

            migrationBuilder.CreateTable(
                name: "Sortable02",
                columns: table => new
                {
                    Sortable01Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idsort = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sortable02", x => x.Sortable01Id);
                });

            migrationBuilder.CreateTable(
                name: "Sortable03_Tbl",
                columns: table => new
                {
                    Sortable01Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Idsort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sortable03_Tbl", x => x.Sortable01Id);
                });

            migrationBuilder.CreateTable(
                name: "TblLookupsData",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlphabeticSort = table.Column<int>(type: "int", nullable: true),
                    Cod_h = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblLookupsData", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CategoryImagesList",
                columns: table => new
                {
                    CategoryImagesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NewsTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NewsDateSham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTimestring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategorySubImagesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryImagesList", x => x.CategoryImagesId);
                    table.ForeignKey(
                        name: "FK_CategoryImagesList_CategorySubImagesList_CategorySubImagesId",
                        column: x => x.CategorySubImagesId,
                        principalTable: "CategorySubImagesList",
                        principalColumn: "CategorySubImagesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_Roles_Tbl_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles_Tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CategorySub",
                columns: table => new
                {
                    CategrySubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section_S01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section_S02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seed_S01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seed_S02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sortable01Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorySub", x => x.CategrySubId);
                    table.ForeignKey(
                        name: "FK_CategorySub_Sortable01_Tbl_Sortable01Id",
                        column: x => x.Sortable01Id,
                        principalTable: "Sortable01_Tbl",
                        principalColumn: "Sortable01Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblLuLookupSub",
                columns: table => new
                {
                    TblLuLookupSubbId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section_S01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section_S02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seed_S01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seed_S02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sortable01Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblLuLookupSub", x => x.TblLuLookupSubbId);
                    table.ForeignKey(
                        name: "FK_TblLuLookupSub_Sortable01_Tbl_Sortable01Id",
                        column: x => x.Sortable01Id,
                        principalTable: "Sortable01_Tbl",
                        principalColumn: "Sortable01Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CategoryGeneralSub",
                columns: table => new
                {
                    CategoryGeneralSubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sortable01Id = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryGeneralSub", x => x.CategoryGeneralSubId);
                    table.ForeignKey(
                        name: "FK_CategoryGeneralSub_Sortable02_Sortable01Id",
                        column: x => x.Sortable01Id,
                        principalTable: "Sortable02",
                        principalColumn: "Sortable01Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImagesList",
                columns: table => new
                {
                    ImagesListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abstract = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisitCount = table.Column<int>(type: "int", nullable: false),
                    ImagesListDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImagesListDateSham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagesListTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IndexImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndexImage02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceImagesListID = table.Column<byte>(type: "tinyint", nullable: false),
                    ImagesListType = table.Column<byte>(type: "tinyint", nullable: false),
                    MetaTag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryImagesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesList", x => x.ImagesListId);
                    table.ForeignKey(
                        name: "FK_ImagesList_CategoryImagesList_CategoryImagesId",
                        column: x => x.CategoryImagesId,
                        principalTable: "CategoryImagesList",
                        principalColumn: "CategoryImagesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Categories_Tbl",
                columns: table => new
                {
                    CategryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section_01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section_02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seed_01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seed_02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategrySubId = table.Column<int>(type: "int", nullable: false),
                    Sortable01Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories_Tbl", x => x.CategryId);
                    table.ForeignKey(
                        name: "FK_Categories_Tbl_CategorySub_CategrySubId",
                        column: x => x.CategrySubId,
                        principalTable: "CategorySub",
                        principalColumn: "CategrySubId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Categories_Tbl_Sortable01_Tbl_Sortable01Id",
                        column: x => x.Sortable01Id,
                        principalTable: "Sortable01_Tbl",
                        principalColumn: "Sortable01Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblLuLookup",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleEn1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlphabeticSort = table.Column<int>(type: "int", nullable: true),
                    Cod_h = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TblLuLookupSubbId = table.Column<int>(type: "int", nullable: true),
                    Sortable01Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblLuLookup", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TblLuLookup_Sortable01_Tbl_Sortable01Id",
                        column: x => x.Sortable01Id,
                        principalTable: "Sortable01_Tbl",
                        principalColumn: "Sortable01Id");
                    table.ForeignKey(
                        name: "FK_TblLuLookup_TblLuLookupSub_TblLuLookupSubbId",
                        column: x => x.TblLuLookupSubbId,
                        principalTable: "TblLuLookupSub",
                        principalColumn: "TblLuLookupSubbId");
                });

            migrationBuilder.CreateTable(
                name: "CategoriesGeneral_Tbl",
                columns: table => new
                {
                    CategoryGeneralId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryGeneralSubId = table.Column<int>(type: "int", nullable: false),
                    ooCategoryGeneralSubId = table.Column<int>(type: "int", nullable: true),
                    Sortable01Id = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesGeneral_Tbl", x => x.CategoryGeneralId);
                    table.ForeignKey(
                        name: "FK_CategoriesGeneral_Tbl_CategoryGeneralSub_CategoryGeneralSubId",
                        column: x => x.CategoryGeneralSubId,
                        principalTable: "CategoryGeneralSub",
                        principalColumn: "CategoryGeneralSubId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CategoriesGeneral_Tbl_CategoryGeneralSub_ooCategoryGeneralSubId",
                        column: x => x.ooCategoryGeneralSubId,
                        principalTable: "CategoryGeneralSub",
                        principalColumn: "CategoryGeneralSubId");
                    table.ForeignKey(
                        name: "FK_CategoriesGeneral_Tbl_Sortable01_Tbl_Sortable01Id",
                        column: x => x.Sortable01Id,
                        principalTable: "Sortable01_Tbl",
                        principalColumn: "Sortable01Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImagesListCategoryImagesList",
                columns: table => new
                {
                    ImagesListId = table.Column<int>(type: "int", nullable: false),
                    CategoryImagesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesListCategoryImagesList", x => new { x.ImagesListId, x.CategoryImagesId });
                    table.ForeignKey(
                        name: "FK_ImagesListCategoryImagesList_CategoryImagesList_CategoryImagesId",
                        column: x => x.CategoryImagesId,
                        principalTable: "CategoryImagesList",
                        principalColumn: "CategoryImagesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ImagesListCategoryImagesList_ImagesList_ImagesListId",
                        column: x => x.ImagesListId,
                        principalTable: "ImagesList",
                        principalColumn: "ImagesListId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdressEvidence01",
                columns: table => new
                {
                    AdressEvidence01ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MelliCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeOr01Work01 = table.Column<int>(type: "int", nullable: true),
                    City = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LevelExam = table.Column<int>(type: "int", nullable: true),
                    FromDateAdressEvidence01Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToDateAdressEvidence01Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sortable01Id = table.Column<int>(type: "int", nullable: true),
                    StatusAdressEvidence01 = table.Column<int>(type: "int", nullable: true),
                    IsHaveJob = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdressEvidence01", x => x.AdressEvidence01ID);
                    table.ForeignKey(
                        name: "FK_AdressEvidence01_CategoriesGeneral_Tbl_HomeOr01Work01",
                        column: x => x.HomeOr01Work01,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_AdressEvidence01_CategoriesGeneral_Tbl_LevelExam",
                        column: x => x.LevelExam,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_AdressEvidence01_CategoriesGeneral_Tbl_StatusAdressEvidence01",
                        column: x => x.StatusAdressEvidence01,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_AdressEvidence01_CityType_City",
                        column: x => x.City,
                        principalTable: "CityType",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AdressEvidence01_Sortable01_Tbl_Sortable01Id",
                        column: x => x.Sortable01Id,
                        principalTable: "Sortable01_Tbl",
                        principalColumn: "Sortable01Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Roles_Tbl_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles_Tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "EnglishExamEvidence01",
                columns: table => new
                {
                    EnglishExamEvidence01ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MelliCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LevelExam = table.Column<int>(type: "int", nullable: true),
                    FromDateEnglishExamEvidence01Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToDateEnglishExamEvidence01Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sortable01Id = table.Column<int>(type: "int", nullable: true),
                    StatusEnglishExamEvidence01 = table.Column<int>(type: "int", nullable: true),
                    IsHaveJob = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnglishExamEvidence01", x => x.EnglishExamEvidence01ID);
                    table.ForeignKey(
                        name: "FK_EnglishExamEvidence01_CategoriesGeneral_Tbl_LevelExam",
                        column: x => x.LevelExam,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_EnglishExamEvidence01_CategoriesGeneral_Tbl_StatusEnglishExamEvidence01",
                        column: x => x.StatusEnglishExamEvidence01,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_EnglishExamEvidence01_Sortable01_Tbl_Sortable01Id",
                        column: x => x.Sortable01Id,
                        principalTable: "Sortable01_Tbl",
                        principalColumn: "Sortable01Id");
                });

            migrationBuilder.CreateTable(
                name: "FlightEvidence01",
                columns: table => new
                {
                    FlightEvidence01ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: true),
                    TypeAC = table.Column<int>(type: "int", nullable: true),
                    EvidenceFlightTitle = table.Column<int>(type: "int", nullable: true),
                    DateSrartEvidenceFlightTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateEndEvidenceFlightTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MelliCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Sortable01Id = table.Column<int>(type: "int", nullable: false),
                    IsHaveJob = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightEvidence01", x => x.FlightEvidence01ID);
                    table.ForeignKey(
                        name: "FK_FlightEvidence01_CategoriesGeneral_Tbl_EvidenceFlightTitle",
                        column: x => x.EvidenceFlightTitle,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_FlightEvidence01_CategoriesGeneral_Tbl_Rate",
                        column: x => x.Rate,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_FlightEvidence01_CategoriesGeneral_Tbl_TypeAC",
                        column: x => x.TypeAC,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_FlightEvidence01_Sortable01_Tbl_Sortable01Id",
                        column: x => x.Sortable01Id,
                        principalTable: "Sortable01_Tbl",
                        principalColumn: "Sortable01Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HealthEvidence01",
                columns: table => new
                {
                    HealthEvidence01ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MelliCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HealthEvidenceTitle = table.Column<int>(type: "int", nullable: true),
                    FromDateHealthEvidenceTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToDateHealthEvidenceTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sortable01Id = table.Column<int>(type: "int", nullable: true),
                    StatusHealth01 = table.Column<int>(type: "int", nullable: true),
                    IsHaveJob = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthEvidence01", x => x.HealthEvidence01ID);
                    table.ForeignKey(
                        name: "FK_HealthEvidence01_CategoriesGeneral_Tbl_HealthEvidenceTitle",
                        column: x => x.HealthEvidenceTitle,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_HealthEvidence01_CategoriesGeneral_Tbl_StatusHealth01",
                        column: x => x.StatusHealth01,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_HealthEvidence01_Sortable01_Tbl_Sortable01Id",
                        column: x => x.Sortable01Id,
                        principalTable: "Sortable01_Tbl",
                        principalColumn: "Sortable01Id");
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    NewsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abstract = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisitCount = table.Column<int>(type: "int", nullable: false),
                    NewsDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NewsDateSham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IndexImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndexImage02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceNewsID = table.Column<byte>(type: "tinyint", nullable: false),
                    NewsType = table.Column<byte>(type: "tinyint", nullable: false),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false),
                    MetaTag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.NewsId);
                    table.ForeignKey(
                        name: "FK_News_Categories_Tbl_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories_Tbl",
                        principalColumn: "CategryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NewsCategory",
                columns: table => new
                {
                    NewsId = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Sortable01Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsCategory", x => new { x.NewsId, x.CategoryID });
                    table.ForeignKey(
                        name: "FK_NewsCategory_Categories_Tbl_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories_Tbl",
                        principalColumn: "CategryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NewsCategory_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "NewsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NewsCategory_Sortable01_Tbl_Sortable01Id",
                        column: x => x.Sortable01Id,
                        principalTable: "Sortable01_Tbl",
                        principalColumn: "Sortable01Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NewsImagesList",
                columns: table => new
                {
                    NewsImagesID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NewsId = table.Column<int>(type: "int", nullable: false),
                    ImagesListId = table.Column<int>(type: "int", nullable: false),
                    sort01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sort02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    des01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    des02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sortable01Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsImagesList", x => x.NewsImagesID);
                    table.ForeignKey(
                        name: "FK_NewsImagesList_ImagesList_ImagesListId",
                        column: x => x.ImagesListId,
                        principalTable: "ImagesList",
                        principalColumn: "ImagesListId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NewsImagesList_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "NewsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NewsImagesList_Sortable01_Tbl_Sortable01Id",
                        column: x => x.Sortable01Id,
                        principalTable: "Sortable01_Tbl",
                        principalColumn: "Sortable01Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NoNoticeEvidence01",
                columns: table => new
                {
                    NoNoticeEvidence01ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MelliCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromDateNoNoticeEvidence01Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToDateNoNoticeEvidence01Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sortable01Id = table.Column<int>(type: "int", nullable: true),
                    StatusNoNoticeEvidence01 = table.Column<int>(type: "int", nullable: true),
                    IsHaveJob = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoNoticeEvidence01", x => x.NoNoticeEvidence01ID);
                    table.ForeignKey(
                        name: "FK_NoNoticeEvidence01_CategoriesGeneral_Tbl_StatusNoNoticeEvidence01",
                        column: x => x.StatusNoNoticeEvidence01,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_NoNoticeEvidence01_Sortable01_Tbl_Sortable01Id",
                        column: x => x.Sortable01Id,
                        principalTable: "Sortable01_Tbl",
                        principalColumn: "Sortable01Id");
                });

            migrationBuilder.CreateTable(
                name: "PhoneEvidence01",
                columns: table => new
                {
                    PhoneEvidence01ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MelliCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileorPhone01 = table.Column<int>(type: "int", nullable: true),
                    City = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LevelExam = table.Column<int>(type: "int", nullable: true),
                    FromDatePhoneEvidence01Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToDatePhoneEvidence01Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sortable01Id = table.Column<int>(type: "int", nullable: true),
                    StatusPhoneEvidence01 = table.Column<int>(type: "int", nullable: true),
                    IsHaveJob = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneEvidence01", x => x.PhoneEvidence01ID);
                    table.ForeignKey(
                        name: "FK_PhoneEvidence01_CategoriesGeneral_Tbl_LevelExam",
                        column: x => x.LevelExam,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_PhoneEvidence01_CategoriesGeneral_Tbl_MobileorPhone01",
                        column: x => x.MobileorPhone01,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_PhoneEvidence01_CategoriesGeneral_Tbl_StatusPhoneEvidence01",
                        column: x => x.StatusPhoneEvidence01,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_PhoneEvidence01_CityType_City",
                        column: x => x.City,
                        principalTable: "CityType",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PhoneEvidence01_Sortable01_Tbl_Sortable01Id",
                        column: x => x.Sortable01Id,
                        principalTable: "Sortable01_Tbl",
                        principalColumn: "Sortable01Id");
                });

            migrationBuilder.CreateTable(
                name: "StandCheckWritten01_Tbl",
                columns: table => new
                {
                    StandCheckWritten01ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MelliCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MelliCodeExamer = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateExamWritten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WrittenGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WrittenTPGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmargencylimitationGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SOPLOPGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sortable01Id = table.Column<int>(type: "int", nullable: true),
                    Status01 = table.Column<int>(type: "int", nullable: true),
                    IsHaveJob = table.Column<bool>(type: "bit", nullable: true),
                    ISSUERevalidateID = table.Column<int>(type: "int", nullable: true),
                    TPorNormalID = table.Column<int>(type: "int", nullable: true),
                    MelliCodeInstructor = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateStandCheck = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradeStatusFlight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status01StandCheck = table.Column<int>(type: "int", nullable: true),
                    DateStandCheckTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradeStatusTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status01StandCheckTP = table.Column<int>(type: "int", nullable: true),
                    ResaultStatus01StandCheck = table.Column<int>(type: "int", nullable: true),
                    ResaultStandCheck = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandCheckWritten01_Tbl", x => x.StandCheckWritten01ID);
                    table.ForeignKey(
                        name: "FK_StandCheckWritten01_Tbl_CategoriesGeneral_Tbl_ISSUERevalidateID",
                        column: x => x.ISSUERevalidateID,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_StandCheckWritten01_Tbl_CategoriesGeneral_Tbl_ResaultStatus01StandCheck",
                        column: x => x.ResaultStatus01StandCheck,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_StandCheckWritten01_Tbl_CategoriesGeneral_Tbl_Status01",
                        column: x => x.Status01,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_StandCheckWritten01_Tbl_CategoriesGeneral_Tbl_Status01StandCheck",
                        column: x => x.Status01StandCheck,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_StandCheckWritten01_Tbl_CategoriesGeneral_Tbl_Status01StandCheckTP",
                        column: x => x.Status01StandCheckTP,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_StandCheckWritten01_Tbl_CategoriesGeneral_Tbl_TPorNormalID",
                        column: x => x.TPorNormalID,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_StandCheckWritten01_Tbl_Sortable01_Tbl_Sortable01Id",
                        column: x => x.Sortable01Id,
                        principalTable: "Sortable01_Tbl",
                        principalColumn: "Sortable01Id");
                });

            migrationBuilder.CreateTable(
                name: "TblHoghog01",
                columns: table => new
                {
                    Hoghog01ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsHaveJob = table.Column<bool>(type: "bit", nullable: true),
                    Year01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Month01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S2P = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NK2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_ezafe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FMR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CYK2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CDI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CDYR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CND = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CBPH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNHBPH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S2H = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHK2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CVLK2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SK2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TNDYR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TNDYRB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNK2S = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CVT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    THD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TKOZ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TKOO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TATT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TFMBBJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TFGMBBJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNBDS2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TBS2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TBS2KKF4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ARH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ARHJAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODXRAY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DARJAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TARJAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MMTB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEVF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    THE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TET = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEDM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CM6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TET1M6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TET2M6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CDYRMS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNS2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CTMS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S2SERY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S2MBS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S2SMS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S2J6MS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CM42 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S2S = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CML1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FIL99 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HSA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FMO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HSO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TTH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TTG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TG2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KHK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    T99 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    T01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HS2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HS3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HS4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HS5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FMT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FVK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FEJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FND = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FSM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    T97 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FM1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FM2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FM3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FM4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FM5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FBA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FBK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FMA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FEN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SFS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TSV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FS2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FS3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FS4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FS5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FS6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HAO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KHM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HNJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KHF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HEZ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KHS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HTO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EZF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BPB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BPI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BPD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KHR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TWN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HTF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MLK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KR4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KR5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KR6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KR7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KR8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SWP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    THM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TKD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TMD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TTT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PPK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MEN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BPS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BPM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BKM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TBI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TBK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TTF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TML = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TTS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SD6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SD7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SD8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SD9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MBA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MBI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BKD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BMD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KKD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KMD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KTT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MHG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SKG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KG1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KG2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KG3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KG4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HOM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BHS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BOS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MPS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MPM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KKS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SHR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JKS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TZH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EJB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BBK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KE3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KE4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KE5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KE6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BHM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BFM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BPK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KPK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MHM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MKD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MMD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MTT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MFM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MPK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KLB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KBM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SKM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BBI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BTS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BTF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BML = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MTS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MTF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MML = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KO7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KO8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KO9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KOA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KOC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KM1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KM2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KM3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KM4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JKG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JVP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JKK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HMK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GGK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JHM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    K2P = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SNK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NK1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NK22 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NK3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CMO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TMO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S2HBPH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FIL1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SWR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PPS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PLB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BHT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OKD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TSY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MAE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SP8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SP9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPD = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblHoghog01", x => x.Hoghog01ID);
                });

            migrationBuilder.CreateTable(
                name: "TblMaster",
                columns: table => new
                {
                    MelliCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tabaghe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasTabaghe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Benefits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Percenta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext05 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext06 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPersonelImage = table.Column<bool>(type: "bit", nullable: true),
                    IsSignatureEn = table.Column<bool>(type: "bit", nullable: true),
                    IsSignatureFa = table.Column<bool>(type: "bit", nullable: true),
                    ISFatmandeYeganGhesmat01 = table.Column<int>(type: "int", nullable: true),
                    UitID01 = table.Column<int>(type: "int", nullable: true, defaultValue: 123),
                    RateLevel = table.Column<int>(type: "int", nullable: true),
                    TakhasosFaniKhalabanMoshtarak = table.Column<int>(type: "int", nullable: true),
                    TypeAc = table.Column<int>(type: "int", nullable: true),
                    NoFolder01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoFolder02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoFolder03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UitIDGaurd01 = table.Column<int>(type: "int", nullable: true),
                    EMP_NUM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FST_NAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LST_NAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GBL_FNAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GBL_LNAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FAT_NAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INF_NUM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BRT_COD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MAR_DAT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BRT_DAT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISS_COD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISS_DAT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BLG_COD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REL_COD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REL_COD2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEX_COD = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MAR_COD = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WIF_QTY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FAM_QTY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUN_QTY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOT_QTY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MAS_COD = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HOM_DAT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMP_DAT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TYP_EMP = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EMP_ORD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMP_YEG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMP_ORD2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EDF_COD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMS_COD = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CHG_COD = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EDE_COD = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SUB_COD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EDE_DAT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LDOR_NEZ = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DUS_COD = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CUR_JOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HAZ_COD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DRJ_COD = table.Column<string>(type: "nvarchar(450)", nullable: true, defaultValue: "100"),
                    DRJ_CODA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DRJ_STT = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RST_COD = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RST_COD2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DAT_RST2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ELL_RST = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMP_GRH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMP_RAD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COD_TAA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COD_TAF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COD_TAC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SHO_JGH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COD_GHA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BND_NUM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STR_NUM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DRJ_CODJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DAT_ENT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VAZ_ENT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    END_ENT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VAZ_NGH = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OMD_YEG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YEG_COD2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DAT_YEG2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TYP_MNT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MNT_DAT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YEG_COD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRE_DAT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRN_DAT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CUR_ARS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CUR_TAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NXT_ARS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NXT_TAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FRE_QTY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SAR_QTY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LAD_QTY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DAT_BAZ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NUM_ETSH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NUM_EPAY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DAT_EPAY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TOT_AML = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TOT_AML2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZAB_MAH = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    VAZ_ESA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VAZ_GRO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NAZ_COD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DAT_NAZ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BOD_COD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DRSAD_JA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DRSAD_JB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADDRES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COD_TEL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TEL_NUM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COL_EYE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VAZN_PER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HIG_PER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIZ_FOT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIZ_KLA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OK_SAB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FER_YEG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RET_COD = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    VAZ_FAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    T_ENTER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SW_PRT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KLD_SHGL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GED_OT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CORS_T = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROSH_P = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GHE_SHR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COD_C1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COD_C2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COD_C3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COD_C4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COD_C12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COD_C78 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JOB_DES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DAT_ERTB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DAT_ERTG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TYP_GHE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DAT_RAS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHG_TYP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KHD_TYP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SOT_DAT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DAT_NGH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DAT_OMD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GHESHR = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    COD4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DAT_BAZS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployArchismDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployUniversityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploySectionCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployServiceTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LengthCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeopleCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHG_TAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHG_ENT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datMedicalClassBegin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datMedicalClassEnd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasChanged = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastChangeTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasYegan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastYegan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YEG_COD2_Tmp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasYegan_Tmp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MAK_SR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliverTypeCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Tel_workplace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel_mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    code_mosalsal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shomareh_seri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    harfe_seri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FstNamEN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LstNamEN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlightEvidence01ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StandCheckWritten01ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Hoghog01ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HealthEvidence01ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NoNoticeEvidence01ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EnglishExamEvidence01ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PhoneEvidence01ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AdressEvidence01ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TotalFlightTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalFlightTimeTimeSpan = table.Column<TimeSpan>(type: "time", nullable: true),
                    TotalFlightTimeDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastFlightDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalFlightTimeNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DayValidFlight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMSPd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMCPd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMPd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMTPd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMIPd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMSIPd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMSPN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMCPN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMPN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMIPN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMSIPN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMYN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMSPNY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMCPNY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMPNY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMIPNY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMSIPNY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMSIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMHOOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMSPHOOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMCPHOOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMPHOOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMIPHOOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMSIPHOOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMSPdNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMCPdNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMPdNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMTPdNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMIPdNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMSIPdNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMSPNNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMCPNNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMPNNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMIPNNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMSIPNNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMYNNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMSPNYNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMCPNYNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMPNYNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMIPNYNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMSIPNYNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMSIMNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMHOODNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMSPHOODNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMCPHOODNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMPHOODNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMIPHOODNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUMSIPHOODNew01 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblMaster", x => x.MelliCode);
                    table.ForeignKey(
                        name: "FK_TblMaster_AdressEvidence01_AdressEvidence01ID",
                        column: x => x.AdressEvidence01ID,
                        principalTable: "AdressEvidence01",
                        principalColumn: "AdressEvidence01ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_CategoriesGeneral_Tbl_ISFatmandeYeganGhesmat01",
                        column: x => x.ISFatmandeYeganGhesmat01,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_TblMaster_CategoriesGeneral_Tbl_RateLevel",
                        column: x => x.RateLevel,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_TblMaster_CategoriesGeneral_Tbl_TakhasosFaniKhalabanMoshtarak",
                        column: x => x.TakhasosFaniKhalabanMoshtarak,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_TblMaster_CategoriesGeneral_Tbl_TypeAc",
                        column: x => x.TypeAc,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_TblMaster_CategoriesGeneral_Tbl_UitID01",
                        column: x => x.UitID01,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_TblMaster_CategoriesGeneral_Tbl_UitIDGaurd01",
                        column: x => x.UitIDGaurd01,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_TblMaster_EnglishExamEvidence01_EnglishExamEvidence01ID",
                        column: x => x.EnglishExamEvidence01ID,
                        principalTable: "EnglishExamEvidence01",
                        principalColumn: "EnglishExamEvidence01ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_FlightEvidence01_FlightEvidence01ID",
                        column: x => x.FlightEvidence01ID,
                        principalTable: "FlightEvidence01",
                        principalColumn: "FlightEvidence01ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_HealthEvidence01_HealthEvidence01ID",
                        column: x => x.HealthEvidence01ID,
                        principalTable: "HealthEvidence01",
                        principalColumn: "HealthEvidence01ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_NoNoticeEvidence01_NoNoticeEvidence01ID",
                        column: x => x.NoNoticeEvidence01ID,
                        principalTable: "NoNoticeEvidence01",
                        principalColumn: "NoNoticeEvidence01ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_PhoneEvidence01_PhoneEvidence01ID",
                        column: x => x.PhoneEvidence01ID,
                        principalTable: "PhoneEvidence01",
                        principalColumn: "PhoneEvidence01ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_StandCheckWritten01_Tbl_StandCheckWritten01ID",
                        column: x => x.StandCheckWritten01ID,
                        principalTable: "StandCheckWritten01_Tbl",
                        principalColumn: "StandCheckWritten01ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_TblHoghog01_Hoghog01ID",
                        column: x => x.Hoghog01ID,
                        principalTable: "TblHoghog01",
                        principalColumn: "Hoghog01ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_TblLookupsData_LDOR_NEZ",
                        column: x => x.LDOR_NEZ,
                        principalTable: "TblLookupsData",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_TblLookupsData_ROSH_P",
                        column: x => x.ROSH_P,
                        principalTable: "TblLookupsData",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_TblLuLookup_CHG_COD",
                        column: x => x.CHG_COD,
                        principalTable: "TblLuLookup",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_TblLuLookup_DRJ_COD",
                        column: x => x.DRJ_COD,
                        principalTable: "TblLuLookup",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_TblLuLookup_DRJ_STT",
                        column: x => x.DRJ_STT,
                        principalTable: "TblLuLookup",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_TblLuLookup_DUS_COD",
                        column: x => x.DUS_COD,
                        principalTable: "TblLuLookup",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_TblLuLookup_DeliverTypeCode",
                        column: x => x.DeliverTypeCode,
                        principalTable: "TblLuLookup",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_TblLuLookup_EDE_COD",
                        column: x => x.EDE_COD,
                        principalTable: "TblLuLookup",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_TblLuLookup_EMS_COD",
                        column: x => x.EMS_COD,
                        principalTable: "TblLuLookup",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_TblLuLookup_GHESHR",
                        column: x => x.GHESHR,
                        principalTable: "TblLuLookup",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_TblLuLookup_MAR_COD",
                        column: x => x.MAR_COD,
                        principalTable: "TblLuLookup",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_TblLuLookup_MAS_COD",
                        column: x => x.MAS_COD,
                        principalTable: "TblLuLookup",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_TblLuLookup_RET_COD",
                        column: x => x.RET_COD,
                        principalTable: "TblLuLookup",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_TblLuLookup_RST_COD",
                        column: x => x.RST_COD,
                        principalTable: "TblLuLookup",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_TblLuLookup_SEX_COD",
                        column: x => x.SEX_COD,
                        principalTable: "TblLuLookup",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_TblLuLookup_TYP_EMP",
                        column: x => x.TYP_EMP,
                        principalTable: "TblLuLookup",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_TblLuLookup_VAZ_NGH",
                        column: x => x.VAZ_NGH,
                        principalTable: "TblLuLookup",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TblMaster_TblLuLookup_ZAB_MAH",
                        column: x => x.ZAB_MAH,
                        principalTable: "TblLuLookup",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Users_Tbl",
                columns: table => new
                {
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobsLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<byte>(type: "tinyint", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDayDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    LastPasswordChangeDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    IsActive = table.Column<byte>(type: "tinyint", nullable: false),
                    Melicode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextRequest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Personelcodes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MelliCodeID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Sortable013d = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    YeganID = table.Column<int>(type: "int", nullable: true),
                    SematID = table.Column<int>(type: "int", nullable: true),
                    ShobehID = table.Column<int>(type: "int", nullable: true),
                    RateID = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users_Tbl", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Tbl_CategoriesGeneral_Tbl_RateID",
                        column: x => x.RateID,
                        principalTable: "CategoriesGeneral_Tbl",
                        principalColumn: "CategoryGeneralId");
                    table.ForeignKey(
                        name: "FK_Users_Tbl_Categories_Tbl_SematID",
                        column: x => x.SematID,
                        principalTable: "Categories_Tbl",
                        principalColumn: "CategryId");
                    table.ForeignKey(
                        name: "FK_Users_Tbl_Categories_Tbl_ShobehID",
                        column: x => x.ShobehID,
                        principalTable: "Categories_Tbl",
                        principalColumn: "CategryId");
                    table.ForeignKey(
                        name: "FK_Users_Tbl_Categories_Tbl_YeganID",
                        column: x => x.YeganID,
                        principalTable: "Categories_Tbl",
                        principalColumn: "CategryId");
                    table.ForeignKey(
                        name: "FK_Users_Tbl_Sortable03_Tbl_Sortable013d",
                        column: x => x.Sortable013d,
                        principalTable: "Sortable03_Tbl",
                        principalColumn: "Sortable01Id");
                    table.ForeignKey(
                        name: "FK_Users_Tbl_TblMaster_MelliCodeID",
                        column: x => x.MelliCodeID,
                        principalTable: "TblMaster",
                        principalColumn: "MelliCode");
                });

            migrationBuilder.CreateTable(
                name: "UjobPesronel01_Tbl",
                columns: table => new
                {
                    UjobPesronel01ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MelliCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartJobDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndJobDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsHaveJob = table.Column<bool>(type: "bit", nullable: false),
                    StartJobDatestr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndJobDatestr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    des01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    des02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sortable01Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UjobPesronel01_Tbl", x => x.UjobPesronel01ID);
                    table.ForeignKey(
                        name: "FK_UjobPesronel01_Tbl_Sortable01_Tbl_Sortable01Id",
                        column: x => x.Sortable01Id,
                        principalTable: "Sortable01_Tbl",
                        principalColumn: "Sortable01Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UjobPesronel01_Tbl_TblMaster_MelliCode",
                        column: x => x.MelliCode,
                        principalTable: "TblMaster",
                        principalColumn: "MelliCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UjobPesronel01_Tbl_Users_Tbl_UserID",
                        column: x => x.UserID,
                        principalTable: "Users_Tbl",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsersCategory_Tbl",
                columns: table => new
                {
                    CategryId = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    sort01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sort02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    des01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    des02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sortable01Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersCategory_Tbl", x => new { x.CategryId, x.UserID });
                    table.ForeignKey(
                        name: "FK_UsersCategory_Tbl_Categories_Tbl_CategryId",
                        column: x => x.CategryId,
                        principalTable: "Categories_Tbl",
                        principalColumn: "CategryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersCategory_Tbl_Sortable01_Tbl_Sortable01Id",
                        column: x => x.Sortable01Id,
                        principalTable: "Sortable01_Tbl",
                        principalColumn: "Sortable01Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersCategory_Tbl_Users_Tbl_UserID",
                        column: x => x.UserID,
                        principalTable: "Users_Tbl",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsersCategorySub_Tbl",
                columns: table => new
                {
                    CategrySubId = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    sort01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sort02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    des01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    des02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sortable01Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersCategorySub_Tbl", x => new { x.CategrySubId, x.UserID });
                    table.ForeignKey(
                        name: "FK_UsersCategorySub_Tbl_CategorySub_CategrySubId",
                        column: x => x.CategrySubId,
                        principalTable: "CategorySub",
                        principalColumn: "CategrySubId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersCategorySub_Tbl_Sortable01_Tbl_Sortable01Id",
                        column: x => x.Sortable01Id,
                        principalTable: "Sortable01_Tbl",
                        principalColumn: "Sortable01Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersCategorySub_Tbl_Users_Tbl_UserID",
                        column: x => x.UserID,
                        principalTable: "Users_Tbl",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Roles_Tbl",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName", "RoleLevel" },
                values: new object[,]
                {
                    { "17addaba-dd6c-4c46-9993-559edf295ac8", "20572dd0-966c-42d9-a95c-f64b2abd1016", "کاربر عادی", "NORMALUSER", "NORMALUSER", "22daafff-159d-482e-92c0-72ba9d455677" },
                    { "189ed4ed-3ac3-4b20-b8c3-3b32769cf976", null, "تفویض اختیار محلی", "TafvizEkhtiar01", "TAFVIZEKHTIAR01", "22daafff-159d-482e-92c0-72ba9d455677" },
                    { "1a18cdbc-8197-49c0-92a6-747dbcb34350", "5e66b7a3-65ae-41ae-80a7-0051c9f87945", "افزودن کاربران", "AddUser", "ADDUSER", "22daafff-159d-482e-92c0-72ba9d455677" },
                    { "22daafff-159d-482e-92c0-72ba9d455677", "ce40097b-8e87-4c62-8081-8f23d7b0d334", "مدیریت کاربران", "User", "USER", "abc" },
                    { "23a68401-f865-4e1e-87a6-9bdfe2f1c773", null, "مشاهده کارکنان پایور سطح 2", "VIEWPERSONNELPAYOR02", "VIEWPERSONNELPAYOR02", "ed4a4f49-9ba5-4871-a366-ddd049006ab3" },
                    { "27162af1-d67a-49af-b8d2-766a2d4467ec", null, "افزودن فایل کارکنان پایور", "ADDFIEPERSONNELPAYOR", "ADDFIEPERSONNELPAYOR", "351d15d8-a914-41da-b3da-3e72edc82272" },
                    { "351d15d8-a914-41da-b3da-3e72edc82272", null, "مدیریت کارکنان پایور", "MANAGEPERSONNELPAYOR", "MANAGEPERSONNELPAYOR", "90579366-628e-477f-ac9a-4a7471a9986e" },
                    { "90579366-628e-477f-ac9a-4a7471a9986e", "e13fd7a2-e0ad-4597-9273-3327ef8c1776", "مدیریت کارکنان", "Personnel01", "PERSONNEL01", "abc" },
                    { "998d0d7f-18e5-4cf0-8152-e6ccf1822502", null, "افزودن فایل دو خطی حقوقی", "AddFileAccessHoghoghi01", "ADDFILEACCESSHOGHOGHI01", "351d15d8-a914-41da-b3da-3e72edc82272" },
                    { "9dec9ab3-95fa-478b-b0a4-4966b736ce97", null, "مشاهده کارکنان پایور سطح 3", "VIEWPERSONNELPAYOR03", "VIEWPERSONNELPAYOR03", "ed4a4f49-9ba5-4871-a366-ddd049006ab3" },
                    { "c993f1cb-7a97-424c-9e0f-554d402d2b92", null, "مدیریت کارکنان یگان", "MANAGEPERSONNELYEGAN", "MANAGEPERSONNELYEGAN", "90579366-628e-477f-ac9a-4a7471a9986e" },
                    { "d04ecc99-749b-4bbe-baba-d123004d2ca5", null, "مدیریت کارکنان وظیفه", "MANAGEPERSONNELVAZIFEH", "MANAGEPERSONNELVAZIFEH", "90579366-628e-477f-ac9a-4a7471a9986e" },
                    { "e414e2cc-2b05-454a-9a07-60da4d929e6c", "355f684a-3146-444c-b5cb-ff0f019bd61e", "مدیر کاربر سطح 1", "MANAGEUSER01", "MANAGEUSER01", "22daafff-159d-482e-92c0-72ba9d455677" },
                    { "e801f9db-7663-42c5-a6ca-0ee7bcb6807b", null, "مدیریت کارکنان پایور و وظیفه", "MANAGEPERSONNELPAYORVAZIFEH", "MANAGEPERSONNELPAYORVAZIFEH", "90579366-628e-477f-ac9a-4a7471a9986e" },
                    { "ed4a4f49-9ba5-4871-a366-ddd049006ab3", null, "مشاهده کارکنان پایور", "VIEWPERSONNELPAYOR", "VIEWPERSONNELPAYOR", "351d15d8-a914-41da-b3da-3e72edc82272" },
                    { "efa7d0e0-b4b8-489c-a52a-4182e2f3b3b7", null, "مدیریت کارکنان سطح 1", "Personnel02", "PERSONNEL02", "90579366-628e-477f-ac9a-4a7471a9986e" },
                    { "f23d8fb0-f077-44c7-a503-635845ab0fb1", null, "مشاهده کارکنان پایور سطح 1", "VIEWPERSONNELPAYOR01", "VIEWPERSONNELPAYOR01", "ed4a4f49-9ba5-4871-a366-ddd049006ab3" }
                });

            migrationBuilder.InsertData(
                table: "Users_Tbl",
                columns: new[] { "UserID", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FName", "FirstName", "ImagePath", "IsActive", "JobsLevel", "LName", "LastName", "LockoutEnabled", "LockoutEnd", "Melicode", "MelliCodeID", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonalCode", "Personelcodes", "PhoneNumber", "PhoneNumberConfirmed", "Rate", "RateID", "SecurityStamp", "SematID", "ShobehID", "Sortable013d", "TextRequest", "TwoFactorEnabled", "UserName", "YeganID", "gender" },
                values: new object[] { "3300697e-daa9-42c0-b3fa-99c8dfc080c3", 0, "8a56bb0c-5f2e-4953-b6bb-5cb812d0dba0", "lb123456@lb123456.com", false, "", "مدیر", "", (byte)1, "", "", "سامانه شریف", true, null, "", null, "LB123456@LB123456.COM", "LB123456", "AQAAAAIAAYagAAAAEDr2e8Jbo6sutkQJI6SCwuQ2nGko2CD4AchCPyr6lNf6bdIY/LlC9TevOqbd16O2xg==", "", "", "", false, "", null, "BFABUDNKBSPZR6OQOY5GSUGP4BI6YSX5", null, null, null, "", false, "lb123456", null, (byte)1 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1a18cdbc-8197-49c0-92a6-747dbcb34350", "3300697e-daa9-42c0-b3fa-99c8dfc080c3" },
                    { "27162af1-d67a-49af-b8d2-766a2d4467ec", "3300697e-daa9-42c0-b3fa-99c8dfc080c3" },
                    { "e414e2cc-2b05-454a-9a07-60da4d929e6c", "3300697e-daa9-42c0-b3fa-99c8dfc080c3" },
                    { "efa7d0e0-b4b8-489c-a52a-4182e2f3b3b7", "3300697e-daa9-42c0-b3fa-99c8dfc080c3" },
                    { "f23d8fb0-f077-44c7-a503-635845ab0fb1", "3300697e-daa9-42c0-b3fa-99c8dfc080c3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdressEvidence01_City",
                table: "AdressEvidence01",
                column: "City");

            migrationBuilder.CreateIndex(
                name: "IX_AdressEvidence01_HomeOr01Work01",
                table: "AdressEvidence01",
                column: "HomeOr01Work01");

            migrationBuilder.CreateIndex(
                name: "IX_AdressEvidence01_LevelExam",
                table: "AdressEvidence01",
                column: "LevelExam");

            migrationBuilder.CreateIndex(
                name: "IX_AdressEvidence01_MelliCode",
                table: "AdressEvidence01",
                column: "MelliCode",
                unique: true,
                filter: "[MelliCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AdressEvidence01_Sortable01Id",
                table: "AdressEvidence01",
                column: "Sortable01Id");

            migrationBuilder.CreateIndex(
                name: "IX_AdressEvidence01_StatusAdressEvidence01",
                table: "AdressEvidence01",
                column: "StatusAdressEvidence01");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Tbl_CategrySubId",
                table: "Categories_Tbl",
                column: "CategrySubId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Tbl_Sortable01Id",
                table: "Categories_Tbl",
                column: "Sortable01Id");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesGeneral_Tbl_CategoryGeneralSubId",
                table: "CategoriesGeneral_Tbl",
                column: "CategoryGeneralSubId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesGeneral_Tbl_ooCategoryGeneralSubId",
                table: "CategoriesGeneral_Tbl",
                column: "ooCategoryGeneralSubId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesGeneral_Tbl_Sortable01Id",
                table: "CategoriesGeneral_Tbl",
                column: "Sortable01Id");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryGeneralSub_Sortable01Id",
                table: "CategoryGeneralSub",
                column: "Sortable01Id");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryImagesList_CategorySubImagesId",
                table: "CategoryImagesList",
                column: "CategorySubImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_CategorySub_Sortable01Id",
                table: "CategorySub",
                column: "Sortable01Id");

            migrationBuilder.CreateIndex(
                name: "IX_EnglishExamEvidence01_LevelExam",
                table: "EnglishExamEvidence01",
                column: "LevelExam");

            migrationBuilder.CreateIndex(
                name: "IX_EnglishExamEvidence01_MelliCode",
                table: "EnglishExamEvidence01",
                column: "MelliCode",
                unique: true,
                filter: "[MelliCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EnglishExamEvidence01_Sortable01Id",
                table: "EnglishExamEvidence01",
                column: "Sortable01Id");

            migrationBuilder.CreateIndex(
                name: "IX_EnglishExamEvidence01_StatusEnglishExamEvidence01",
                table: "EnglishExamEvidence01",
                column: "StatusEnglishExamEvidence01");

            migrationBuilder.CreateIndex(
                name: "IX_FlightEvidence01_EvidenceFlightTitle",
                table: "FlightEvidence01",
                column: "EvidenceFlightTitle");

            migrationBuilder.CreateIndex(
                name: "IX_FlightEvidence01_MelliCode",
                table: "FlightEvidence01",
                column: "MelliCode",
                unique: true,
                filter: "[MelliCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FlightEvidence01_Rate",
                table: "FlightEvidence01",
                column: "Rate");

            migrationBuilder.CreateIndex(
                name: "IX_FlightEvidence01_Sortable01Id",
                table: "FlightEvidence01",
                column: "Sortable01Id");

            migrationBuilder.CreateIndex(
                name: "IX_FlightEvidence01_TypeAC",
                table: "FlightEvidence01",
                column: "TypeAC");

            migrationBuilder.CreateIndex(
                name: "IX_HealthEvidence01_HealthEvidenceTitle",
                table: "HealthEvidence01",
                column: "HealthEvidenceTitle");

            migrationBuilder.CreateIndex(
                name: "IX_HealthEvidence01_MelliCode",
                table: "HealthEvidence01",
                column: "MelliCode",
                unique: true,
                filter: "[MelliCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HealthEvidence01_Sortable01Id",
                table: "HealthEvidence01",
                column: "Sortable01Id");

            migrationBuilder.CreateIndex(
                name: "IX_HealthEvidence01_StatusHealth01",
                table: "HealthEvidence01",
                column: "StatusHealth01");

            migrationBuilder.CreateIndex(
                name: "IX_ImagesList_CategoryImagesId",
                table: "ImagesList",
                column: "CategoryImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagesListCategoryImagesList_CategoryImagesId",
                table: "ImagesListCategoryImagesList",
                column: "CategoryImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_News_CategoryID",
                table: "News",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_News_UserID",
                table: "News",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_NewsCategory_CategoryID",
                table: "NewsCategory",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_NewsCategory_Sortable01Id",
                table: "NewsCategory",
                column: "Sortable01Id");

            migrationBuilder.CreateIndex(
                name: "IX_NewsImagesList_ImagesListId",
                table: "NewsImagesList",
                column: "ImagesListId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsImagesList_NewsId",
                table: "NewsImagesList",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsImagesList_Sortable01Id",
                table: "NewsImagesList",
                column: "Sortable01Id");

            migrationBuilder.CreateIndex(
                name: "IX_NoNoticeEvidence01_MelliCode",
                table: "NoNoticeEvidence01",
                column: "MelliCode",
                unique: true,
                filter: "[MelliCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_NoNoticeEvidence01_Sortable01Id",
                table: "NoNoticeEvidence01",
                column: "Sortable01Id");

            migrationBuilder.CreateIndex(
                name: "IX_NoNoticeEvidence01_StatusNoNoticeEvidence01",
                table: "NoNoticeEvidence01",
                column: "StatusNoNoticeEvidence01");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneEvidence01_City",
                table: "PhoneEvidence01",
                column: "City");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneEvidence01_LevelExam",
                table: "PhoneEvidence01",
                column: "LevelExam");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneEvidence01_MelliCode",
                table: "PhoneEvidence01",
                column: "MelliCode",
                unique: true,
                filter: "[MelliCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneEvidence01_MobileorPhone01",
                table: "PhoneEvidence01",
                column: "MobileorPhone01");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneEvidence01_Sortable01Id",
                table: "PhoneEvidence01",
                column: "Sortable01Id");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneEvidence01_StatusPhoneEvidence01",
                table: "PhoneEvidence01",
                column: "StatusPhoneEvidence01");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles_Tbl",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_StandCheckWritten01_Tbl_ISSUERevalidateID",
                table: "StandCheckWritten01_Tbl",
                column: "ISSUERevalidateID");

            migrationBuilder.CreateIndex(
                name: "IX_StandCheckWritten01_Tbl_MelliCode",
                table: "StandCheckWritten01_Tbl",
                column: "MelliCode");

            migrationBuilder.CreateIndex(
                name: "IX_StandCheckWritten01_Tbl_MelliCodeExamer",
                table: "StandCheckWritten01_Tbl",
                column: "MelliCodeExamer");

            migrationBuilder.CreateIndex(
                name: "IX_StandCheckWritten01_Tbl_MelliCodeInstructor",
                table: "StandCheckWritten01_Tbl",
                column: "MelliCodeInstructor");

            migrationBuilder.CreateIndex(
                name: "IX_StandCheckWritten01_Tbl_ResaultStatus01StandCheck",
                table: "StandCheckWritten01_Tbl",
                column: "ResaultStatus01StandCheck");

            migrationBuilder.CreateIndex(
                name: "IX_StandCheckWritten01_Tbl_Sortable01Id",
                table: "StandCheckWritten01_Tbl",
                column: "Sortable01Id");

            migrationBuilder.CreateIndex(
                name: "IX_StandCheckWritten01_Tbl_Status01",
                table: "StandCheckWritten01_Tbl",
                column: "Status01");

            migrationBuilder.CreateIndex(
                name: "IX_StandCheckWritten01_Tbl_Status01StandCheck",
                table: "StandCheckWritten01_Tbl",
                column: "Status01StandCheck");

            migrationBuilder.CreateIndex(
                name: "IX_StandCheckWritten01_Tbl_Status01StandCheckTP",
                table: "StandCheckWritten01_Tbl",
                column: "Status01StandCheckTP");

            migrationBuilder.CreateIndex(
                name: "IX_StandCheckWritten01_Tbl_TPorNormalID",
                table: "StandCheckWritten01_Tbl",
                column: "TPorNormalID");

            migrationBuilder.CreateIndex(
                name: "IX_TblHoghog01_CML1",
                table: "TblHoghog01",
                column: "CML1");

            migrationBuilder.CreateIndex(
                name: "IX_TblLuLookup_Sortable01Id",
                table: "TblLuLookup",
                column: "Sortable01Id");

            migrationBuilder.CreateIndex(
                name: "IX_TblLuLookup_TblLuLookupSubbId",
                table: "TblLuLookup",
                column: "TblLuLookupSubbId");

            migrationBuilder.CreateIndex(
                name: "IX_TblLuLookupSub_Sortable01Id",
                table: "TblLuLookupSub",
                column: "Sortable01Id");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_AdressEvidence01ID",
                table: "TblMaster",
                column: "AdressEvidence01ID");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_CHG_COD",
                table: "TblMaster",
                column: "CHG_COD");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_DeliverTypeCode",
                table: "TblMaster",
                column: "DeliverTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_DRJ_COD",
                table: "TblMaster",
                column: "DRJ_COD");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_DRJ_STT",
                table: "TblMaster",
                column: "DRJ_STT");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_DUS_COD",
                table: "TblMaster",
                column: "DUS_COD");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_EDE_COD",
                table: "TblMaster",
                column: "EDE_COD");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_EMS_COD",
                table: "TblMaster",
                column: "EMS_COD");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_EnglishExamEvidence01ID",
                table: "TblMaster",
                column: "EnglishExamEvidence01ID");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_FlightEvidence01ID",
                table: "TblMaster",
                column: "FlightEvidence01ID");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_GHESHR",
                table: "TblMaster",
                column: "GHESHR");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_HealthEvidence01ID",
                table: "TblMaster",
                column: "HealthEvidence01ID");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_Hoghog01ID",
                table: "TblMaster",
                column: "Hoghog01ID");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_ISFatmandeYeganGhesmat01",
                table: "TblMaster",
                column: "ISFatmandeYeganGhesmat01");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_LDOR_NEZ",
                table: "TblMaster",
                column: "LDOR_NEZ");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_MAR_COD",
                table: "TblMaster",
                column: "MAR_COD");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_MAS_COD",
                table: "TblMaster",
                column: "MAS_COD");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_NoNoticeEvidence01ID",
                table: "TblMaster",
                column: "NoNoticeEvidence01ID");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_PhoneEvidence01ID",
                table: "TblMaster",
                column: "PhoneEvidence01ID");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_RateLevel",
                table: "TblMaster",
                column: "RateLevel");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_RET_COD",
                table: "TblMaster",
                column: "RET_COD");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_ROSH_P",
                table: "TblMaster",
                column: "ROSH_P");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_RST_COD",
                table: "TblMaster",
                column: "RST_COD");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_SEX_COD",
                table: "TblMaster",
                column: "SEX_COD");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_StandCheckWritten01ID",
                table: "TblMaster",
                column: "StandCheckWritten01ID");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_TakhasosFaniKhalabanMoshtarak",
                table: "TblMaster",
                column: "TakhasosFaniKhalabanMoshtarak");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_TYP_EMP",
                table: "TblMaster",
                column: "TYP_EMP");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_TypeAc",
                table: "TblMaster",
                column: "TypeAc");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_UitID01",
                table: "TblMaster",
                column: "UitID01");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_UitIDGaurd01",
                table: "TblMaster",
                column: "UitIDGaurd01");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_VAZ_NGH",
                table: "TblMaster",
                column: "VAZ_NGH");

            migrationBuilder.CreateIndex(
                name: "IX_TblMaster_ZAB_MAH",
                table: "TblMaster",
                column: "ZAB_MAH");

            migrationBuilder.CreateIndex(
                name: "IX_UjobPesronel01_Tbl_MelliCode",
                table: "UjobPesronel01_Tbl",
                column: "MelliCode");

            migrationBuilder.CreateIndex(
                name: "IX_UjobPesronel01_Tbl_Sortable01Id",
                table: "UjobPesronel01_Tbl",
                column: "Sortable01Id");

            migrationBuilder.CreateIndex(
                name: "IX_UjobPesronel01_Tbl_UserID",
                table: "UjobPesronel01_Tbl",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users_Tbl",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Tbl_MelliCodeID",
                table: "Users_Tbl",
                column: "MelliCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Tbl_RateID",
                table: "Users_Tbl",
                column: "RateID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Tbl_SematID",
                table: "Users_Tbl",
                column: "SematID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Tbl_ShobehID",
                table: "Users_Tbl",
                column: "ShobehID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Tbl_Sortable013d",
                table: "Users_Tbl",
                column: "Sortable013d");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Tbl_YeganID",
                table: "Users_Tbl",
                column: "YeganID");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users_Tbl",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UsersCategory_Tbl_Sortable01Id",
                table: "UsersCategory_Tbl",
                column: "Sortable01Id");

            migrationBuilder.CreateIndex(
                name: "IX_UsersCategory_Tbl_UserID",
                table: "UsersCategory_Tbl",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UsersCategorySub_Tbl_Sortable01Id",
                table: "UsersCategorySub_Tbl",
                column: "Sortable01Id");

            migrationBuilder.CreateIndex(
                name: "IX_UsersCategorySub_Tbl_UserID",
                table: "UsersCategorySub_Tbl",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_AdressEvidence01_TblMaster_MelliCode",
                table: "AdressEvidence01",
                column: "MelliCode",
                principalTable: "TblMaster",
                principalColumn: "MelliCode");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_Users_Tbl_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "Users_Tbl",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_Users_Tbl_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "Users_Tbl",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_Users_Tbl_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "Users_Tbl",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_Users_Tbl_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "Users_Tbl",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EnglishExamEvidence01_TblMaster_MelliCode",
                table: "EnglishExamEvidence01",
                column: "MelliCode",
                principalTable: "TblMaster",
                principalColumn: "MelliCode");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightEvidence01_TblMaster_MelliCode",
                table: "FlightEvidence01",
                column: "MelliCode",
                principalTable: "TblMaster",
                principalColumn: "MelliCode");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthEvidence01_TblMaster_MelliCode",
                table: "HealthEvidence01",
                column: "MelliCode",
                principalTable: "TblMaster",
                principalColumn: "MelliCode");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Users_Tbl_UserID",
                table: "News",
                column: "UserID",
                principalTable: "Users_Tbl",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NoNoticeEvidence01_TblMaster_MelliCode",
                table: "NoNoticeEvidence01",
                column: "MelliCode",
                principalTable: "TblMaster",
                principalColumn: "MelliCode");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneEvidence01_TblMaster_MelliCode",
                table: "PhoneEvidence01",
                column: "MelliCode",
                principalTable: "TblMaster",
                principalColumn: "MelliCode");

            migrationBuilder.AddForeignKey(
                name: "FK_StandCheckWritten01_Tbl_TblMaster_MelliCode",
                table: "StandCheckWritten01_Tbl",
                column: "MelliCode",
                principalTable: "TblMaster",
                principalColumn: "MelliCode");

            migrationBuilder.AddForeignKey(
                name: "FK_StandCheckWritten01_Tbl_TblMaster_MelliCodeExamer",
                table: "StandCheckWritten01_Tbl",
                column: "MelliCodeExamer",
                principalTable: "TblMaster",
                principalColumn: "MelliCode");

            migrationBuilder.AddForeignKey(
                name: "FK_StandCheckWritten01_Tbl_TblMaster_MelliCodeInstructor",
                table: "StandCheckWritten01_Tbl",
                column: "MelliCodeInstructor",
                principalTable: "TblMaster",
                principalColumn: "MelliCode");

            migrationBuilder.AddForeignKey(
                name: "FK_TblHoghog01_TblMaster_CML1",
                table: "TblHoghog01",
                column: "CML1",
                principalTable: "TblMaster",
                principalColumn: "MelliCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdressEvidence01_CategoriesGeneral_Tbl_HomeOr01Work01",
                table: "AdressEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_AdressEvidence01_CategoriesGeneral_Tbl_LevelExam",
                table: "AdressEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_AdressEvidence01_CategoriesGeneral_Tbl_StatusAdressEvidence01",
                table: "AdressEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_EnglishExamEvidence01_CategoriesGeneral_Tbl_LevelExam",
                table: "EnglishExamEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_EnglishExamEvidence01_CategoriesGeneral_Tbl_StatusEnglishExamEvidence01",
                table: "EnglishExamEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightEvidence01_CategoriesGeneral_Tbl_EvidenceFlightTitle",
                table: "FlightEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightEvidence01_CategoriesGeneral_Tbl_Rate",
                table: "FlightEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightEvidence01_CategoriesGeneral_Tbl_TypeAC",
                table: "FlightEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthEvidence01_CategoriesGeneral_Tbl_HealthEvidenceTitle",
                table: "HealthEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthEvidence01_CategoriesGeneral_Tbl_StatusHealth01",
                table: "HealthEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_NoNoticeEvidence01_CategoriesGeneral_Tbl_StatusNoNoticeEvidence01",
                table: "NoNoticeEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneEvidence01_CategoriesGeneral_Tbl_LevelExam",
                table: "PhoneEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneEvidence01_CategoriesGeneral_Tbl_MobileorPhone01",
                table: "PhoneEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneEvidence01_CategoriesGeneral_Tbl_StatusPhoneEvidence01",
                table: "PhoneEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_StandCheckWritten01_Tbl_CategoriesGeneral_Tbl_ISSUERevalidateID",
                table: "StandCheckWritten01_Tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_StandCheckWritten01_Tbl_CategoriesGeneral_Tbl_ResaultStatus01StandCheck",
                table: "StandCheckWritten01_Tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_StandCheckWritten01_Tbl_CategoriesGeneral_Tbl_Status01",
                table: "StandCheckWritten01_Tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_StandCheckWritten01_Tbl_CategoriesGeneral_Tbl_Status01StandCheck",
                table: "StandCheckWritten01_Tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_StandCheckWritten01_Tbl_CategoriesGeneral_Tbl_Status01StandCheckTP",
                table: "StandCheckWritten01_Tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_StandCheckWritten01_Tbl_CategoriesGeneral_Tbl_TPorNormalID",
                table: "StandCheckWritten01_Tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_TblMaster_CategoriesGeneral_Tbl_ISFatmandeYeganGhesmat01",
                table: "TblMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_TblMaster_CategoriesGeneral_Tbl_RateLevel",
                table: "TblMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_TblMaster_CategoriesGeneral_Tbl_TakhasosFaniKhalabanMoshtarak",
                table: "TblMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_TblMaster_CategoriesGeneral_Tbl_TypeAc",
                table: "TblMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_TblMaster_CategoriesGeneral_Tbl_UitID01",
                table: "TblMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_TblMaster_CategoriesGeneral_Tbl_UitIDGaurd01",
                table: "TblMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_AdressEvidence01_CityType_City",
                table: "AdressEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneEvidence01_CityType_City",
                table: "PhoneEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_AdressEvidence01_Sortable01_Tbl_Sortable01Id",
                table: "AdressEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_EnglishExamEvidence01_Sortable01_Tbl_Sortable01Id",
                table: "EnglishExamEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightEvidence01_Sortable01_Tbl_Sortable01Id",
                table: "FlightEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthEvidence01_Sortable01_Tbl_Sortable01Id",
                table: "HealthEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_NoNoticeEvidence01_Sortable01_Tbl_Sortable01Id",
                table: "NoNoticeEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneEvidence01_Sortable01_Tbl_Sortable01Id",
                table: "PhoneEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_StandCheckWritten01_Tbl_Sortable01_Tbl_Sortable01Id",
                table: "StandCheckWritten01_Tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_TblLuLookup_Sortable01_Tbl_Sortable01Id",
                table: "TblLuLookup");

            migrationBuilder.DropForeignKey(
                name: "FK_TblLuLookupSub_Sortable01_Tbl_Sortable01Id",
                table: "TblLuLookupSub");

            migrationBuilder.DropForeignKey(
                name: "FK_AdressEvidence01_TblMaster_MelliCode",
                table: "AdressEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_EnglishExamEvidence01_TblMaster_MelliCode",
                table: "EnglishExamEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightEvidence01_TblMaster_MelliCode",
                table: "FlightEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthEvidence01_TblMaster_MelliCode",
                table: "HealthEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_NoNoticeEvidence01_TblMaster_MelliCode",
                table: "NoNoticeEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneEvidence01_TblMaster_MelliCode",
                table: "PhoneEvidence01");

            migrationBuilder.DropForeignKey(
                name: "FK_StandCheckWritten01_Tbl_TblMaster_MelliCode",
                table: "StandCheckWritten01_Tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_StandCheckWritten01_Tbl_TblMaster_MelliCodeExamer",
                table: "StandCheckWritten01_Tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_StandCheckWritten01_Tbl_TblMaster_MelliCodeInstructor",
                table: "StandCheckWritten01_Tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_TblHoghog01_TblMaster_CML1",
                table: "TblHoghog01");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ImagesListCategoryImagesList");

            migrationBuilder.DropTable(
                name: "NewsCategory");

            migrationBuilder.DropTable(
                name: "NewsImagesList");

            migrationBuilder.DropTable(
                name: "UjobPesronel01_Tbl");

            migrationBuilder.DropTable(
                name: "UsersCategory_Tbl");

            migrationBuilder.DropTable(
                name: "UsersCategorySub_Tbl");

            migrationBuilder.DropTable(
                name: "Roles_Tbl");

            migrationBuilder.DropTable(
                name: "ImagesList");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "CategoryImagesList");

            migrationBuilder.DropTable(
                name: "Users_Tbl");

            migrationBuilder.DropTable(
                name: "CategorySubImagesList");

            migrationBuilder.DropTable(
                name: "Categories_Tbl");

            migrationBuilder.DropTable(
                name: "Sortable03_Tbl");

            migrationBuilder.DropTable(
                name: "CategorySub");

            migrationBuilder.DropTable(
                name: "CategoriesGeneral_Tbl");

            migrationBuilder.DropTable(
                name: "CategoryGeneralSub");

            migrationBuilder.DropTable(
                name: "Sortable02");

            migrationBuilder.DropTable(
                name: "CityType");

            migrationBuilder.DropTable(
                name: "Sortable01_Tbl");

            migrationBuilder.DropTable(
                name: "TblMaster");

            migrationBuilder.DropTable(
                name: "AdressEvidence01");

            migrationBuilder.DropTable(
                name: "EnglishExamEvidence01");

            migrationBuilder.DropTable(
                name: "FlightEvidence01");

            migrationBuilder.DropTable(
                name: "HealthEvidence01");

            migrationBuilder.DropTable(
                name: "NoNoticeEvidence01");

            migrationBuilder.DropTable(
                name: "PhoneEvidence01");

            migrationBuilder.DropTable(
                name: "StandCheckWritten01_Tbl");

            migrationBuilder.DropTable(
                name: "TblHoghog01");

            migrationBuilder.DropTable(
                name: "TblLookupsData");

            migrationBuilder.DropTable(
                name: "TblLuLookup");

            migrationBuilder.DropTable(
                name: "TblLuLookupSub");
        }
    }
}
