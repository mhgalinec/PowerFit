using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PowerFit.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExerciseTag",
                columns: table => new
                {
                    ExerciseTagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseTag", x => x.ExerciseTagId);
                });

            migrationBuilder.CreateTable(
                name: "PrimaryCategories",
                columns: table => new
                {
                    PrimaryCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryCategories", x => x.PrimaryCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HashedPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailVerified = table.Column<bool>(type: "bit", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "SecondaryCategories",
                columns: table => new
                {
                    SecondaryCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondaryCategories", x => x.SecondaryCategoryId);
                    table.ForeignKey(
                        name: "FK_SecondaryCategories_PrimaryCategories_PrimaryCategoryId",
                        column: x => x.PrimaryCategoryId,
                        principalTable: "PrimaryCategories",
                        principalColumn: "PrimaryCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    ExerciseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExerciseTypeId = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.ExerciseId);
                    table.ForeignKey(
                        name: "FK_Exercises_Types_ExerciseTypeId",
                        column: x => x.ExerciseTypeId,
                        principalTable: "Types",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseCategoryRelationship",
                columns: table => new
                {
                    ExerciseCategoryRelationshipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    SecondaryCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseCategoryRelationship", x => x.ExerciseCategoryRelationshipId);
                    table.ForeignKey(
                        name: "FK_ExerciseCategoryRelationship_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseCategoryRelationship_SecondaryCategories_SecondaryCategoryId",
                        column: x => x.SecondaryCategoryId,
                        principalTable: "SecondaryCategories",
                        principalColumn: "SecondaryCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteExercises",
                columns: table => new
                {
                    FavoriteExerciseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteExercises", x => x.FavoriteExerciseId);
                    table.ForeignKey(
                        name: "FK_FavoriteExercises_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteExercises_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrimaryExerciseTagRelationship",
                columns: table => new
                {
                    PrimaryExerciseTagRelationshipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagId = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    ExerciseTagId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryExerciseTagRelationship", x => x.PrimaryExerciseTagRelationshipId);
                    table.ForeignKey(
                        name: "FK_PrimaryExerciseTagRelationship_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrimaryExerciseTagRelationship_ExerciseTag_ExerciseTagId",
                        column: x => x.ExerciseTagId,
                        principalTable: "ExerciseTag",
                        principalColumn: "ExerciseTagId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SecondaryExerciseTagRelationship",
                columns: table => new
                {
                    SecondaryExerciseTagRelationshipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagId = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    ExerciseTagId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondaryExerciseTagRelationship", x => x.SecondaryExerciseTagRelationshipId);
                    table.ForeignKey(
                        name: "FK_SecondaryExerciseTagRelationship_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SecondaryExerciseTagRelationship_ExerciseTag_ExerciseTagId",
                        column: x => x.ExerciseTagId,
                        principalTable: "ExerciseTag",
                        principalColumn: "ExerciseTagId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseCategoryRelationship_ExerciseId",
                table: "ExerciseCategoryRelationship",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseCategoryRelationship_SecondaryCategoryId",
                table: "ExerciseCategoryRelationship",
                column: "SecondaryCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ExerciseTypeId",
                table: "Exercises",
                column: "ExerciseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteExercises_ExerciseId",
                table: "FavoriteExercises",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteExercises_UserId",
                table: "FavoriteExercises",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PrimaryExerciseTagRelationship_ExerciseId",
                table: "PrimaryExerciseTagRelationship",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_PrimaryExerciseTagRelationship_ExerciseTagId",
                table: "PrimaryExerciseTagRelationship",
                column: "ExerciseTagId");

            migrationBuilder.CreateIndex(
                name: "IX_SecondaryCategories_PrimaryCategoryId",
                table: "SecondaryCategories",
                column: "PrimaryCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SecondaryExerciseTagRelationship_ExerciseId",
                table: "SecondaryExerciseTagRelationship",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_SecondaryExerciseTagRelationship_ExerciseTagId",
                table: "SecondaryExerciseTagRelationship",
                column: "ExerciseTagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseCategoryRelationship");

            migrationBuilder.DropTable(
                name: "FavoriteExercises");

            migrationBuilder.DropTable(
                name: "PrimaryExerciseTagRelationship");

            migrationBuilder.DropTable(
                name: "SecondaryExerciseTagRelationship");

            migrationBuilder.DropTable(
                name: "SecondaryCategories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "ExerciseTag");

            migrationBuilder.DropTable(
                name: "PrimaryCategories");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
