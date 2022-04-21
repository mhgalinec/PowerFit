using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PowerFit.Migrations
{
    public partial class DataPopulation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ExerciseTag",
                columns: new[] { "ExerciseTagId", "Name" },
                values: new object[,]
                {
                    { 1, "Vrat" },
                    { 12, "Podlaktica" },
                    { 11, "List" },
                    { 9, "Zadnja loža" },
                    { 8, "Kvadriceps" },
                    { 7, "Triceps" },
                    { 10, "Gluteus" },
                    { 5, "Trbušni mišići" },
                    { 4, "Leđa" },
                    { 3, "Ramena" },
                    { 2, "Prsa" },
                    { 6, "Biceps" }
                });

            migrationBuilder.InsertData(
                table: "PrimaryCategories",
                columns: new[] { "PrimaryCategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Vježbe cijelog tijela" },
                    { 2, "Gornji dio tijela" },
                    { 3, "Donji dio tijela" },
                    { 4, "Kardio vježbe" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "TypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 2, "Vježbe gdje se primarno koristi jedan mišić.", "Izolacijska vježba" },
                    { 1, "Vježbe kod kojih se koristi više skupina mišića.", "Kompaktna vježba" },
                    { 3, "Vježbe gdje nema pokreta u zglobovima i gdje se mišić drži u istom položaju.", "Statička vježba" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseId", "DeleteDate", "Description", "EnglishExerciseName", "ExerciseName", "ExerciseTypeId", "Image", "InsertDate", "IsDeleted", "UpdateDate" },
                values: new object[,]
                {
                    { 39, null, "", "Farmers walk", "Farmerov hod", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1967), false, null },
                    { 42, null, "", "Clean and press", "Nabačaj i potisak", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1978), false, null },
                    { 43, null, "", "Clean and jerk", "Nabačaj i izbačaj", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1982), false, null },
                    { 44, null, "", "Tabata", "Tabata", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1986), false, null },
                    { 45, null, "", "Rowing machine", "Sprava za veslanje", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1990), false, null },
                    { 46, null, "", "Stationary bike", "Stacionaran bicikl", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1994), false, null },
                    { 47, null, "", "Running", "Trčanje", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1997), false, null },
                    { 48, null, "", "Eliptical trainer", "Eliptični trenažer", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(2002), false, null },
                    { 49, null, "", "Snatch", "Trzaj", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(2005), false, null },
                    { 50, null, "", "Z press", "Z potisak", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(2009), false, null },
                    { 10, null, "", "Overhead triceps extension", "Triceps ekstenzija iznad glave", 2, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1835), false, null },
                    { 11, null, "", "Skullcrusher", "Potisak s čela na ravnoj klupi", 2, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1840), false, null },
                    { 13, null, "", "Barbell curl", "Stojeći pregib sa šipkom", 2, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1847), false, null },
                    { 41, null, "", "Yoke walk", "Yoke hod", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1975), false, null },
                    { 14, null, "", "Dumbbell curl", "Pregib s bučicama", 2, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1851), false, null },
                    { 19, null, "", "Lateral raise", "Lateralno podizanje", 2, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1874), false, null },
                    { 22, null, "", "Flat dumbbell flys", "Razvlačenje bučicama na ravnoj klupi", 2, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1886), false, null },
                    { 25, null, "", "V-situps", "V-podizanja", 2, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1897), false, null },
                    { 30, null, "", "Neck curl", "Fleksija vrata", 2, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1901), false, null },
                    { 31, null, "", "Neck extension", "Ekstenzija vrata", 2, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1905), false, null },
                    { 32, null, "", "Wrist curl", "Pregib zapešća", 2, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1939), false, null },
                    { 33, null, "", "Reverse wrist curl", "Obrnuti pregib zapešća", 2, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1943), false, null },
                    { 34, null, "", "Pronation", "Pronacija zapešća", 2, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1947), false, null },
                    { 35, null, "", "Supination", "Supinacija zapešća", 2, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1950), false, null },
                    { 36, null, "", "Standing calf raise", "Stojeće podizanje listova", 2, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1954), false, null },
                    { 37, null, "", "Seated calf raise", "Sjedeće podizanje listova", 2, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1958), false, null },
                    { 38, null, "", "Leg press calf raise", "Podizanje listova na nožnoj preši", 2, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1963), false, null },
                    { 15, null, "", "Hammer curl", "Pregib bučicama sa neutralnim hvatom", 2, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1855), false, null },
                    { 40, null, "", "Log clean and press", "Log nabačaj i potisak", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1971), false, null },
                    { 24, null, "", "Side plank", "Bočni plank", 3, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1894), false, null },
                    { 21, null, "", "Incline bench press", "Potisak sa kose klupe", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1882), false, null },
                    { 23, null, "", "Plank", "Plank", 3, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1889), false, null },
                    { 2, null, "", "Front squat", "Prednji čučanj", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1679), false, null },
                    { 3, null, "", "Lunge", "Iskorak", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1737), false, null },
                    { 4, null, "", "Pullup", "Zgib", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1744), false, null },
                    { 5, null, "", "Barbell row", "Veslanje u natklonu", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1750), false, null },
                    { 6, null, "", "Dumbbell row", "Veslanje sa bučicom", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1753), false, null },
                    { 7, null, "", "Conventional deadlift", "Konvencionalno mrtvo dizanje", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1757), false, null },
                    { 1, null, "", "Back squat", "Stražnji čučanj", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 185, DateTimeKind.Local).AddTicks(8570), false, null },
                    { 9, null, "", "Romanian deadlift", "Rumunjsko mrtvo dizanje", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1831), false, null },
                    { 12, null, "", "Dips", "Paralelno prodapadnje", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1843), false, null },
                    { 16, null, "", "Upright row", "Okomito veslanje", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1859), false, null }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseId", "DeleteDate", "Description", "EnglishExerciseName", "ExerciseName", "ExerciseTypeId", "Image", "InsertDate", "IsDeleted", "UpdateDate" },
                values: new object[,]
                {
                    { 17, null, "", "Overhead press", "Potisak iznad glave", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1863), false, null },
                    { 18, null, "", "Behind the neck press", "Potisak iza glave", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1867), false, null },
                    { 20, null, "", "Flat bench press", "Potisak sa ravne klupe", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1878), false, null },
                    { 8, null, "", "Sumo deadlift", "Sumo mrtvo dizanje", 1, null, new DateTime(2022, 4, 20, 10, 45, 5, 196, DateTimeKind.Local).AddTicks(1762), false, null }
                });

            migrationBuilder.InsertData(
                table: "SecondaryCategories",
                columns: new[] { "SecondaryCategoryId", "Description", "Name", "PrimaryCategoryId" },
                values: new object[,]
                {
                    { 1, "", "Vrat", 2 },
                    { 2, "Sastoje se od 3 dijela(tzv. glave) - prednji, lateralni i stražnji.", "Ramena", 2 },
                    { 3, "Sastoje se od dva mišića - gornji dio (pectoralis minor) i donji dio (pectoralis major).", "Prsa", 2 },
                    { 4, "Najveća skupina mišiča u gornjem dijelu tijela.", "Leđa", 2 },
                    { 5, "Poznati kao 6-pack, ovi mišići dolaze do izražaja kod manjeg postotka tijelesne masnoće.", "Trbušni mišići", 2 },
                    { 6, "Dvoglavi mišić.", "Biceps", 2 },
                    { 9, "Četveroglavi mišić na prednjem dijelu noge.", "Kvadriceps", 3 },
                    { 8, "", "Podlaktica", 2 },
                    { 10, "Najveća mišićna skupina na tijelu", "Gluteus", 3 },
                    { 11, "Dvoglavi mišić na stražnjem dijelu noge.", "Zadnja loža", 3 },
                    { 12, "Mišić donjeg dijela noge.", "List", 3 },
                    { 14, "", "Kardio", 4 },
                    { 7, "Troglavi mišić - čini 60% muskulature i gornjem dijelu ruke.", "Triceps", 2 },
                    { 13, "", "Cijelo tijelo", 1 }
                });

            migrationBuilder.InsertData(
                table: "ExerciseCategoryRelationship",
                columns: new[] { "ExerciseCategoryRelationshipId", "ExerciseId", "SecondaryCategoryId" },
                values: new object[,]
                {
                    { 1, 1, 9 },
                    { 61, 48, 14 },
                    { 27, 16, 4 },
                    { 26, 16, 2 },
                    { 62, 49, 13 },
                    { 63, 50, 2 },
                    { 64, 50, 7 },
                    { 21, 12, 3 },
                    { 20, 12, 2 },
                    { 19, 12, 7 },
                    { 17, 10, 7 },
                    { 18, 11, 7 },
                    { 22, 13, 6 },
                    { 23, 14, 6 },
                    { 24, 15, 6 },
                    { 25, 15, 8 },
                    { 60, 47, 14 },
                    { 59, 46, 14 },
                    { 29, 17, 2 },
                    { 30, 17, 7 },
                    { 53, 40, 13 },
                    { 54, 41, 13 },
                    { 41, 24, 5 },
                    { 55, 42, 13 },
                    { 52, 39, 13 },
                    { 38, 21, 7 },
                    { 37, 21, 3 },
                    { 15, 8, 13 },
                    { 36, 21, 2 },
                    { 35, 20, 7 },
                    { 34, 20, 3 },
                    { 33, 20, 2 },
                    { 32, 18, 7 },
                    { 31, 18, 2 },
                    { 57, 44, 14 },
                    { 58, 45, 14 },
                    { 56, 43, 13 },
                    { 28, 19, 2 },
                    { 16, 9, 13 },
                    { 48, 35, 8 },
                    { 5, 2, 10 },
                    { 49, 36, 12 }
                });

            migrationBuilder.InsertData(
                table: "ExerciseCategoryRelationship",
                columns: new[] { "ExerciseCategoryRelationshipId", "ExerciseId", "SecondaryCategoryId" },
                values: new object[,]
                {
                    { 4, 2, 9 },
                    { 7, 3, 9 },
                    { 8, 3, 10 },
                    { 9, 3, 11 },
                    { 51, 38, 12 },
                    { 47, 34, 8 },
                    { 46, 33, 8 },
                    { 10, 4, 4 },
                    { 45, 32, 8 },
                    { 6, 2, 11 },
                    { 12, 5, 4 },
                    { 44, 31, 1 },
                    { 50, 37, 12 },
                    { 13, 6, 4 },
                    { 39, 22, 3 },
                    { 2, 1, 10 },
                    { 3, 1, 11 },
                    { 42, 25, 5 },
                    { 14, 7, 13 },
                    { 43, 30, 1 },
                    { 40, 23, 5 }
                });

            migrationBuilder.InsertData(
                table: "PrimaryExerciseTagRelationship",
                columns: new[] { "PrimaryExerciseTagRelationshipId", "ExerciseId", "ExerciseTagId", "TagId" },
                values: new object[,]
                {
                    { 65, 42, null, 10 },
                    { 61, 41, null, 10 },
                    { 60, 41, null, 8 },
                    { 49, 38, null, 11 },
                    { 59, 41, null, 4 },
                    { 64, 42, null, 4 },
                    { 48, 37, null, 11 },
                    { 37, 23, null, 5 },
                    { 66, 42, null, 8 },
                    { 67, 43, null, 3 },
                    { 62, 41, null, 11 },
                    { 63, 42, null, 3 },
                    { 28, 15, null, 12 },
                    { 68, 43, null, 4 },
                    { 27, 15, null, 6 },
                    { 36, 22, null, 2 },
                    { 26, 14, null, 6 },
                    { 25, 13, null, 6 },
                    { 58, 40, null, 8 },
                    { 39, 25, null, 5 },
                    { 21, 11, null, 7 }
                });

            migrationBuilder.InsertData(
                table: "PrimaryExerciseTagRelationship",
                columns: new[] { "PrimaryExerciseTagRelationshipId", "ExerciseId", "ExerciseTagId", "TagId" },
                values: new object[,]
                {
                    { 20, 10, null, 7 },
                    { 41, 30, null, 1 },
                    { 42, 31, null, 1 },
                    { 43, 32, null, 12 },
                    { 44, 33, null, 12 },
                    { 45, 34, null, 12 },
                    { 32, 19, null, 3 },
                    { 70, 43, null, 8 },
                    { 46, 35, null, 12 },
                    { 69, 43, null, 10 },
                    { 47, 36, null, 11 },
                    { 57, 40, null, 10 },
                    { 51, 39, null, 8 },
                    { 55, 40, null, 3 },
                    { 24, 12, null, 3 },
                    { 23, 12, null, 2 },
                    { 22, 12, null, 7 },
                    { 56, 40, null, 4 },
                    { 18, 9, null, 10 },
                    { 17, 9, null, 9 },
                    { 16, 8, null, 9 },
                    { 15, 8, null, 10 },
                    { 14, 8, null, 8 },
                    { 13, 7, null, 8 },
                    { 29, 16, null, 3 },
                    { 12, 7, null, 10 },
                    { 10, 6, null, 4 },
                    { 9, 5, null, 4 },
                    { 8, 4, null, 4 },
                    { 7, 3, null, 9 },
                    { 6, 3, null, 8 },
                    { 5, 3, null, 10 },
                    { 4, 2, null, 10 },
                    { 3, 2, null, 8 },
                    { 2, 1, null, 10 },
                    { 1, 1, null, 8 },
                    { 11, 7, null, 9 },
                    { 30, 17, null, 3 },
                    { 19, 9, null, 4 },
                    { 38, 24, null, 5 },
                    { 35, 21, null, 3 },
                    { 34, 21, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "PrimaryExerciseTagRelationship",
                columns: new[] { "PrimaryExerciseTagRelationshipId", "ExerciseId", "ExerciseTagId", "TagId" },
                values: new object[,]
                {
                    { 52, 39, null, 10 },
                    { 53, 39, null, 12 },
                    { 54, 39, null, 9 },
                    { 33, 20, null, 2 },
                    { 50, 39, null, 4 },
                    { 31, 18, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "SecondaryExerciseTagRelationship",
                columns: new[] { "SecondaryExerciseTagRelationshipId", "ExerciseId", "ExerciseTagId", "TagId" },
                values: new object[,]
                {
                    { 11, 6, null, 6 },
                    { 36, 41, null, 5 },
                    { 10, 5, null, 6 },
                    { 32, 40, null, 2 },
                    { 33, 40, null, 5 },
                    { 1, 1, null, 4 },
                    { 9, 4, null, 6 },
                    { 2, 1, null, 9 },
                    { 8, 3, null, 4 },
                    { 7, 3, null, 11 },
                    { 3, 1, null, 5 },
                    { 30, 39, null, 5 },
                    { 37, 41, null, 9 },
                    { 6, 2, null, 5 },
                    { 5, 2, null, 9 },
                    { 4, 2, null, 4 },
                    { 35, 40, null, 7 },
                    { 34, 40, null, 6 },
                    { 31, 39, null, 11 },
                    { 12, 7, null, 4 },
                    { 41, 43, null, 5 },
                    { 43, 43, null, 7 },
                    { 24, 17, null, 2 },
                    { 25, 17, null, 7 },
                    { 23, 16, null, 6 },
                    { 22, 16, null, 4 },
                    { 26, 18, null, 7 },
                    { 27, 20, null, 3 },
                    { 19, 9, null, 12 },
                    { 18, 9, null, 5 },
                    { 29, 21, null, 7 },
                    { 40, 42, null, 7 },
                    { 38, 42, null, 5 },
                    { 17, 8, null, 12 },
                    { 20, 13, null, 12 },
                    { 16, 8, null, 5 }
                });

            migrationBuilder.InsertData(
                table: "SecondaryExerciseTagRelationship",
                columns: new[] { "SecondaryExerciseTagRelationshipId", "ExerciseId", "ExerciseTagId", "TagId" },
                values: new object[,]
                {
                    { 15, 8, null, 4 },
                    { 21, 14, null, 12 },
                    { 28, 20, null, 7 },
                    { 14, 7, null, 12 },
                    { 13, 7, null, 5 },
                    { 39, 42, null, 6 },
                    { 42, 43, null, 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ExerciseCategoryRelationship",
                keyColumn: "ExerciseCategoryRelationshipId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ExerciseTag",
                keyColumn: "ExerciseTagId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExerciseTag",
                keyColumn: "ExerciseTagId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExerciseTag",
                keyColumn: "ExerciseTagId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExerciseTag",
                keyColumn: "ExerciseTagId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExerciseTag",
                keyColumn: "ExerciseTagId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExerciseTag",
                keyColumn: "ExerciseTagId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExerciseTag",
                keyColumn: "ExerciseTagId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExerciseTag",
                keyColumn: "ExerciseTagId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ExerciseTag",
                keyColumn: "ExerciseTagId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ExerciseTag",
                keyColumn: "ExerciseTagId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ExerciseTag",
                keyColumn: "ExerciseTagId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ExerciseTag",
                keyColumn: "ExerciseTagId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "PrimaryExerciseTagRelationship",
                keyColumn: "PrimaryExerciseTagRelationshipId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "SecondaryExerciseTagRelationship",
                keyColumn: "SecondaryExerciseTagRelationshipId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "SecondaryCategories",
                keyColumn: "SecondaryCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SecondaryCategories",
                keyColumn: "SecondaryCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SecondaryCategories",
                keyColumn: "SecondaryCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SecondaryCategories",
                keyColumn: "SecondaryCategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SecondaryCategories",
                keyColumn: "SecondaryCategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SecondaryCategories",
                keyColumn: "SecondaryCategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SecondaryCategories",
                keyColumn: "SecondaryCategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SecondaryCategories",
                keyColumn: "SecondaryCategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SecondaryCategories",
                keyColumn: "SecondaryCategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SecondaryCategories",
                keyColumn: "SecondaryCategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SecondaryCategories",
                keyColumn: "SecondaryCategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SecondaryCategories",
                keyColumn: "SecondaryCategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SecondaryCategories",
                keyColumn: "SecondaryCategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SecondaryCategories",
                keyColumn: "SecondaryCategoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PrimaryCategories",
                keyColumn: "PrimaryCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PrimaryCategories",
                keyColumn: "PrimaryCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PrimaryCategories",
                keyColumn: "PrimaryCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PrimaryCategories",
                keyColumn: "PrimaryCategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 3);
        }
    }
}
